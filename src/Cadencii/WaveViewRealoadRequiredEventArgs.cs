/*
 * WaveViewRealoadRequiredEventArgs.cs
 * Copyright © 2011 kbinani
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
//INCLUDE ./WaveViewRealoadRequiredEventArgs.java

#else
using System;

namespace cadencii{

    public class WaveViewRealoadRequiredEventArgs
    {
        public int track;
        public String file;
        public double secStart;
        public double secEnd;
    }

}
#endif
