#if !JAVA
/*
 * awt.geom.cs
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
namespace cadencii.java
{

    public class AffineTransform
    {
        System.Drawing.Drawing2D.Matrix m_matrix;

        public AffineTransform()
        {
            m_matrix = new System.Drawing.Drawing2D.Matrix();
        }

        public AffineTransform( float m00, float m10, float m01, float m11, float m02, float m12 )
        {
            m_matrix = new System.Drawing.Drawing2D.Matrix( m00, m01, m10, m11, m02, m12 );
        }
    }

}
#endif
