﻿using System.Runtime.InteropServices;

namespace ZoneTree.Segments.Disk;

[StructLayout(LayoutKind.Sequential)]
public struct EntryHead
{
    public int KeyLength;
    public long KeyOffset;
    public int ValueLength;
    public long ValueOffset;
}
