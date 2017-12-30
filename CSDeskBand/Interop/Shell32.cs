﻿using System;
using System.Runtime.InteropServices;

namespace CSDeskBand.Interop
{
    internal class Shell32
    {
        [DllImport("shell32.dll")]
        public static extern IntPtr SHAppBarMessage(uint dwMessage, [In] ref APPBARDATA pData);
    }
}
