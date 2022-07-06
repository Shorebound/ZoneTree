﻿using Tenray.Collections;

namespace Tenray;

public class StringOrdinalComparerDescending : IRefComparer<string>
{
    public int Compare(in string x, in string y)
    {
        return string.CompareOrdinal(y, x);
    }
}