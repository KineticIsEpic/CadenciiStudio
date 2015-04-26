/*
 * EditedStateChangedEventHandler.cs
 * Copyright © 2010-2011 kbinani
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
//INCLUDE ./EditedStateChangedEventHandler.java
#else
using System;

namespace cadencii
{

    public delegate void EditedStateChangedEventHandler( Object sender, bool edited );

}
#endif
