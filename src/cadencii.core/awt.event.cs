#if !JAVA
/*
 * awt.event.cs
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
namespace cadencii.java.awt.event_
{

    public class InputEvent
    {
        public const int ALT_DOWN_MASK = 512;
        public const int ALT_GRAPH_DOWN_MASK = 8192;
        public const int ALT_GRAPH_MASK = 32;
        public const int ALT_MASK = 8;
        public const int BUTTON1_DOWN_MASK = 1024;
        public const int BUTTON1_MASK = 16;
        public const int BUTTON2_DOWN_MASK = 2048;
        public const int BUTTON2_MASK = 8;
        public const int BUTTON3_DOWN_MASK = 4096;
        public const int BUTTON3_MASK = 4;
        public const int CTRL_DOWN_MASK = 128;
        public const int CTRL_MASK = 2;
        public const int META_DOWN_MASK = 256;
        public const int META_MASK = 4;
        public const int SHIFT_DOWN_MASK = 64;
        public const int SHIFT_MASK = 1;
    }

    public class KeyEvent
    {
        //public const char CHAR_UNDEFINED = 65535;
        public const int KEY_FIRST = 400;
        public const int KEY_LAST = 402;
        public const int KEY_LOCATION_LEFT = 2;
        public const int KEY_LOCATION_NUMPAD = 4;
        public const int KEY_LOCATION_RIGHT = 3;
        public const int KEY_LOCATION_STANDARD = 1;
        public const int KEY_LOCATION_UNKNOWN = 0;
        public const int KEY_PRESSED = 401;
        public const int KEY_RELEASED = 402;
        public const int KEY_TYPED = 400;
        public const int VK_0 = 48;
        public const int VK_1 = 49;
        public const int VK_2 = 50;
        public const int VK_3 = 51;
        public const int VK_4 = 52;
        public const int VK_5 = 53;
        public const int VK_6 = 54;
        public const int VK_7 = 55;
        public const int VK_8 = 56;
        public const int VK_9 = 57;
        public const int VK_A = 65;
        public const int VK_ACCEPT = 30;
        public const int VK_ADD = 107;
        public const int VK_AGAIN = 65481;
        public const int VK_ALL_CANDIDATES = 256;
        public const int VK_ALPHANUMERIC = 240;
        public const int VK_ALT = 18;
        public const int VK_ALT_GRAPH = 65406;
        public const int VK_AMPERSAND = 150;
        public const int VK_ASTERISK = 151;
        public const int VK_AT = 512;
        public const int VK_B = 66;
        public const int VK_BACK_QUOTE = 192;
        public const int VK_BACK_SLASH = 92;
        public const int VK_BACK_SPACE = 8;
        public const int VK_BEGIN = 65368;
        public const int VK_BRACELEFT = 161;
        public const int VK_BRACERIGHT = 162;
        public const int VK_C = 67;
        public const int VK_CANCEL = 3;
        public const int VK_CAPS_LOCK = 20;
        public const int VK_CIRCUMFLEX = 514;
        public const int VK_CLEAR = 12;
        public const int VK_CLOSE_BRACKET = 93;
        public const int VK_CODE_INPUT = 258;
        public const int VK_COLON = 513;
        public const int VK_COMMA = 44;
        public const int VK_COMPOSE = 65312;
        public const int VK_CONTEXT_MENU = 525;
        public const int VK_CONTROL = 17;
        public const int VK_CONVERT = 28;
        public const int VK_COPY = 65485;
        public const int VK_CUT = 65489;
        public const int VK_D = 68;
        public const int VK_DEAD_ABOVEDOT = 134;
        public const int VK_DEAD_ABOVERING = 136;
        public const int VK_DEAD_ACUTE = 129;
        public const int VK_DEAD_BREVE = 133;
        public const int VK_DEAD_CARON = 138;
        public const int VK_DEAD_CEDILLA = 139;
        public const int VK_DEAD_CIRCUMFLEX = 130;
        public const int VK_DEAD_DIAERESIS = 135;
        public const int VK_DEAD_DOUBLEACUTE = 137;
        public const int VK_DEAD_GRAVE = 128;
        public const int VK_DEAD_IOTA = 141;
        public const int VK_DEAD_MACRON = 132;
        public const int VK_DEAD_OGONEK = 140;
        public const int VK_DEAD_SEMIVOICED_SOUND = 143;
        public const int VK_DEAD_TILDE = 131;
        public const int VK_DEAD_VOICED_SOUND = 142;
        public const int VK_DECIMAL = 110;
        public const int VK_DELETE = 127;
        public const int VK_DIVIDE = 111;
        public const int VK_DOLLAR = 515;
        public const int VK_DOWN = 40;
        public const int VK_E = 69;
        public const int VK_END = 35;
        public const int VK_ENTER = 10;
        public const int VK_EQUALS = 61;
        public const int VK_ESCAPE = 27;
        public const int VK_EURO_SIGN = 516;
        public const int VK_EXCLAMATION_MARK = 517;
        public const int VK_F = 70;
        public const int VK_F1 = 112;
        public const int VK_F10 = 121;
        public const int VK_F11 = 122;
        public const int VK_F12 = 123;
        public const int VK_F13 = 61440;
        public const int VK_F14 = 61441;
        public const int VK_F15 = 61442;
        public const int VK_F16 = 61443;
        public const int VK_F17 = 61444;
        public const int VK_F18 = 61445;
        public const int VK_F19 = 61446;
        public const int VK_F2 = 113;
        public const int VK_F20 = 61447;
        public const int VK_F21 = 61448;
        public const int VK_F22 = 61449;
        public const int VK_F23 = 61450;
        public const int VK_F24 = 61451;
        public const int VK_F3 = 114;
        public const int VK_F4 = 115;
        public const int VK_F5 = 116;
        public const int VK_F6 = 117;
        public const int VK_F7 = 118;
        public const int VK_F8 = 119;
        public const int VK_F9 = 120;
        public const int VK_FINAL = 24;
        public const int VK_FIND = 65488;
        public const int VK_FULL_WIDTH = 243;
        public const int VK_G = 71;
        public const int VK_GREATER = 160;
        public const int VK_H = 72;
        public const int VK_HALF_WIDTH = 244;
        public const int VK_HELP = 156;
        public const int VK_HIRAGANA = 242;
        public const int VK_HOME = 36;
        public const int VK_I = 73;
        public const int VK_INPUT_METHOD_ON_OFF = 263;
        public const int VK_INSERT = 155;
        public const int VK_INVERTED_EXCLAMATION_MARK = 518;
        public const int VK_J = 74;
        public const int VK_JAPANESE_HIRAGANA = 260;
        public const int VK_JAPANESE_KATAKANA = 259;
        public const int VK_JAPANESE_ROMAN = 261;
        public const int VK_K = 75;
        public const int VK_KANA = 21;
        public const int VK_KANA_LOCK = 262;
        public const int VK_KANJI = 25;
        public const int VK_KATAKANA = 241;
        public const int VK_KP_DOWN = 225;
        public const int VK_KP_LEFT = 226;
        public const int VK_KP_RIGHT = 227;
        public const int VK_KP_UP = 224;
        public const int VK_L = 76;
        public const int VK_LEFT = 37;
        public const int VK_LEFT_PARENTHESIS = 519;
        public const int VK_LESS = 153;
        public const int VK_M = 77;
        public const int VK_META = 157;
        public const int VK_MINUS = 45;
        public const int VK_MODECHANGE = 31;
        public const int VK_MULTIPLY = 106;
        public const int VK_N = 78;
        public const int VK_NONCONVERT = 29;
        public const int VK_NUM_LOCK = 144;
        public const int VK_NUMBER_SIGN = 520;
        public const int VK_NUMPAD0 = 96;
        public const int VK_NUMPAD1 = 97;
        public const int VK_NUMPAD2 = 98;
        public const int VK_NUMPAD3 = 99;
        public const int VK_NUMPAD4 = 100;
        public const int VK_NUMPAD5 = 101;
        public const int VK_NUMPAD6 = 102;
        public const int VK_NUMPAD7 = 103;
        public const int VK_NUMPAD8 = 104;
        public const int VK_NUMPAD9 = 105;
        public const int VK_O = 79;
        public const int VK_OPEN_BRACKET = 91;
        public const int VK_P = 80;
        public const int VK_PAGE_DOWN = 34;
        public const int VK_PAGE_UP = 33;
        public const int VK_PASTE = 65487;
        public const int VK_PAUSE = 19;
        public const int VK_PERIOD = 46;
        public const int VK_PLUS = 521;
        public const int VK_PREVIOUS_CANDIDATE = 257;
        public const int VK_PRINTSCREEN = 154;
        public const int VK_PROPS = 65482;
        public const int VK_Q = 81;
        public const int VK_QUOTE = 222;
        public const int VK_QUOTEDBL = 152;
        public const int VK_R = 82;
        public const int VK_RIGHT = 39;
        public const int VK_RIGHT_PARENTHESIS = 522;
        public const int VK_ROMAN_CHARACTERS = 245;
        public const int VK_S = 83;
        public const int VK_SCROLL_LOCK = 145;
        public const int VK_SEMICOLON = 59;
        public const int VK_SEPARATER = 108;
        public const int VK_SEPARATOR = 108;
        public const int VK_SHIFT = 16;
        public const int VK_SLASH = 47;
        public const int VK_SPACE = 32;
        public const int VK_STOP = 65480;
        public const int VK_SUBTRACT = 109;
        public const int VK_T = 84;
        public const int VK_TAB = 9;
        public const int VK_U = 85;
        public const int VK_UNDEFINED = 0;
        public const int VK_UNDERSCORE = 523;
        public const int VK_UNDO = 65483;
        public const int VK_UP = 38;
        public const int VK_V = 86;
        public const int VK_W = 87;
        public const int VK_WINDOWS = 524;
        public const int VK_X = 88;
        public const int VK_Y = 89;
        public const int VK_Z = 90;
    }
}
#endif
