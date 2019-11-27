﻿#pragma warning disable SA1602, CS1591 // Enumeration items should be documented

namespace SpiderEye
{
    /// <summary>
    /// Describes keys.
    /// </summary>
    public enum Key
    {
        None = 0,
        F1 = KeyMask.Function | 1,
        F2 = KeyMask.Function | 2,
        F3 = KeyMask.Function | 3,
        F4 = KeyMask.Function | 4,
        F5 = KeyMask.Function | 5,
        F6 = KeyMask.Function | 6,
        F7 = KeyMask.Function | 7,
        F8 = KeyMask.Function | 8,
        F9 = KeyMask.Function | 9,
        F10 = KeyMask.Function | 10,
        F11 = KeyMask.Function | 11,
        F12 = KeyMask.Function | 12,
        Number1 = KeyMask.Number | 1,
        Number2 = KeyMask.Number | 2,
        Number3 = KeyMask.Number | 3,
        Number4 = KeyMask.Number | 4,
        Number5 = KeyMask.Number | 5,
        Number6 = KeyMask.Number | 6,
        Number7 = KeyMask.Number | 7,
        Number8 = KeyMask.Number | 8,
        Number9 = KeyMask.Number | 9,
        Number0 = KeyMask.Number | 10,
        A = KeyMask.Alphabet | 1,
        B = KeyMask.Alphabet | 2,
        C = KeyMask.Alphabet | 3,
        D = KeyMask.Alphabet | 4,
        E = KeyMask.Alphabet | 5,
        F = KeyMask.Alphabet | 6,
        G = KeyMask.Alphabet | 7,
        H = KeyMask.Alphabet | 8,
        I = KeyMask.Alphabet | 9,
        J = KeyMask.Alphabet | 10,
        K = KeyMask.Alphabet | 11,
        L = KeyMask.Alphabet | 12,
        M = KeyMask.Alphabet | 13,
        N = KeyMask.Alphabet | 14,
        O = KeyMask.Alphabet | 15,
        P = KeyMask.Alphabet | 16,
        Q = KeyMask.Alphabet | 17,
        R = KeyMask.Alphabet | 18,
        S = KeyMask.Alphabet | 19,
        T = KeyMask.Alphabet | 20,
        U = KeyMask.Alphabet | 21,
        V = KeyMask.Alphabet | 22,
        W = KeyMask.Alphabet | 23,
        X = KeyMask.Alphabet | 24,
        Y = KeyMask.Alphabet | 25,
        Z = KeyMask.Alphabet | 26,
        Insert = KeyMask.Additional | 1,
        Delete = KeyMask.Additional | 2,
    }
}
