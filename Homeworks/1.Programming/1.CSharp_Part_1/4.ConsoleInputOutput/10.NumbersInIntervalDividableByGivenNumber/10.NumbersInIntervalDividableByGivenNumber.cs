﻿using System;
class Program
{
    static void Main()
    {
        Console.Write("Enter start number: ");
        int startNumber = int.Parse(Console.ReadLine());
        Console.Write("Enter end number: ");
        int endNumber = int.Parse(Console.ReadLine());
        int count = 0;
        for (int i = startNumber; i < endNumber; i++)
        {
            if (i % 5 == 0)
            {
                count++;
            }
        }
        Console.WriteLine(count);
    }
}