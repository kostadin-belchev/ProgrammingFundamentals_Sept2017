﻿using System;

namespace Exer_05_Boolean
{
    class Program
    {
        static void Main()
        {
            string yes = Console.ReadLine();

            if (Convert.ToBoolean(yes))
            {
                Console.WriteLine("{0}", "Yes");
            }
            else
            {
                Console.WriteLine("{0}", "No");
            }
        }
    }