﻿namespace Tenray.ZoneTree;

/// <summary>
/// Available compression methods.
/// </summary>
public enum CompressionMethod : byte
{
    /// <summary>
    /// No compression.
    /// </summary>
    None = 0,

    /// <summary>
    /// Gzip algorithm.
    /// </summary>
    Gzip = 1,
}