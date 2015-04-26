/*
 * BPPair.cs
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

import java.io.*;
#elif __cplusplus
namespace org{ namespace kbinani{ namespace vsq{
#else
using System;

namespace cadencii.vsq
{
#endif

    /// <summary>
    /// ゲートタイムと、何らかのパラメータ値とのペアを表します。主にVsqBPListで使用します。
    /// </summary>
#if JAVA
    public class BPPair implements Comparable<BPPair>, Serializable
#elif __cplusplus
    class BPPair
#else
    [Serializable]
    public class BPPair : IComparable<BPPair>
#endif
    {
        public int Clock;
        public int Value;

        /// <summary>
        /// このインスタンスと、指定したオブジェクトを比較します
        /// </summary>
        /// <param name="item"></param>
        /// <returns></returns>
        public int compareTo( BPPair item )
        {
            if ( Clock > item.Clock )
            {
                return 1;
            }
            else if ( Clock < item.Clock )
            {
                return -1;
            }
            else
            {
                return 0;
            }
#if __cplusplus
        };
#else
        }
#endif

#if JAVA
#elif __cplusplus
#else
        public int CompareTo( BPPair item )
        {
            return compareTo( item );
        }
#endif

        /// <summary>
        /// 指定されたゲートタイムとパラメータ値を使って、新しいインスタンスを初期化します。
        /// </summary>
        /// <param name="clock_"></param>
        /// <param name="value_"></param>
        public BPPair( int clock_, int value_ )
        {
            Clock = clock_;
            Value = value_;
#if __cplusplus
        };
#else
        }
#endif
    };

#if JAVA
#elif __cplusplus
} } }
#else
}
#endif
