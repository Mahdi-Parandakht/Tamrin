﻿using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("10 * 10");

        for (int i = 1; i <= 10; i++)
        {
            for (int j = 1; j <= 10; j++)
            {
                Console.Write($"{i * j,4}");
            }
            Console.WriteLine();
        }

        Console.ReadLine();
    }
}