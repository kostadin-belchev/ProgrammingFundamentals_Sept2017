﻿using System;

namespace Exer_08_EmployeeData
{
    class Program
    {
        static void Main(string[] args)
        {
            string firstName = Console.ReadLine();
            string secondName = Console.ReadLine();
            byte age = byte.Parse(Console.ReadLine());
            char gender = char.Parse(Console.ReadLine());
            double PersonalIdNumber = double.Parse(Console.ReadLine());
            int UniqueEmployeeNumber = int.Parse(Console.ReadLine());

            Console.WriteLine("First name: {0}", firstName);
            Console.WriteLine("Last name: {0}", secondName);
            Console.WriteLine("Age: {0}", age);
            Console.WriteLine("Gender: {0}", gender);
            Console.WriteLine("Personal ID: {0}", PersonalIdNumber);
            Console.WriteLine("Unique Employee number: {0}", UniqueEmployeeNumber);
        }
    }
}
