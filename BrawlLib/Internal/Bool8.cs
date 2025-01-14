﻿using System.Runtime.InteropServices;

namespace BrawlLib.Internal
{
    [StructLayout(LayoutKind.Sequential)]
    public struct bool8
    {
        public Bin8 _data;

        public static implicit operator bool(bool8 val)
        {
            return val._data[0];
        }

        public static implicit operator bool8(bool val)
        {
            return new bool8 { _data = (byte) (val ? 1 : 0) };
        }

        public static explicit operator bool8(byte val)
        {
            return new bool8 { _data = val };
        }

        public static explicit operator bool8(Bin8 val)
        {
            return new bool8 { _data = val };
        }

        public bool Value => this;
    }
}
