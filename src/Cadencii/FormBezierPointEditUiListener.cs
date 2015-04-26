/*
 * FormBezierPointEditUiListener.cs
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

using System;
using cadencii;

namespace cadencii
{

#endif

    public interface FormBezierPointEditUiListener
    {
        [PureVirtualFunction]
        void buttonOkClick();

        [PureVirtualFunction]
        void buttonCancelClick();

        [PureVirtualFunction]
        void buttonBackwardClick();

        [PureVirtualFunction]
        void buttonForwardClick();

        [PureVirtualFunction]
        void checkboxEnableSmoothCheckedChanged();

        [PureVirtualFunction]
        void buttonLeftMouseDown();

        [PureVirtualFunction]
        void buttonRightMouseDown();

        [PureVirtualFunction]
        void buttonCenterMouseDown();

        [PureVirtualFunction]
        void buttonsMouseUp();

        [PureVirtualFunction]
        void buttonsMouseMove();
    }

#if !JAVA
}
#endif
