/*
 * VsqBPPair.cs
 * Copyright © 2009-2011 kbinani
 *
 * This file is part of cadencii.vsq.
 *
 * cadencii.vsq is free software; you can redistribute it and/or
 * modify it under the terms of the BSD License.
 *
 * cadencii.vsq is distributed in the hope that it will be useful,
 * but WITHOUT ANY WARRANTY; without even the implied warranty of
 * MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.
 */
#if JAVA
package cadencii.vsq;

import java.io.*;
#else
using System;

namespace cadencii.vsq
{
#endif

#if JAVA
    public class VsqBPPair implements Cloneable, Serializable
#else
    [Serializable]
    public struct VsqBPPair
#endif
    {
        public int value;
        public long id;

        public VsqBPPair( int value_, long id_ )
        {
            value = value_;
            id = id_;
        }

#if JAVA
        public Object clone(){
            return new VsqBPPair( value, id );
        }
#endif
    }

#if !JAVA
}
#endif
