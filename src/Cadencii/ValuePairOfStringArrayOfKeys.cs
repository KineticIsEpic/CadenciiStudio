/*
 * ValuePairOfStringArrayOfKeys.cs
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

import cadencii.windows.forms.*;
#else
using System;
using System.Xml.Serialization;
using System.Windows.Forms;
using cadencii.windows.forms;

namespace cadencii {
#endif

    public class ValuePairOfStringArrayOfKeys {
        public String Key;
        [XmlArrayItem("Keys")]
        public Keys[] Value;

        public ValuePairOfStringArrayOfKeys() {
        }

        public ValuePairOfStringArrayOfKeys( String key, Keys[] value ) {
            Key = key;
            Value = value;
        }
    }

#if !JAVA
}
#endif
