/*
 * XmlPoint.cs
 * Copyright © 2009-2011 kbinani
 *
 * This file is part of cadencii.xml.
 *
 * cadencii.xml is free software; you can redistribute it and/or
 * modify it under the terms of the BSD License.
 *
 * cadencii.xml is distributed in the hope that it will be useful,
 * but WITHOUT ANY WARRANTY; without even the implied warranty of
 * MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.
 */
#if JAVA
package cadencii.xml;

import java.awt.*;
#else
using System.Xml.Serialization;
using cadencii.java.awt;

namespace cadencii.xml {
#endif

    public class XmlPoint {
#if !JAVA
        [XmlIgnore]
#endif
        public int x;
#if !JAVA
        [XmlIgnore]
#endif
        public int y;

        public XmlPoint() {
        }

        public XmlPoint( int x_, int y_ ) {
            x = x_;
            y = y_;
        }

        public XmlPoint( Point p ) {
            x = p.x;
            y = p.y;
        }

        public Point toPoint() {
            return new Point( x, y );
        }

        public int getX() {
            return x;
        }

        public void setX( int value ) {
            x = value;
        }

        public int getY() {
            return y;
        }

        public void setY( int value ) {
            y = value;
        }

#if !JAVA
        public int X {
            get {
                return getX();
            }
            set {
                setX( value );
            }
        }

        public int Y {
            get {
                return getY();
            }
            set {
                setY( value );
            }
        }

#endif

    }

#if !JAVA
}
#endif
