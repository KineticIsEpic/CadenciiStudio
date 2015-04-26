#if !__FormBeatConfigUiListener__
#define __FormBeatConfigUiListener__
/*
 * FormBeatConfigUiListener.cs
 * Copyright © 2011 kbinani
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

    namespace cadencii
    {

#endif

#if __cplusplus
            class FormBeatConfigUiListener
#else
            public interface FormBeatConfigUiListener
#endif
            {
#if __cplusplus
            public:
#endif
                [PureVirtualFunction]
                void buttonCancelClickedSlot();

                [PureVirtualFunction]
                void buttonOkClickedSlot();

                [PureVirtualFunction]
                void checkboxEndCheckedChangedSlot();
            };

#if !JAVA
    }
#endif
#endif
