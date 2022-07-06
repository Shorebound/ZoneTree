﻿namespace Tenray.Collections;

public interface IRefComparer<TKey>
{
    int Compare(in TKey x, in TKey y);
}
