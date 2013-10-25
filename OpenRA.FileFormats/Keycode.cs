﻿#region Copyright & License Information
/*
 * Copyright 2007-2013 The OpenRA Developers (see AUTHORS)
 * This file is part of OpenRA, which is free software. It is made
 * available to you under the terms of the GNU General Public License
 * as published by the Free Software Foundation. For more information,
 * see COPYING.
 */
#endregion

using System;
using System.Collections.Generic;
using System.Linq;

namespace OpenRA
{
	public enum Keycode
	{
		UNKNOWN = 0,
		FIRST = 0,
		BACKSPACE = 8,
		TAB = 9,
		CLEAR = 12,
		RETURN = 13,
		PAUSE = 19,
		ESCAPE = 27,
		SPACE = 32,
		EXCLAIM = 33,
		QUOTEDBL = 34,
		HASH = 35,
		DOLLAR = 36,
		AMPERSAND = 38,
		QUOTE = 39,
		LEFTPAREN = 40,
		RIGHTPAREN = 41,
		ASTERISK = 42,
		PLUS = 43,
		COMMA = 44,
		MINUS = 45,
		PERIOD = 46,
		SLASH = 47,
		NUMBER_0 = 48,
		NUMBER_1 = 49,
		NUMBER_2 = 50,
		NUMBER_3 = 51,
		NUMBER_4 = 52,
		NUMBER_5 = 53,
		NUMBER_6 = 54,
		NUMBER_7 = 55,
		NUMBER_8 = 56,
		NUMBER_9 = 57,
		COLON = 58,
		SEMICOLON = 59,
		LESS = 60,
		EQUALS = 61,
		GREATER = 62,
		QUESTION = 63,
		AT = 64,
		LEFTBRACKET = 91,
		BACKSLASH = 92,
		RIGHTBRACKET = 93,
		CARET = 94,
		UNDERSCORE = 95,
		BACKQUOTE = 96,
		A = 97,
		B = 98,
		C = 99,
		D = 100,
		E = 101,
		F = 102,
		G = 103,
		H = 104,
		I = 105,
		J = 106,
		K = 107,
		L = 108,
		M = 109,
		N = 110,
		O = 111,
		P = 112,
		Q = 113,
		R = 114,
		S = 115,
		T = 116,
		U = 117,
		V = 118,
		W = 119,
		X = 120,
		Y = 121,
		Z = 122,
		DELETE = 127,
		WORLD_0 = 160,
		WORLD_1 = 161,
		WORLD_2 = 162,
		WORLD_3 = 163,
		WORLD_4 = 164,
		WORLD_5 = 165,
		WORLD_6 = 166,
		WORLD_7 = 167,
		WORLD_8 = 168,
		WORLD_9 = 169,
		WORLD_10 = 170,
		WORLD_11 = 171,
		WORLD_12 = 172,
		WORLD_13 = 173,
		WORLD_14 = 174,
		WORLD_15 = 175,
		WORLD_16 = 176,
		WORLD_17 = 177,
		WORLD_18 = 178,
		WORLD_19 = 179,
		WORLD_20 = 180,
		WORLD_21 = 181,
		WORLD_22 = 182,
		WORLD_23 = 183,
		WORLD_24 = 184,
		WORLD_25 = 185,
		WORLD_26 = 186,
		WORLD_27 = 187,
		WORLD_28 = 188,
		WORLD_29 = 189,
		WORLD_30 = 190,
		WORLD_31 = 191,
		WORLD_32 = 192,
		WORLD_33 = 193,
		WORLD_34 = 194,
		WORLD_35 = 195,
		WORLD_36 = 196,
		WORLD_37 = 197,
		WORLD_38 = 198,
		WORLD_39 = 199,
		WORLD_40 = 200,
		WORLD_41 = 201,
		WORLD_42 = 202,
		WORLD_43 = 203,
		WORLD_44 = 204,
		WORLD_45 = 205,
		WORLD_46 = 206,
		WORLD_47 = 207,
		WORLD_48 = 208,
		WORLD_49 = 209,
		WORLD_50 = 210,
		WORLD_51 = 211,
		WORLD_52 = 212,
		WORLD_53 = 213,
		WORLD_54 = 214,
		WORLD_55 = 215,
		WORLD_56 = 216,
		WORLD_57 = 217,
		WORLD_58 = 218,
		WORLD_59 = 219,
		WORLD_60 = 220,
		WORLD_61 = 221,
		WORLD_62 = 222,
		WORLD_63 = 223,
		WORLD_64 = 224,
		WORLD_65 = 225,
		WORLD_66 = 226,
		WORLD_67 = 227,
		WORLD_68 = 228,
		WORLD_69 = 229,
		WORLD_70 = 230,
		WORLD_71 = 231,
		WORLD_72 = 232,
		WORLD_73 = 233,
		WORLD_74 = 234,
		WORLD_75 = 235,
		WORLD_76 = 236,
		WORLD_77 = 237,
		WORLD_78 = 238,
		WORLD_79 = 239,
		WORLD_80 = 240,
		WORLD_81 = 241,
		WORLD_82 = 242,
		WORLD_83 = 243,
		WORLD_84 = 244,
		WORLD_85 = 245,
		WORLD_86 = 246,
		WORLD_87 = 247,
		WORLD_88 = 248,
		WORLD_89 = 249,
		WORLD_90 = 250,
		WORLD_91 = 251,
		WORLD_92 = 252,
		WORLD_93 = 253,
		WORLD_94 = 254,
		WORLD_95 = 255,
		KP0 = 256,
		KP1 = 257,
		KP2 = 258,
		KP3 = 259,
		KP4 = 260,
		KP5 = 261,
		KP6 = 262,
		KP7 = 263,
		KP8 = 264,
		KP9 = 265,
		KP_PERIOD = 266,
		KP_DIVIDE = 267,
		KP_MULTIPLY = 268,
		KP_MINUS = 269,
		KP_PLUS = 270,
		KP_ENTER = 271,
		KP_EQUALS = 272,
		UP = 273,
		DOWN = 274,
		RIGHT = 275,
		LEFT = 276,
		INSERT = 277,
		HOME = 278,
		END = 279,
		PAGEUP = 280,
		PAGEDOWN = 281,
		F1 = 282,
		F2 = 283,
		F3 = 284,
		F4 = 285,
		F5 = 286,
		F6 = 287,
		F7 = 288,
		F8 = 289,
		F9 = 290,
		F10 = 291,
		F11 = 292,
		F12 = 293,
		F13 = 294,
		F14 = 295,
		F15 = 296,
		NUMLOCK = 300,
		CAPSLOCK = 301,
		SCROLLOCK = 302,
		RSHIFT = 303,
		LSHIFT = 304,
		RCTRL = 305,
		LCTRL = 306,
		RALT = 307,
		LALT = 308,
		RMETA = 309,
		LMETA = 310,
		LSUPER = 311,
		RSUPER = 312,
		MODE = 313,
		COMPOSE = 314,
		HELP = 315,
		PRINT = 316,
		SYSREQ = 317,
		BREAK = 318,
		MENU = 319,
		POWER = 320,
		EURO = 321,
		UNDO = 322,
		LAST
	}

