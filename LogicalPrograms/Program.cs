using LogicalPrograms;
using System;

namespace DemoExample2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("LogicalPrograms" + "\n\n");
            Console.WriteLine("Enter the option");
            Console.WriteLine("1.FibonacciSeries" + "\n");
            int options = Convert.ToInt32(Console.ReadLine());
            switch (options)
            {
                case 1:
                    FibonacciSeries series = new FibonacciSeries();
                    Console.WriteLine("\n\n" + "Enter the FibonacciSeries Value" + "\n");
                    int range = Convert.ToInt32(Console.ReadLine());
                    series.Print(range);
                    break;
            }
        }
    }
}