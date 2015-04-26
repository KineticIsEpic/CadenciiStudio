/*
 * ByRef.cs
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
#if JAVA
package cadencii;
#else
using System;

namespace cadencii {
#endif

    public class ByRef<T> {
        public T value;

        public ByRef() {
        }

        public ByRef( T value_ ) {
            value = value_;
        }
    }

#if !JAVA
}
#endif
