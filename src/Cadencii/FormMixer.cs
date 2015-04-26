/*
 * FormMixer.cs
 * Copyright © 2008-2011 kbinani
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
#if JAVA
package cadencii;

//INCLUDE-SECTION IMPORT ./ui/java/FormMixer.java

import java.awt.*;
import java.util.*;
import javax.swing.*;
import cadencii.*;
import cadencii.apputil.*;
import cadencii.vsq.*;
import cadencii.windows.forms.*;
#else
using System;
using System.Drawing;
using System.Windows.Forms;
using cadencii.apputil;
using cadencii.java.awt;
using cadencii.java.util;
using cadencii.javax.swing;
using cadencii.vsq;
using cadencii.windows.forms;

namespace cadencii
{
    using boolean = System.Boolean;
    using Integer = System.Int32;
#endif

#if JAVA
    public class FormMixer extends BForm
#else
    public class FormMixer : Form
#endif
    {
#if JAVA
        final int SCROLL_HEIGHT = 15;
#endif
        private FormMain m_parent;
        private Vector<VolumeTracker> m_tracker = null;
        private boolean mPreviousAlwaysOnTop;

        public event FederChangedEventHandler FederChanged;

        public event PanpotChangedEventHandler PanpotChanged;

        public event SoloChangedEventHandler SoloChanged;

        public event MuteChangedEventHandler MuteChanged;

        public FormMixer( FormMain parent )
        {
#if JAVA
            super();
            initialize();
#else
            InitializeComponent();
#endif
            registerEventHandlers();
            setResources();
            volumeMaster.setFeder( 0 );
            volumeMaster.setMuted( false );
            volumeMaster.setSolo( true );
            volumeMaster.setNumber( "Master" );
            volumeMaster.setPanpot( 0 );
            volumeMaster.setSoloButtonVisible( false );
            volumeMaster.setTitle( "" );
            applyLanguage();
            m_parent = parent;
#if !JAVA
            this.TopMost = true;
            this.SetStyle( ControlStyles.DoubleBuffer, true );
#endif
        }

        #region public methods
        /// <summary>
        /// AlwaysOnTopが強制的にfalseにされる直前の，AlwaysOnTop値を取得します．
        /// </summary>
        public boolean getPreviousAlwaysOnTop()
        {
            return mPreviousAlwaysOnTop;
        }
        
        /// <summary>
        /// AlwaysOnTopが強制的にfalseにされる直前の，AlwaysOnTop値を設定しておきます．
        /// </summary>
        public void setPreviousAlwaysOnTop( boolean value )
        {
            mPreviousAlwaysOnTop = value;
        }

        /// <summary>
        /// マスターボリュームのUIコントロールを取得します
        /// </summary>
        /// <returns></returns>
        public VolumeTracker getVolumeTrackerMaster()
        {
            return volumeMaster;
        }

        /// <summary>
        /// 指定したトラックのボリュームのUIコントロールを取得します
        /// </summary>
        /// <param name="track"></param>
        /// <returns></returns>
        public VolumeTracker getVolumeTracker( int track )
        {
            VsqFileEx vsq = AppManager.getVsqFile();
            if ( 1 <= track && track < vsq.Track.size() &&
                 0 <= track - 1 && track - 1 < m_tracker.size() ) {
                return m_tracker.get( track - 1 );
            } else if ( track == 0 ) {
                return volumeMaster;
            } else {
                return null;
            }
        }

        /// <summary>
        /// 指定したBGMのボリュームのUIコントロールを取得します
        /// </summary>
        /// <param name="index"></param>
        /// <returns></returns>
        public VolumeTracker getVolumeTrackerBgm( int index )
        {
            VsqFileEx vsq = AppManager.getVsqFile();
            int offset = vsq.Track.size() - 1;
            if ( 0 <= index + offset && index + offset < m_tracker.size() ) {
                return m_tracker.get( index + offset );
            } else {
                return null;
            }
        }

        /// <summary>
        /// ソロ，ミュートのボタンのチェック状態を更新します
        /// </summary>
        private void updateSoloMute()
        {
            VsqFileEx vsq = AppManager.getVsqFile();
            if ( vsq == null ) {
                return;
            }
            // マスター
            boolean masterMuted = vsq.getMasterMute();
            volumeMaster.setMuted( masterMuted );

            // VSQのトラック
            boolean soloSpecificationExists = false; // 1トラックでもソロ指定があればtrue
            for ( int i = 1; i < vsq.Track.size(); i++ ) {
                if ( vsq.getSolo( i ) ) {
                    soloSpecificationExists = true;
                    break;
                }
            }
            for ( int track = 1; track < vsq.Track.size(); track++ ) {
                if ( soloSpecificationExists ) {
                    if ( vsq.getSolo( track ) ) {
                        m_tracker.get( track - 1 ).setSolo( true );
                        m_tracker.get( track - 1 ).setMuted( masterMuted ? true : vsq.getMute( track ) );
                    } else {
                        m_tracker.get( track - 1 ).setSolo( false );
                        m_tracker.get( track - 1 ).setMuted( true );
                    }
                } else {
                    m_tracker.get( track - 1 ).setSolo( vsq.getSolo( track ) );
                    m_tracker.get( track - 1 ).setMuted( masterMuted ? true : vsq.getMute( track ) );
                }
            }

            // BGM
            int offset = vsq.Track.size() - 1;
            for ( int i = 0; i < vsq.BgmFiles.size(); i++ ) {
                m_tracker.get( offset + i ).setMuted( masterMuted ? true : vsq.BgmFiles.get( i ).mute == 1 );
            }

            this.Refresh();
        }

        public void applyShortcut( Keys shortcut )
        {
            menuVisualReturn.ShortcutKeys = shortcut;
        }

        public void applyLanguage()
        {
            this.Text = _( "Mixer" );
        }

        /// <summary>
        /// 現在のシーケンスの状態に応じて，ミキサーウィンドウの状態を更新します
        /// </summary>
        public void updateStatus()
        {
            VsqFileEx vsq = AppManager.getVsqFile();
            int num = vsq.Mixer.Slave.size() + AppManager.getBgmCount();
            if ( m_tracker == null ) {
                m_tracker = new Vector<VolumeTracker>();
            }

            // イベントハンドラをいったん解除する
            unregisterEventHandlers();

#if JAVA
            // panelに追加済みのものをいったん除去する
            for( int i = 0; i < m_tracker.size(); i++ ){
                panelSlaves.remove( m_tracker.get( i ) );
            }
#endif

            // trackerの総数が変化したかどうか
            boolean num_changed = (m_tracker.size() != num);
            
            // trackerに過不足があれば数を調節
            if ( m_tracker.size() < num ) {
                int remain = num - m_tracker.size();
                for ( int i = 0; i < remain; i++ ) {
                    VolumeTracker item = new VolumeTracker();
#if !JAVA
                    item.BorderStyle = BorderStyle.FixedSingle;
                    item.Size = volumeMaster.Size;
#endif
                    m_tracker.add( item );
                }
            } else if ( m_tracker.size() > num ) {
                int delete = m_tracker.size() - num;
                for ( int i = 0; i < delete; i++ ) {
                    int indx = m_tracker.size() - 1;
                    VolumeTracker tr = m_tracker.get( indx );
                    m_tracker.removeElementAt( indx );
#if !JAVA
                    tr.Dispose();
#endif
                }
            }

            // 同時に表示できるVolumeTrackerの個数を計算
            int max = PortUtil.getWorkingArea( this ).width;
            int bordersize = 4;// TODO: ここもともとは SystemInformation.FrameBorderSize;だった
            int max_client_width = max - 2 * bordersize;
            int max_num = (int)Math.Floor( max_client_width / (VolumeTracker.WIDTH + 1.0f) );
            num++;

            int screen_num = num <= max_num ? num : max_num; //スクリーン上に表示するVolumeTrackerの個数

            // panelSlaves上に配置するVolumeTrackerの個数
            int num_vtracker_on_panel = vsq.Mixer.Slave.size() + AppManager.getBgmCount();
            // panelSlaves上に一度に表示可能なVolumeTrackerの個数
            int panel_capacity = max_num - 1;

#if !JAVA
            if ( panel_capacity >= num_vtracker_on_panel ) {
                // volumeMaster以外の全てのVolumeTrackerを，画面上に同時表示可能
                hScroll.Minimum = 0;
                hScroll.Value = 0;
                hScroll.Maximum = 0;
                hScroll.LargeChange = 1;
                hScroll.Size = new Size( (VolumeTracker.WIDTH + 1) * num_vtracker_on_panel, 15 );
            } else {
                // num_vtracker_on_panel個のVolumeTrackerのうち，panel_capacity個しか，画面上に同時表示できない
                hScroll.Minimum = 0;
                hScroll.Value = 0;
                hScroll.Maximum = num_vtracker_on_panel * VolumeTracker.WIDTH;
                hScroll.LargeChange = panel_capacity * VolumeTracker.WIDTH;
                hScroll.Size = new Size( (VolumeTracker.WIDTH + 1) * panel_capacity, 15 );
            }
            hScroll.Location = new System.Drawing.Point( 0, VolumeTracker.HEIGHT );
#endif

            int j = -1;
            for ( Iterator<VsqMixerEntry> itr = vsq.Mixer.Slave.iterator(); itr.hasNext(); ) {
                VsqMixerEntry vme = itr.next();
                j++;
#if DEBUG
                sout.println( "FormMixer#updateStatus; #" + j + "; feder=" + vme.Feder + "; panpot=" + vme.Panpot );
#endif
                VolumeTracker tracker = m_tracker.get( j );
                tracker.setFeder( vme.Feder );
                tracker.setPanpot( vme.Panpot );
                tracker.setTitle( vsq.Track.get( j + 1 ).getName() );
                tracker.setNumber( (j + 1) + "" );
                tracker.setLocation( j * (VolumeTracker.WIDTH + 1), 0 );
                tracker.setSoloButtonVisible( true );
                tracker.setMuted( (vme.Mute == 1) );
                tracker.setSolo( (vme.Solo == 1) );
                tracker.setTrack( j + 1 );
                tracker.setSoloButtonVisible( true );
#if JAVA
                tracker.setPreferredSize( new Dimension( VolumeTracker.WIDTH, VolumeTracker.HEIGHT ) );
#endif
                addToPanelSlaves( tracker, j );
            }
            int count = AppManager.getBgmCount();
            for ( int i = 0; i < count; i++ ) {
                j++;
                BgmFile item = AppManager.getBgm( i );
                VolumeTracker tracker = m_tracker.get( j );
                tracker.setFeder( item.feder );
                tracker.setPanpot( item.panpot );
                tracker.setTitle( PortUtil.getFileName( item.file ) );
                tracker.setNumber( "" );
                tracker.setLocation( j * (VolumeTracker.WIDTH + 1), 0 );
                tracker.setSoloButtonVisible( false );
                tracker.setMuted( (item.mute == 1) );
                tracker.setSolo( false );
                tracker.setTrack( -i - 1 );
                tracker.setSoloButtonVisible( false );
#if JAVA
                tracker.setPreferredSize( new Dimension( VolumeTracker.WIDTH, VolumeTracker.HEIGHT ) );
#endif
                addToPanelSlaves( tracker, j );
            }
#if DEBUG
            sout.println( "FormMixer#updateStatus; vsq.Mixer.MasterFeder=" + vsq.Mixer.MasterFeder );
#endif
            volumeMaster.setFeder( vsq.Mixer.MasterFeder );
            volumeMaster.setPanpot( vsq.Mixer.MasterPanpot );
            volumeMaster.setSoloButtonVisible( false );

            updateSoloMute();

            // イベントハンドラを再登録
            reregisterEventHandlers();

            // ウィンドウのサイズを更新（必要なら）
            if( num_changed ){
#if JAVA
                this.setResizable( true );
                scrollSlaves.setPreferredSize( new Dimension( (VolumeTracker.WIDTH + 1) * (screen_num - 1), VolumeTracker.HEIGHT ) );
                JPanel c = getJContentPane();
                Dimension size = c.getSize();
                Rectangle rc = new Rectangle();
                rc = c.getBounds( rc );
                int xdiff = this.getWidth() - rc.width;
                int ydiff = this.getHeight() - rc.height;
                int w = screen_num * (VolumeTracker.WIDTH + 1) + 3;
                int h = VolumeTracker.HEIGHT + SCROLL_HEIGHT;
                pack();
                this.setResizable( false );
#else
                panelSlaves.Width = (VolumeTracker.WIDTH + 1) * (screen_num - 1);
                volumeMaster.Location = new System.Drawing.Point( (screen_num - 1) * (VolumeTracker.WIDTH + 1) + 3, 0 );
                this.MaximumSize = Size.Empty;
                this.MinimumSize = Size.Empty;
                this.ClientSize = new Size( screen_num * (VolumeTracker.WIDTH + 1) + 3, VolumeTracker.HEIGHT + hScroll.Height );
                this.MinimumSize = this.Size;
                this.MaximumSize = this.Size;
                this.Invalidate();
                //m_parent.requestFocusInWindow(); // <-要る？
#endif
            }
        }
        #endregion

        #region helper methods
        private void addToPanelSlaves( VolumeTracker item, int ix )
        {
#if JAVA
            GridBagConstraints gbc = new GridBagConstraints();
            gbc.gridx = ix;
            gbc.gridy = 0;
            gbc.weightx = 1.0D;
            gbc.weighty = 1.0D;
            gbc.anchor = GridBagConstraints.WEST;
            gbc.fill = GridBagConstraints.VERTICAL;
            panelSlaves.add( item, gbc );
#else
            panelSlaves.Controls.Add( item );
#endif
        }

        private static String _( String id )
        {
            return Messaging.getMessage( id );
        }

        private void unregisterEventHandlers()
        {
            int size = 0;
            if ( m_tracker != null ) {
                size = m_tracker.size();
            }
            for ( int i = 0; i < size; i++ ) {
                VolumeTracker item = m_tracker.get( i );
                item.PanpotChanged -= new PanpotChangedEventHandler( FormMixer_PanpotChanged );
                item.FederChanged -= new FederChangedEventHandler( FormMixer_FederChanged );
                item.MuteButtonClick -= new EventHandler( FormMixer_MuteButtonClick );
                item.SoloButtonClick -= new EventHandler( FormMixer_SoloButtonClick );
            }
            volumeMaster.PanpotChanged -= new PanpotChangedEventHandler( volumeMaster_PanpotChanged );
            volumeMaster.FederChanged -= new FederChangedEventHandler( volumeMaster_FederChanged );
            volumeMaster.MuteButtonClick -= new EventHandler( volumeMaster_MuteButtonClick );
        }

        /// <summary>
        /// ボリューム用のイベントハンドラを再登録します
        /// </summary>
        private void reregisterEventHandlers()
        {
            int size = 0;
            if ( m_tracker != null ) {
                size = m_tracker.size();
            }
            for ( int i = 0; i < size; i++ ) {
                VolumeTracker item = m_tracker.get( i );
                item.PanpotChanged += new PanpotChangedEventHandler( FormMixer_PanpotChanged );
                item.FederChanged += new FederChangedEventHandler( FormMixer_FederChanged );
                item.MuteButtonClick += new EventHandler( FormMixer_MuteButtonClick );
                item.SoloButtonClick += new EventHandler( FormMixer_SoloButtonClick );
            }
            volumeMaster.PanpotChanged += new PanpotChangedEventHandler( volumeMaster_PanpotChanged );
            volumeMaster.FederChanged += new FederChangedEventHandler( volumeMaster_FederChanged );
            volumeMaster.MuteButtonClick += new EventHandler( volumeMaster_MuteButtonClick );
        }

        private void registerEventHandlers()
        {
            menuVisualReturn.Click += new EventHandler( menuVisualReturn_Click );
            hScroll.ValueChanged += new EventHandler( veScrollBar_ValueChanged );
            this.FormClosing += new FormClosingEventHandler( FormMixer_FormClosing );
            this.Load += new EventHandler( FormMixer_Load );
            reregisterEventHandlers();
        }

        private void setResources()
        {
            this.Icon = Properties.Resources.Icon1;
        }

        private void invokePanpotChangedEvent( int track, int panpot )
        {
#if JAVA
            try{
                panpotChangedEvent.raise( track, panpot );
            }catch( Exception ex ){
            }
#elif QT_VERSION
            panpotChanged( track, panpot );
#else
            if ( PanpotChanged != null ) {
                PanpotChanged.Invoke( track, panpot );
            }
#endif
        }

        private void invokeFederChangedEvent( int track, int feder )
        {
#if JAVA
            try{
                federChangedEvent.raise( track, feder );
            }catch( Exception ex ){
            }
#elif QT_VERSION
            federChanged( track, feder );
#else
            if ( FederChanged != null ) {
                FederChanged.Invoke( track, feder );
            }
#endif
        }

        private void invokeSoloChangedEvent( int track, boolean solo )
        {
#if JAVA
            try{
                soloChangedEvent.raise( track, solo );
            }catch( Exception ex ){
            }
#elif QT_VERSION
            soloChanged( track, solo );
#else
            if ( SoloChanged != null ) {
                SoloChanged.Invoke( track, solo );
            }
#endif
        }

        private void invokeMuteChangedEvent( int track, boolean mute )
        {
#if JAVA
            try{
                muteChangedEvent.raise( track, mute );
            }catch( Exception ex ){
            }
#elif QT_VERSION
            muteChanged( track, mute );
#else
            if ( MuteChanged != null ) {
                MuteChanged.Invoke( track, mute );
            }
#endif
        }
        #endregion

        #region event handlers
        public void FormMixer_Load( Object sender, EventArgs e )
        {
#if DEBUG
            sout.println( "FormMixer#FormMixer_Load" );
#endif
            this.TopMost = true;
        }
        
        public void FormMixer_PanpotChanged( int track, int panpot )
        {
            try {
                invokePanpotChangedEvent( track, panpot );
            } catch ( Exception ex ) {
                Logger.write( typeof( FormMixer ) + ".FormMixer_PanpotChanged; ex=" + ex + "\n" );
                serr.println( "FormMixer#FormMixer_PanpotChanged; ex=" + ex );
            }
        }

        public void FormMixer_FederChanged( int track, int feder )
        {
            try {
                invokeFederChangedEvent( track, feder );
            } catch ( Exception ex ) {
                Logger.write( typeof( FormMixer ) + ".FormMixer_FederChanged; ex=" + ex + "\n" );
                serr.println( "FormMixer#FormMixer_FederChanged; ex=" + ex );
            }
        }

        public void FormMixer_SoloButtonClick( Object sender, EventArgs e )
        {
            VolumeTracker parent = (VolumeTracker)sender;
            int track = parent.getTrack();
            try {
                invokeSoloChangedEvent( track, parent.isSolo() );
            } catch ( Exception ex ) {
                Logger.write( typeof( FormMixer ) + ".FormMixer_SoloButtonClick; ex=" + ex + "\n" );
                serr.println( "FormMixer#FormMixer_IsSoloChanged; ex=" + ex );
            }
            updateSoloMute();
        }

        public void FormMixer_MuteButtonClick( Object sender, EventArgs e )
        {
            VolumeTracker parent = (VolumeTracker)sender;
            int track = parent.getTrack();
            try {
                invokeMuteChangedEvent( track, parent.isMuted() );
            } catch ( Exception ex ) {
                Logger.write( typeof( FormMixer ) + ".FormMixer_MuteButtonClick; ex=" + ex + "\n" );
                serr.println( "FormMixer#FormMixer_IsMutedChanged; ex=" + ex );
            }
            updateSoloMute();
        }

        public void menuVisualReturn_Click( Object sender, EventArgs e )
        {
            this.Visible = false;
        }

        public void FormMixer_FormClosing( Object sender, FormClosingEventArgs e )
        {
            this.Visible = false;
#if !JAVA
            e.Cancel = true;
#endif
        }

#if !JAVA
        public void veScrollBar_ValueChanged( Object sender, EventArgs e )
        {
            int stdx = hScroll.Value;
            for ( int i = 0; i < m_tracker.size(); i++ ) {
                m_tracker.get( i ).setLocation( -stdx + (VolumeTracker.WIDTH + 1) * i, 0 );
            }
            this.Invalidate();
        }
#endif

        public void volumeMaster_FederChanged( int track, int feder )
        {
            try {
                invokeFederChangedEvent( 0, feder );
            } catch ( Exception ex ) {
                Logger.write( typeof( FormMixer ) + ".volumeMaster_FederChanged; ex=" + ex + "\n" );
                serr.println( "FormMixer#volumeMaster_FederChanged; ex=" + ex );
            }
        }

        public void volumeMaster_PanpotChanged( int track, int panpot )
        {
            try {
                invokePanpotChangedEvent( 0, panpot );
            } catch ( Exception ex ) {
                Logger.write( typeof( FormMixer ) + ".volumeMaster_PanpotChanged; ex=" + ex + "\n" );
                serr.println( "FormMixer#volumeMaster_PanpotChanged; ex=" + ex );
            }
        }

        public void volumeMaster_MuteButtonClick( Object sender, EventArgs e )
        {
            try {
                invokeMuteChangedEvent( 0, volumeMaster.isMuted() );
            } catch ( Exception ex ) {
                Logger.write( typeof( FormMixer ) + ".volumeMaster_MuteButtonClick; ex=" + ex + "\n" );
                serr.println( "FormMixer#volumeMaster_IsMutedChanged; ex=" + ex );
            }
        }
        #endregion

        #region UI implementation
#if JAVA
        #region UI Impl for Java
        //INCLUDE-SECTION FIELD ./ui/java/FormMixer.java
        //INCLUDE-SECTION METHOD ./ui/java/FormMixer.java
        #endregion
#else
        #region UI Impl for C#
        /// <summary>
        /// 必要なデザイナ変数です。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 使用中のリソースをすべてクリーンアップします。
        /// </summary>
        /// <param name="disposing">マネージ リソースが破棄される場合 true、破棄されない場合は false です。</param>
        protected override void Dispose( boolean disposing )
        {
            if ( disposing && (components != null) ) {
                components.Dispose();
            }
            base.Dispose( disposing );
        }

        #region Windows フォーム デザイナで生成されたコード

        /// <summary>
        /// デザイナ サポートに必要なメソッドです。このメソッドの内容を
        /// コード エディタで変更しないでください。
        /// </summary>
        private void InitializeComponent()
        {
            this.menuMain = new MenuStrip();
            this.menuVisual = new ToolStripMenuItem();
            this.menuVisualReturn = new ToolStripMenuItem();
            this.panelSlaves = new UserControl();
            this.hScroll = new HScrollBar();
            this.volumeMaster = new cadencii.VolumeTracker();
            this.menuMain.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuMain
            // 
            this.menuMain.Items.AddRange( new System.Windows.Forms.ToolStripItem[] {
            this.menuVisual} );
            this.menuMain.Location = new System.Drawing.Point( 0, 0 );
            this.menuMain.Name = "menuMain";
            this.menuMain.Size = new System.Drawing.Size( 170, 26 );
            this.menuMain.TabIndex = 1;
            this.menuMain.Text = "menuStrip1";
            this.menuMain.Visible = false;
            // 
            // menuVisual
            // 
            this.menuVisual.DropDownItems.AddRange( new System.Windows.Forms.ToolStripItem[] {
            this.menuVisualReturn} );
            this.menuVisual.Name = "menuVisual";
            this.menuVisual.Size = new System.Drawing.Size( 57, 22 );
            this.menuVisual.Text = "表示(&V)";
            // 
            // menuVisualReturn
            // 
            this.menuVisualReturn.Name = "menuVisualReturn";
            this.menuVisualReturn.ShortcutKeys = System.Windows.Forms.Keys.F3;
            this.menuVisualReturn.Size = new System.Drawing.Size( 177, 22 );
            this.menuVisualReturn.Text = "エディタ画面へ戻る";
            // 
            // panelSlaves
            // 
            this.panelSlaves.Location = new System.Drawing.Point( 0, 0 );
            this.panelSlaves.Margin = new System.Windows.Forms.Padding( 0 );
            this.panelSlaves.Name = "panelSlaves";
            this.panelSlaves.Size = new System.Drawing.Size( 85, 284 );
            this.panelSlaves.TabIndex = 6;
            // 
            // hScroll
            // 
            this.hScroll.LargeChange = 2;
            this.hScroll.Location = new System.Drawing.Point( 0, 284 );
            this.hScroll.Maximum = 1;
            this.hScroll.Name = "hScroll";
            this.hScroll.Size = new System.Drawing.Size( 85, 19 );
            this.hScroll.TabIndex = 0;
            // 
            // volumeMaster
            // 
            this.volumeMaster.BackColor = System.Drawing.Color.FromArgb( ((int)(((byte)(180)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))) );
            this.volumeMaster.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.volumeMaster.Location = new System.Drawing.Point( 85, 0 );
            this.volumeMaster.Margin = new System.Windows.Forms.Padding( 0 );
            this.volumeMaster.Name = "volumeMaster";
            this.volumeMaster.Size = new System.Drawing.Size( 85, 284 );
            this.volumeMaster.TabIndex = 5;
            // 
            // FormMixer
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb( ((int)(((byte)(180)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))) );
            this.ClientSize = new System.Drawing.Size( 170, 304 );
            this.Controls.Add( this.hScroll );
            this.Controls.Add( this.panelSlaves );
            this.Controls.Add( this.volumeMaster );
            this.Controls.Add( this.menuMain );
            this.DoubleBuffered = true;
            this.MainMenuStrip = this.menuMain;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormMixer";
            this.ShowInTaskbar = false;
            this.Text = "Mixer";
            this.menuMain.ResumeLayout( false );
            this.menuMain.PerformLayout();
            this.ResumeLayout( false );
            this.PerformLayout();

        }

        #endregion

        private MenuStrip menuMain;
        private ToolStripMenuItem menuVisual;
        private ToolStripMenuItem menuVisualReturn;
        private VolumeTracker volumeMaster;
        private UserControl panelSlaves;
        private HScrollBar hScroll;
        #endregion
#endif
        #endregion

    }

#if !JAVA
}
#endif
