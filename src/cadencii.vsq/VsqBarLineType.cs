/*
 * VsqBarLineType.cs
 * Copyright © 2008-2011 kbinani
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

#else
using System;

namespace cadencii.vsq
{
    using boolean = System.Boolean;
#endif

    public struct VsqBarLineType
    {
        private int m_clock;
        private boolean m_is_separator;
        private int m_denominator;
        private int m_numerator;
        private int m_bar_count;

        public int getBarCount()
        {
            return m_bar_count;
        }

        public int getLocalDenominator()
        {
            return m_denominator;
        }

        public int getLocalNumerator()
        {
            return m_numerator;
        }

        public int clock()
        {
            return m_clock;
        }

        public boolean isSeparator()
        {
            return m_is_separator;
        }

#if JAVA
        public VsqBarLineType(){
        }
#endif

        public VsqBarLineType( int clock, boolean is_separator, int denominator, int numerator, int bar_count )
        {
            m_clock = clock;
            m_is_separator = is_separator;
            m_denominator = denominator;
            m_numerator = numerator;
            m_bar_count = bar_count;
        }
    }

#if !JAVA
}
#endif
