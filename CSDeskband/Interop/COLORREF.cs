﻿using System.Runtime.InteropServices;

namespace CSDeskband.Interop
{
    [StructLayout(LayoutKind.Sequential)]
    public struct COLORREF
    {
        public byte R;
        public byte G;
        public byte B;
    }
}