	public static class KeycodeExts
	{
		static readonly Dictionary<Keycode, string> KeyNames = new Dictionary<Keycode, string>
		{
			{ Keycode.UNKNOWN, "unknown" },
			{ Keycode.BACKSPACE, "backspace" },
			{ Keycode.TAB, "tab" },
			{ Keycode.CLEAR, "clear" },
			{ Keycode.RETURN, "return" },
			{ Keycode.PAUSE, "pause" },
			{ Keycode.ESCAPE, "escape" },
			{ Keycode.SPACE, "space" },
			{ Keycode.EXCLAIM, "!" },
			{ Keycode.QUOTEDBL, "\"" },
			{ Keycode.HASH, "#" },
			{ Keycode.DOLLAR, "$" },
			{ Keycode.AMPERSAND, "&" },
			{ Keycode.QUOTE, "'" },
			{ Keycode.LEFTPAREN, "(" },
			{ Keycode.RIGHTPAREN, ")" },
			{ Keycode.ASTERISK, "*" },
			{ Keycode.PLUS, "+" },
			{ Keycode.COMMA, "," },
			{ Keycode.MINUS, "-" },
			{ Keycode.PERIOD, "." },
			{ Keycode.SLASH, "/" },
			{ Keycode.NUMBER_0, "0" },
			{ Keycode.NUMBER_1, "1" },
			{ Keycode.NUMBER_2, "2" },
			{ Keycode.NUMBER_3, "3" },
			{ Keycode.NUMBER_4, "4" },
			{ Keycode.NUMBER_5, "5" },
			{ Keycode.NUMBER_6, "6" },
			{ Keycode.NUMBER_7, "7" },
			{ Keycode.NUMBER_8, "8" },
			{ Keycode.NUMBER_9, "9" },
			{ Keycode.COLON, ":" },
			{ Keycode.SEMICOLON, " }," },
			{ Keycode.LESS, "<" },
			{ Keycode.EQUALS, "=" },
			{ Keycode.GREATER, ">" },
			{ Keycode.QUESTION, "?" },
			{ Keycode.AT, "@" },
			{ Keycode.LEFTBRACKET, "[" },
			{ Keycode.BACKSLASH, "\\" },
			{ Keycode.RIGHTBRACKET, "]" },
			{ Keycode.CARET, "^" },
			{ Keycode.UNDERSCORE, "_" },
			{ Keycode.BACKQUOTE, "`" },
			{ Keycode.A, "a" },
			{ Keycode.B, "b" },
			{ Keycode.C, "c" },
			{ Keycode.D, "d" },
			{ Keycode.E, "e" },
			{ Keycode.F, "f" },
			{ Keycode.G, "g" },
			{ Keycode.H, "h" },
			{ Keycode.I, "i" },
			{ Keycode.J, "j" },
			{ Keycode.K, "k" },
			{ Keycode.L, "l" },
			{ Keycode.M, "m" },
			{ Keycode.N, "n" },
			{ Keycode.O, "o" },
			{ Keycode.P, "p" },
			{ Keycode.Q, "q" },
			{ Keycode.R, "r" },
			{ Keycode.S, "s" },
			{ Keycode.T, "t" },
			{ Keycode.U, "u" },
			{ Keycode.V, "v" },
			{ Keycode.W, "w" },
			{ Keycode.X, "x" },
			{ Keycode.Y, "y" },
			{ Keycode.Z, "z" },
			{ Keycode.DELETE, "delete" },
			{ Keycode.WORLD_0, "world 0" },
			{ Keycode.WORLD_1, "world 1" },
			{ Keycode.WORLD_2, "world 2" },
			{ Keycode.WORLD_3, "world 3" },
			{ Keycode.WORLD_4, "world 4" },
			{ Keycode.WORLD_5, "world 5" },
			{ Keycode.WORLD_6, "world 6" },
			{ Keycode.WORLD_7, "world 7" },
			{ Keycode.WORLD_8, "world 8" },
			{ Keycode.WORLD_9, "world 9" },
			{ Keycode.WORLD_10, "world 10" },
			{ Keycode.WORLD_11, "world 11" },
			{ Keycode.WORLD_12, "world 12" },
			{ Keycode.WORLD_13, "world 13" },
			{ Keycode.WORLD_14, "world 14" },
			{ Keycode.WORLD_15, "world 15" },
			{ Keycode.WORLD_16, "world 16" },
			{ Keycode.WORLD_17, "world 17" },
			{ Keycode.WORLD_18, "world 18" },
			{ Keycode.WORLD_19, "world 19" },
			{ Keycode.WORLD_20, "world 20" },
			{ Keycode.WORLD_21, "world 21" },
			{ Keycode.WORLD_22, "world 22" },
			{ Keycode.WORLD_23, "world 23" },
			{ Keycode.WORLD_24, "world 24" },
			{ Keycode.WORLD_25, "world 25" },
			{ Keycode.WORLD_26, "world 26" },
			{ Keycode.WORLD_27, "world 27" },
			{ Keycode.WORLD_28, "world 28" },
			{ Keycode.WORLD_29, "world 29" },
			{ Keycode.WORLD_30, "world 30" },
			{ Keycode.WORLD_31, "world 31" },
			{ Keycode.WORLD_32, "world 32" },
			{ Keycode.WORLD_33, "world 33" },
			{ Keycode.WORLD_34, "world 34" },
			{ Keycode.WORLD_35, "world 35" },
			{ Keycode.WORLD_36, "world 36" },
			{ Keycode.WORLD_37, "world 37" },
			{ Keycode.WORLD_38, "world 38" },
			{ Keycode.WORLD_39, "world 39" },
			{ Keycode.WORLD_40, "world 40" },
			{ Keycode.WORLD_41, "world 41" },
			{ Keycode.WORLD_42, "world 42" },
			{ Keycode.WORLD_43, "world 43" },
			{ Keycode.WORLD_44, "world 44" },
			{ Keycode.WORLD_45, "world 45" },
			{ Keycode.WORLD_46, "world 46" },
			{ Keycode.WORLD_47, "world 47" },
			{ Keycode.WORLD_48, "world 48" },
			{ Keycode.WORLD_49, "world 49" },
			{ Keycode.WORLD_50, "world 50" },
			{ Keycode.WORLD_51, "world 51" },
			{ Keycode.WORLD_52, "world 52" },
			{ Keycode.WORLD_53, "world 53" },
			{ Keycode.WORLD_54, "world 54" },
			{ Keycode.WORLD_55, "world 55" },
			{ Keycode.WORLD_56, "world 56" },
			{ Keycode.WORLD_57, "world 57" },
			{ Keycode.WORLD_58, "world 58" },
			{ Keycode.WORLD_59, "world 59" },
			{ Keycode.WORLD_60, "world 60" },
			{ Keycode.WORLD_61, "world 61" },
			{ Keycode.WORLD_62, "world 62" },
			{ Keycode.WORLD_63, "world 63" },
			{ Keycode.WORLD_64, "world 64" },
			{ Keycode.WORLD_65, "world 65" },
			{ Keycode.WORLD_66, "world 66" },
			{ Keycode.WORLD_67, "world 67" },
			{ Keycode.WORLD_68, "world 68" },
			{ Keycode.WORLD_69, "world 69" },
			{ Keycode.WORLD_70, "world 70" },
			{ Keycode.WORLD_71, "world 71" },
			{ Keycode.WORLD_72, "world 72" },
			{ Keycode.WORLD_73, "world 73" },
			{ Keycode.WORLD_74, "world 74" },
			{ Keycode.WORLD_75, "world 75" },
			{ Keycode.WORLD_76, "world 76" },
			{ Keycode.WORLD_77, "world 77" },
			{ Keycode.WORLD_78, "world 78" },
			{ Keycode.WORLD_79, "world 79" },
			{ Keycode.WORLD_80, "world 80" },
			{ Keycode.WORLD_81, "world 81" },
			{ Keycode.WORLD_82, "world 82" },
			{ Keycode.WORLD_83, "world 83" },
			{ Keycode.WORLD_84, "world 84" },
			{ Keycode.WORLD_85, "world 85" },
			{ Keycode.WORLD_86, "world 86" },
			{ Keycode.WORLD_87, "world 87" },
			{ Keycode.WORLD_88, "world 88" },
			{ Keycode.WORLD_89, "world 89" },
			{ Keycode.WORLD_90, "world 90" },
			{ Keycode.WORLD_91, "world 91" },
			{ Keycode.WORLD_92, "world 92" },
			{ Keycode.WORLD_93, "world 93" },
			{ Keycode.WORLD_94, "world 94" },
			{ Keycode.WORLD_95, "world 95" },
			{ Keycode.KP0, "[0]" },
			{ Keycode.KP1, "[1]" },
			{ Keycode.KP2, "[2]" },
			{ Keycode.KP3, "[3]" },
			{ Keycode.KP4, "[4]" },
			{ Keycode.KP5, "[5]" },
			{ Keycode.KP6, "[6]" },
			{ Keycode.KP7, "[7]" },
			{ Keycode.KP8, "[8]" },
			{ Keycode.KP9, "[9]" },
			{ Keycode.KP_PERIOD, "[.]" },
			{ Keycode.KP_DIVIDE, "[/]" },
			{ Keycode.KP_MULTIPLY, "[*]" },
			{ Keycode.KP_MINUS, "[-]" },
			{ Keycode.KP_PLUS, "[+]" },
			{ Keycode.KP_ENTER, "enter" },
			{ Keycode.KP_EQUALS, "equals" },
			{ Keycode.UP, "up" },
			{ Keycode.DOWN, "down" },
			{ Keycode.RIGHT, "right" },
			{ Keycode.LEFT, "left" },
			{ Keycode.INSERT, "insert" },
			{ Keycode.HOME, "home" },
			{ Keycode.END, "end" },
			{ Keycode.PAGEUP, "page up" },
			{ Keycode.PAGEDOWN, "page down" },
			{ Keycode.F1, "f1" },
			{ Keycode.F2, "f2" },
			{ Keycode.F3, "f3" },
			{ Keycode.F4, "f4" },
			{ Keycode.F5, "f5" },
			{ Keycode.F6, "f6" },
			{ Keycode.F7, "f7" },
			{ Keycode.F8, "f8" },
			{ Keycode.F9, "f9" },
			{ Keycode.F10, "f10" },
			{ Keycode.F11, "f11" },
			{ Keycode.F12, "f12" },
			{ Keycode.F13, "f13" },
			{ Keycode.F14, "f14" },
			{ Keycode.F15, "f15" },
			{ Keycode.NUMLOCK, "numlock" },
			{ Keycode.CAPSLOCK, "caps lock" },
			{ Keycode.SCROLLOCK, "scroll lock" },
			{ Keycode.RSHIFT, "right shift" },
			{ Keycode.LSHIFT, "left shift" },
			{ Keycode.RCTRL, "right ctrl" },
			{ Keycode.LCTRL, "left ctrl" },
			{ Keycode.RALT, "right alt" },
			{ Keycode.LALT, "left alt" },
			{ Keycode.RMETA, "right meta" },
			{ Keycode.LMETA, "left meta" },
			{ Keycode.LSUPER, "left super" },
			{ Keycode.RSUPER, "right super" },
			{ Keycode.MODE, "alt gr" },
			{ Keycode.COMPOSE, "compose" },
			{ Keycode.HELP, "help" },
			{ Keycode.PRINT, "print screen" },
			{ Keycode.SYSREQ, "sys req" },
			{ Keycode.BREAK, "break" },
			{ Keycode.MENU, "menu" },
			{ Keycode.POWER, "power" },
			{ Keycode.EURO, "euro" },
			{ Keycode.UNDO, "undo" }
		};

		public static string DisplayString(Keycode k)
		{
			var ret = "unknown";
			KeyNames.TryGetValue(k, out ret);
			return ret;
		}
	}
}