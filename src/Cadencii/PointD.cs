/*
 * PointD.cs
 * Copyright © 2009-2011 kbinani
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

import java.awt.*;
import java.io.*;

#else

using System;
using cadencii.java.awt;

namespace cadencii
{
#endif

#if JAVA
    public class PointD implements Serializable
#else
    [Serializable]
    public struct PointD
#endif
    {
        private double m_x;
        private double m_y;

        public PointD( PointD item )
        {
            m_x = item.getX();
            m_y = item.getY();
        }

        public PointD( double x, double y ) {
            m_x = x;
            m_y = y;
        }

#if JAVA
        public PointD() {
            m_x = 0;
            m_y = 0;
        }
#endif

        public Point toPoint() {
            return new Point( (int)m_x, (int)m_y );
        }

        /*public System.Drawing.PointF toPointF() {
            return new System.Drawing.PointF( (float)m_x, (float)m_y );
        }*/

        public double getX() {
            return m_x;
        }

        public void setX( double value ) {
            m_x = value;
        }

        public double getY() {
            return m_y;
        }

        public void setY( double value ) {
            m_y = value;
        }

#if !JAVA
        /// <summary>
        /// XMLシリアライズ用
        /// </summary>
        public double X {
            get {
                return getX();
            }
            set {
                setX( value );
            }
        }

        /// <summary>
        /// XMLシリアライズ用
        /// </summary>
        public double Y {
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
