#if !JAVA
/*
 * swing.cs
 * Copyright © 2009-2011 kbinani
 *
 * This file is part of cadencii.core.
 *
 * cadencii.core is free software; you can redistribute it and/or
 * modify it under the terms of the BSD License.
 *
 * cadencii.core is distributed in the hope that it will be useful,
 * but WITHOUT ANY WARRANTY; without even the implied warranty of
 * MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.
 */
using System;
using cadencii.java.awt.event_;

namespace cadencii.javax.swing
{

    public class KeyStroke
    {
        public System.Windows.Forms.Keys keys = System.Windows.Forms.Keys.None;
        private static cadencii.java.util.TreeMap<string, int> keyCodes = null;

        private KeyStroke()
        {
        }

        public int getKeyCode()
        {
            System.Windows.Forms.Keys k = keys;
            if ( (keys & System.Windows.Forms.Keys.Alt) == System.Windows.Forms.Keys.Alt ) {
                k -= System.Windows.Forms.Keys.Alt;
            }
            if ( (keys & System.Windows.Forms.Keys.Control) == System.Windows.Forms.Keys.Control ) {
                k -= System.Windows.Forms.Keys.Control;
            }
            if ( (keys & System.Windows.Forms.Keys.Shift) == System.Windows.Forms.Keys.Shift ) {
                k -= System.Windows.Forms.Keys.Shift;
            }
            return (int)k;
        }

        public int getModifiers()
        {
            int modifier = 0;
            if ( (keys & System.Windows.Forms.Keys.Alt) == System.Windows.Forms.Keys.Alt ) {
                modifier += InputEvent.ALT_MASK;
            }
            if ( (keys & System.Windows.Forms.Keys.Control) == System.Windows.Forms.Keys.Control ) {
                modifier += InputEvent.CTRL_MASK;
            }
            if ( (keys & System.Windows.Forms.Keys.Shift) == System.Windows.Forms.Keys.Shift ) {
                modifier += InputEvent.SHIFT_MASK;
            }
            return modifier;
        }

        public static KeyStroke getKeyStroke( int keyCode, int modifiers )
        {
            KeyStroke ret = new KeyStroke();
            if ( (InputEvent.ALT_MASK & modifiers) == InputEvent.ALT_MASK ) {
                ret.keys = ret.keys | System.Windows.Forms.Keys.Alt;
            }
            if ( (InputEvent.CTRL_MASK & modifiers) == InputEvent.CTRL_MASK ) {
                ret.keys = ret.keys | System.Windows.Forms.Keys.Control;
            }
            if ( (InputEvent.SHIFT_MASK & modifiers) == InputEvent.SHIFT_MASK ) {
                ret.keys = ret.keys | System.Windows.Forms.Keys.Shift;
            }
            System.Windows.Forms.Keys key = (System.Windows.Forms.Keys)keyCode;
            ret.keys = ret.keys | key;
            return ret;
        }

        public bool equals( Object value )
        {
            if ( value == null ) {
                return false;
            }
            if ( !(value is KeyStroke) ) {
                return false;
            }
            KeyStroke stroke = (KeyStroke)value;
            return (this.keys == stroke.keys);
        }

#if !JAVA
        public override bool Equals( object obj )
        {
            return equals( obj );
        }
#endif

    }

}
#endif
