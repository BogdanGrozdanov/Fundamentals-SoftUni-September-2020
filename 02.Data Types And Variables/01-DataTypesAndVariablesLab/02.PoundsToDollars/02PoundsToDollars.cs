using System;

namespace _02PoundsToDollars
{
    class Program
    {
        static void Main(string[] args)
        {
            decimal input = decimal.Parse(Console.ReadLine());
            decimal output = input * 1.31m;
            Console.WriteLine($"{output:f3}");
        }
    }
}
