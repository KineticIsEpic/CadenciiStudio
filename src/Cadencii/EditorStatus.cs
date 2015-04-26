/*
 * EditorStatus.cs
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
#else
namespace cadencii {
    using boolean = System.Boolean;
#endif

    public class EditorStatus {
        /// <summary>
        /// トラックのレンダリングが必要かどうかを表すフラグ
        /// </summary>
        public boolean[] renderRequired = new boolean[AppManager.MAX_NUM_TRACK];

        public EditorStatus() {
            for ( int i = 0; i < AppManager.MAX_NUM_TRACK; i++ ) {
                renderRequired[i] = false;
            }
        }

        public EditorStatus clone() {
            EditorStatus ret = new EditorStatus();
            for ( int i = 0; i < renderRequired.Length; i++ ) {
                ret.renderRequired[i] = renderRequired[i];
            }
            return ret;
        }
    }

#if !JAVA
}
#endif
