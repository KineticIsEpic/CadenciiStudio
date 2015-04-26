#if ENABLE_AQUESTONE
/*
 * AquesToneWaveGenerator.cs
 * Copyright © 2010-2011 kbinani
 *
 * This file is part of cadencii.
 *
 * cadencii is free software; you can redistribute it and/or
 * modify it under the terms of the GPLv3 License.
 *
 * cadencii is distributed in the hope that it will be useful,
 * but WITHOUT ANY WARRANTY; without even the implied warranty of
 * MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.
 */
using System;
using System.Threading;
using cadencii.java.awt;
using cadencii.java.util;
using cadencii.media;
using cadencii.vsq;

namespace cadencii
{
    using boolean = System.Boolean;
    using Float = System.Single;
    using Integer = System.Int32;

#if JAVA
    public class AquesToneWaveGenerator implements WaveGenerator
#else
    public class AquesToneWaveGenerator : AquesToneWaveGeneratorBase
#endif
    {
        private AquesToneDriver mDriver;

        public AquesToneWaveGenerator( AquesToneDriver driver )
        {
            mDriver = driver;
        }

        protected override AquesToneDriverBase getDriver()
        {
            return mDriver;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="vsq"></param>
        /// <param name="track"></param>
        /// <param name="clock_start"></param>
        /// <param name="clock_end"></param>
        /// <returns></returns>
        protected override EventQueueSequence generateMidiEvent( VsqFileEx vsq, int track, int clock_start, int clock_end )
        {
            EventQueueSequence list = new EventQueueSequence();
            VsqTrack t = vsq.Track.get( track );

            addSingerEvents( list, t, clock_start, clock_end );

            // ノートon, off
            Vector<Point> pit_send = new Vector<Point>(); // PITが追加されたゲートタイム。音符先頭の分を重複して送信するのを回避するために必要。
            VsqBPList pit = t.getCurve( "pit" );
            VsqBPList pbs = t.getCurve( "pbs" );
            VsqBPList dyn = t.getCurve( "dyn" );
            VsqBPList bre = t.getCurve( "bre" );
            VsqBPList cle = t.getCurve( "cle" );
            VsqBPList por = t.getCurve( "por" );
            for ( Iterator<VsqEvent> itr = t.getNoteEventIterator(); itr.hasNext(); ) {
                VsqEvent item = itr.next();
                int endclock = item.Clock + item.ID.getLength();
                boolean contains_start = clock_start <= item.Clock && item.Clock <= clock_end;
                boolean contains_end = clock_start <= endclock && endclock <= clock_end;
                if ( contains_start || contains_end ) {
                    if ( contains_start ) {
                        #region contains_start
                        // noteonのゲートタイムが，範囲に入っている
                        // noteon MIDIイベントを作成

                        MidiEvent[] noteOnEvents = mDriver.createNoteOnEvent( item.ID.Note, item.ID.Dynamics, item.ID.LyricHandle.L0.Phrase );
                        if ( noteOnEvents.Length > 0 ) {
                            MidiEventQueue queue = list.get( item.Clock );

                            Vector<MidiEvent> add = Arrays.asList( noteOnEvents );
                            queue.noteon.addAll( add );
                            pit_send.add( new Point( item.Clock, item.Clock ) );
                        }

                        /* 音符頭で設定するパラメータ */
                        // Release
                        MidiEventQueue q = list.get( item.Clock );

                        String strRelease = VsqFileEx.getEventTag( item, VsqFileEx.TAG_VSQEVENT_AQUESTONE_RELEASE );
                        int release = 64;
                        try {
                            release = int.Parse( strRelease );
                        } catch ( Exception ex ) {
                            Logger.write( typeof( AquesToneWaveGenerator ) + ".generateMidiEvent; ex=" + ex + "\n" );
                            release = 64;
                        }
                        ParameterEvent pe = new ParameterEvent();
                        pe.index = mDriver.releaseParameterIndex;
                        pe.value = release / 127.0f;
                        q.param.add( pe );

                        // dyn
                        int dynAtStart = dyn.getValue( item.Clock );
                        ParameterEvent peDyn = new ParameterEvent();
                        peDyn.index = mDriver.volumeParameterIndex;
                        peDyn.value = (float)(dynAtStart - dyn.getMinimum()) / (float)(dyn.getMaximum() - dyn.getMinimum());
                        q.param.add( peDyn );

                        // bre
                        int breAtStart = bre.getValue( item.Clock );
                        ParameterEvent peBre = new ParameterEvent();
                        peBre.index = mDriver.haskyParameterIndex;
                        peBre.value = (float)(breAtStart - bre.getMinimum()) / (float)(bre.getMaximum() - bre.getMinimum());
                        q.param.add( peBre );

                        // cle
                        int cleAtStart = cle.getValue( item.Clock );
                        ParameterEvent peCle = new ParameterEvent();
                        peCle.index = mDriver.resonancParameterIndex;
                        peCle.value = (float)(cleAtStart - cle.getMinimum()) / (float)(cle.getMaximum() - cle.getMinimum());
                        q.param.add( peCle );

                        // por
                        int porAtStart = por.getValue( item.Clock );
                        ParameterEvent pePor = new ParameterEvent();
                        pePor.index = mDriver.portaTimeParameterIndex;
                        pePor.value = (float)(porAtStart - por.getMinimum()) / (float)(por.getMaximum() - por.getMinimum());
                        q.param.add( pePor );
                        #endregion
                    }

                    // ビブラート
                    // ビブラートが存在する場合、PBSは勝手に変更する。
                    if ( item.ID.VibratoHandle == null ) {
                        if ( contains_start ) {
                            // 音符頭のPIT, PBSを強制的に指定
                            int notehead_pit = pit.getValue( item.Clock );
                            MidiEvent pit0 = getPitMidiEvent( notehead_pit );
                            MidiEventQueue queue = list.get( item.Clock );
                            queue.pit.clear();
                            queue.pit.add( pit0 );
                            int notehead_pbs = pbs.getValue( item.Clock );
                            ParameterEvent pe = new ParameterEvent();
                            pe.index = mDriver.bendLblParameterIndex;
                            pe.value = notehead_pbs / 13.0f;
                            queue.param.add( pe );
                        }
                    } else {
                        int delta_clock = 5;  //ピッチを取得するクロック間隔
                        int tempo = 120;
                        double sec_start_act = vsq.getSecFromClock( item.Clock );
                        double sec_end_act = vsq.getSecFromClock( item.Clock + item.ID.getLength() );
                        double delta_sec = delta_clock / (8.0 * tempo); //ピッチを取得する時間間隔
                        float pitmax = 0.0f;
                        int st = item.Clock;
                        if ( st < clock_start ) {
                            st = clock_start;
                        }
                        int end = item.Clock + item.ID.getLength();
                        if ( clock_end < end ) {
                            end = clock_end;
                        }
                        pit_send.add( new Point( st, end ) );
                        // ビブラートが始まるまでのピッチを取得
                        double sec_vibstart = vsq.getSecFromClock( item.Clock + item.ID.VibratoDelay );
                        int pit_count = (int)((sec_vibstart - sec_start_act) / delta_sec);
                        TreeMap<Integer, Float> pit_change = new TreeMap<Integer, Float>();
                        for ( int i = 0; i < pit_count; i++ ) {
                            double gtime = sec_start_act + delta_sec * i;
                            int clock = (int)vsq.getClockFromSec( gtime );
                            float pvalue = (float)t.getPitchAt( clock );
                            pitmax = Math.Max( pitmax, Math.Abs( pvalue ) );
                            pit_change.put( clock, pvalue );
                        }
                        // ビブラート部分のピッチを取得
                        Vector<PointD> ret = new Vector<PointD>();
                        Iterator<PointD> itr2 = new VibratoPointIteratorBySec(
                            vsq,
                            item.ID.VibratoHandle.getRateBP(),
                            item.ID.VibratoHandle.getStartRate(),
                            item.ID.VibratoHandle.getDepthBP(),
                            item.ID.VibratoHandle.getStartDepth(),
                            item.Clock + item.ID.VibratoDelay,
                            item.ID.getLength() - item.ID.VibratoDelay,
                            (float)delta_sec );
                        for ( ; itr2.hasNext(); ) {
                            PointD p = itr2.next();
                            float gtime = (float)p.getX();
                            int clock = (int)vsq.getClockFromSec( gtime );
                            float pvalue = (float)(t.getPitchAt( clock ) + p.getY() * 100.0);
                            pitmax = Math.Max( pitmax, Math.Abs( pvalue ) );
                            pit_change.put( clock, pvalue );
                        }

                        // ピッチベンドの最大値を実現するのに必要なPBS
                        int required_pbs = (int)Math.Ceiling( pitmax / 100.0 );
#if DEBUG
                        sout.println( "AquesToneRenderingRunner#generateMidiEvent; required_pbs=" + required_pbs );
#endif
                        if ( required_pbs > 13 ) {
                            required_pbs = 13;
                        }
                        MidiEventQueue queue = list.get( item.Clock );
                        ParameterEvent pe = new ParameterEvent();
                        pe.index = mDriver.bendLblParameterIndex;
                        pe.value = required_pbs / 13.0f;
                        queue.param.add( pe );

                        // PITを順次追加
                        for ( Iterator<Integer> itr3 = pit_change.keySet().iterator(); itr3.hasNext(); ) {
                            Integer clock = itr3.next();
                            if ( clock_start <= clock && clock <= clock_end ) {
                                float pvalue = pit_change.get( clock );
                                int pit_value = (int)(8192.0 / (double)required_pbs * pvalue / 100.0);
                                MidiEventQueue q = list.get( clock );
                                MidiEvent me = getPitMidiEvent( pit_value );
                                q.pit.clear();
                                q.pit.add( me );
                            } else if ( clock_end < clock ) {
                                break;
                            }
                        }
                    }

                    //pit_send.add( pit_send_p );

                    // noteoff MIDIイベントを作成
                    if ( contains_end ) {
                        MidiEvent noteoff = new MidiEvent();
                        noteoff.firstByte = 0x80;
                        noteoff.data = new int[] { item.ID.Note, 0x40 }; // ここのvel
                        Vector<MidiEvent> a_noteoff = Arrays.asList( new MidiEvent[] { noteoff } );
                        MidiEventQueue q = list.get( endclock );
                        q.noteoff.addAll( a_noteoff );
                        pit_send.add( new Point( endclock, endclock ) ); // PITの送信を抑制するために必要
                    }
                }

                if ( clock_end < item.Clock ) {
                    break;
                }
            }

            // pitch bend sensitivity
            // RPNで送信するのが上手くいかないので、parameterを直接いぢる
            if ( pbs != null ) {
                int keycount = pbs.size();
                for ( int i = 0; i < keycount; i++ ) {
                    int clock = pbs.getKeyClock( i );
                    if ( clock_start <= clock && clock <= clock_end ) {
                        int value = pbs.getElementA( i );
                        ParameterEvent pbse = new ParameterEvent();
                        pbse.index = mDriver.bendLblParameterIndex;
                        pbse.value = value / 13.0f;
                        MidiEventQueue queue = list.get( clock );
                        queue.param.add( pbse );
                    } else if ( clock_end < clock ) {
                        break;
                    }
                }
            }

            // pitch bend
            if ( pit != null ) {
                int keycount = pit.size();
                for ( int i = 0; i < keycount; i++ ) {
                    int clock = pit.getKeyClock( i );
                    if ( clock_start <= clock && clock <= clock_end ) {
                        boolean contains = false;
                        for ( Iterator<Point> itr = pit_send.iterator(); itr.hasNext(); ) {
                            Point p = itr.next();
                            if ( p.x <= clock && clock <= p.y ) {
                                contains = true;
                                break;
                            }
                        }
                        if ( contains ) {
                            continue;
                        }
                        int value = pit.getElementA( i );
                        MidiEvent pbs0 = getPitMidiEvent( value );
                        MidiEventQueue queue = list.get( clock );
                        queue.pit.clear();
                        queue.pit.add( pbs0 );
                    } else if ( clock_end < clock ) {
                        break;
                    }
                }
            }

            appendParameterEvents( list, dyn, mDriver.volumeParameterIndex, clock_start, clock_end );
            appendParameterEvents( list, bre, mDriver.haskyParameterIndex, clock_start, clock_end );
            appendParameterEvents( list, cle, mDriver.resonancParameterIndex, clock_start, clock_end );
            appendParameterEvents( list, por, mDriver.portaTimeParameterIndex, clock_start, clock_end );

            return list;
        }


        /// <summary>
        /// 歌手変更イベントを、イベントキューに追加する
        /// </summary>
        /// <param name="queueSequence">追加対象のイベントキュー</param>
        /// <param name="track">歌手変更イベントを取り出すトラック</param>
        /// <param name="start">時間区間の開始位置</param>
        /// <param name="end">時間区間の終了位置</param>
        private void addSingerEvents( EventQueueSequence queueSequence, VsqTrack track, int start, int end )
        {
            var iterator = track.getSingerEventIterator( start, end );
            while ( iterator.hasNext() ) {
                var item = iterator.next();
                if ( item.ID.IconHandle == null ) {
                    continue;
                }
                int program = item.ID.IconHandle.Program;
                var singer = mDriver.createSingerEvent( program );
                if ( 0 < singer.Length ) {
                    var queue = queueSequence.get( item.Clock );
                    queue.param.addAll( Arrays.asList( singer ) );
                }
            }
        }

        private static MidiEvent getPitMidiEvent( int pitch_bend )
        {
            int value = (0x3fff & (pitch_bend + 0x2000));
            int msb = 0xff & (value >> 7);
            int lsb = 0xff & (value - (msb << 7));
            MidiEvent pbs0 = new MidiEvent();
            pbs0.firstByte = 0xE0;
            pbs0.data = new int[] { lsb, msb };
            return pbs0;
        }

        private static void appendParameterEvents( EventQueueSequence list, VsqBPList cle, int parameter_index, int clock_start, int clock_end )
        {
            int max = cle.getMaximum();
            int min = cle.getMinimum();
            float order = 1.0f / (float)(max - min);
            if ( cle != null ) {
                int keycount = cle.size();
                for ( int i = 0; i < keycount; i++ ) {
                    int clock = cle.getKeyClock( i );
                    if ( clock_start <= clock && clock <= clock_end ) {
                        int value = cle.getElementA( i );
                        MidiEventQueue queue = list.get( clock );
                        ParameterEvent pe = new ParameterEvent();
                        pe.index = parameter_index;
                        pe.value = (value - min) * order;
                        queue.param.add( pe );
                    } else if ( clock_end < clock ) {
                        break;
                    }
                }
            }
        }
    }

}
#endif
