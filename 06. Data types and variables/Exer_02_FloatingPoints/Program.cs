﻿using System;

namespace Exer_02_FloatingPoints
{
    class Program
    {
        static void Main()
        {
            decimal first = decimal.Parse(Console.ReadLine());
            double second = double.Parse(Console.ReadLine());
            decimal third = decimal.Parse(Console.ReadLine());

            Console.WriteLine("{0}\n{1}\n{2}", first, second, third);
        }
    }