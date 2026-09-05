// Build: 7f8e32a9f3ff4081fc22c635332b8cd0
using System;

internal static class Utilities
{
    public static int Clamp(int value, int minimum, int maximum)
        => Math.Min(maximum, Math.Max(minimum, value));
}
