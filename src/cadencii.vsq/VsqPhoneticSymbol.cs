/*
 * VsqPhoneticSymbol.cs
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

import cadencii.*;
#else
using System;
using cadencii;

namespace cadencii.vsq
{
    using boolean = System.Boolean;
#endif

    /// <summary>
    /// VSQで使用される発音記号の種類や有効性を判定するユーティリティ群です。
    /// </summary>
    public class VsqPhoneticSymbol
    {
        private static String[] _SYMBOL_VOWEL_JP = new String[]{
            "a",
            "i",
            "M",
            "e",
            "o",
        };
        private static String[] _SYMBOL_CONSONANT_JP = new String[]{
            "k",
            "k'",
            "g",
            "g'",
            "N",
            "N'",
            "s",
            "S",
            "z",
            "Z",
            "dz",
            "dZ",
            "t",
            "t'",
            "ts",
            "tS",
            "d",
            "d'",
            "n",
            "J",
            "h",
            "h\\",
            "C",
            "p\\",
            "p\\'",
            "b",
            "b'",
            "p",
            "p'",
            "m",
            "m'",
            "j",
            "4",
            "4'",
            "w",
            "N\\",
        };
        private static String[] _SYMBOL_VOWEL_EN = new String[]{
            "@",
            "V",
            "e",
            "e",
            "I",
            "i:",
            "{",
            "O:",
            "Q",
            "U",
            "u:",
            "@r",
            "eI",
            "aI",
            "OI",
            "@U",
            "aU",
            "I@",
            "e@",
            "U@",
            "O@",
            "Q@",
        };
        private static String[] _SYMBOL_CONSONANT_EN = new String[]{        
            "w",
            "j",
            "b",
            "d",
            "g",
            "bh",
            "dh",
            "gh",
            "dZ",
            "v",
            "D",
            "z",
            "Z",
            "m",
            "n",
            "N",
            "r",
            "l",
            "l0",
            "p",
            "t",
            "k",
            "ph",
            "th",
            "kh",
            "tS",
            "f",
            "T",
            "s",
            "S",
            "h",
            "Sil",
            "Asp",
        };

        /// <summary>
        /// 指定した文字列が子音を表す発音記号かどうかを判定します。
        /// </summary>
        /// <param name="symbol"></param>
        /// <returns></returns>
        public static boolean isConsonant( String symbol )
        {
            for ( int i = 0; i < _SYMBOL_CONSONANT_JP.Length; i++ ) {
                String s = _SYMBOL_CONSONANT_JP[i];
                if ( s.Equals( symbol ) ) {
                    return true;
                }
            }
            foreach ( String s in _SYMBOL_CONSONANT_EN ) {
                if ( s == symbol ) {
                    return true;
                }
            }
            return false;
        }

        /// <summary>
        /// 指定した文字列が発音記号として有効かどうかを判定します。
        /// </summary>
        /// <param name="symbol"></param>
        /// <returns></returns>
        public static boolean isValidSymbol( String symbol )
        {
            foreach ( String s in _SYMBOL_VOWEL_JP ) {
                if ( s == symbol ) {
                    return true;
                }
            }
            foreach ( String s in _SYMBOL_CONSONANT_JP ) {
                if ( s == symbol ) {
                    return true;
                }
            }
            foreach ( String s in _SYMBOL_VOWEL_EN ) {
                if ( s == symbol ) {
                    return true;
                }
            }
            foreach ( String s in _SYMBOL_CONSONANT_EN ) {
                if ( s == symbol ) {
                    return true;
                }
            }

            // ブレスの判定
            int strlen = PortUtil.getStringLength( symbol );
            if ( symbol.StartsWith( "br" ) && strlen > 2 ) {
                String s = symbol.Substring( 2 );
                try {
                    // br001とかをfalseにするためのチェック
                    int num = int.Parse( s );
                    if ( s.Equals( "" + num ) ) {
                        return true;
                    }
                } catch ( Exception ex ) {
                }
            }
            return false;
        }
    }

#if !JAVA
}
#endif
