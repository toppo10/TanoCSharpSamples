﻿using System;
using System.Collections.Generic;

class X
{
    internal int A { get; set; }
    internal int B { get; set; }
}

internal static class MyExtensions
{
    internal static IEnumerator<int> GetEnumerator(this X x)
    {
        yield return x.A;
        yield return x.B;
    }
}

class Program
{
    static void Main()
    {
        var x = new X();
        x.A = 123;
        x.B = 456;
        foreach (var item in x) Console.WriteLine(item);
    }
}
