﻿using Tenray.Collections;

namespace Tenray;

public class StringOrdinalComparerAscending : IRefComparer<string>
{
    public int Compare(in string x, in string y)
    {
        return string.CompareOrdinal(x, y);
    }
}
