/*
 * RenderedStatus.cs
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
#if JAVA
package cadencii;

import java.util.*;
import cadencii.*;
import cadencii.vsq.*;
import cadencii.xml.*;

#else
using System;
using cadencii.java.util;
using cadencii.vsq;

namespace cadencii
{
#endif

    public class RenderedStatus
    {
        public VsqTrack track;
#if JAVA
        @XmlGenericType( TempoTableEntry.class )
#endif
        public TempoVector tempo;
        public SequenceConfig config;

        /// <summary>
        /// コンストラクタ。trackはcloneされないが、tempoはcloneされる。
        /// </summary>
        /// <param name="track"></param>
        /// <param name="tempo"></param>
        public RenderedStatus( VsqTrack track, TempoVector tempo, SequenceConfig config )
        {
            this.track = track;
            this.tempo = new TempoVector();
            for ( Iterator<TempoTableEntry> itr = tempo.iterator(); itr.hasNext(); ) {
                this.tempo.Add( (TempoTableEntry)itr.next().clone() );
            }
            this.config = config;
        }

        public RenderedStatus()
        {
            track = new VsqTrack( 0, 0, 0 );
            tempo = new TempoVector();
            config = new SequenceConfig();
        }
    }

#if !JAVA
}
#endif
