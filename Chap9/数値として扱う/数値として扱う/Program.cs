﻿using System;

internal enum MyColor
{
    Red, Blue, Yellow
};

class Program
{
    static void Main(string[] args)
    {
        var col = (MyColor)1;
        Console.WriteLine(col);
    }
}
