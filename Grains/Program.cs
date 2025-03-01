﻿using System;

public static class Grains
{
    public static ulong Square(int n)
    {
        if (n < 1 || n > 64)
            throw new ArgumentOutOfRangeException(nameof(n), "Square number must be between 1 and 64.");

        return 1UL << (n - 1); // Uses bit-shifting to calculate 2^(n-1)
    }

    public static ulong Total()
    {
        ulong totalGrains = 0;
        for (int i = 1; i <= 64; i++)
        {
            totalGrains += Square(i);
        }
        return totalGrains;
    }
}