﻿using System;
using System.Linq;

// Too many problems have improperly formatted input... random whitespace,
// missing newlines... things that C# doesn't deal well with by default.
// It's good to verify the input format on an alt account so you don't get frustrated.
// Currently verifying for: http://www.spoj.com/problems/COMDIV/
// Can't even read parse all the input without a TLE, so...
public static class InputVerifier
{
    private static void Main()
    {
        int remainingTestCases = int.Parse(Console.ReadLine());

        if (remainingTestCases < 1 || remainingTestCases > 1000000)
            throw new FormatException();

        while (remainingTestCases-- > 0)
        {
            int[] ab = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);

            if (ab.Length != 2)
                throw new FormatException();

            if (ab.Any(n => n < 1 || n > 1000000))
                throw new FormatException();
        }
    }
}
