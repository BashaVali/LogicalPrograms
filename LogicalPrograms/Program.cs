﻿using LogicalProblems;
using LogicalPrograms;
using System;

namespace LogicalProblems
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("LogicalProblems" + "\n\n");
            Console.WriteLine("Select the option");
            Console.WriteLine("1.FibonacciSeries" + "\n" +
                                "2.PerfectNumber" + "\n" +
                                "3.PrimeNumber" + "\n" +
                                "4.ReverseNumber");
            int options = Convert.ToInt32(Console.ReadLine());
            switch (options)
            {
                case 1:
                    FibonacciSeries series = new FibonacciSeries();
                    Console.WriteLine("\n\n" + "Enter the FibonacciSeries Value" + "\n");
                    int range = Convert.ToInt32(Console.ReadLine());
                    series.Print(range);
                    break;
                case 2:
                    PerfectNumber perfectNumber = new PerfectNumber();
                    Console.WriteLine("\n\n" + "Check the Number Perfect or Not" + "\n");
                    Console.WriteLine("Enter the Value" + "\n\n");
                    int value = Convert.ToInt32(Console.ReadLine());
                    perfectNumber.Check(value);
                    break;
                case 3:
                    PrimeNumber primeNumber = new PrimeNumber();
                    Console.WriteLine("Enter the Value to check Prime" + "\n\n");
                    int value1 = Convert.ToInt32(Console.ReadLine());
                    primeNumber.CheckPrime(value1);
                    break;
                case 4:
                    ReverseNumber reverseNumber = new ReverseNumber();
                    Console.WriteLine("Enter the Value to Reverse" + "\n\n");
                    int value2 = Convert.ToInt32(Console.ReadLine());
                    reverseNumber.Reverse(value2);
                    break;

            }
        }
    }
}