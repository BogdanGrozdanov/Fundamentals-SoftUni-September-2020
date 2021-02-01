using System;

namespace _01ConvertMetersТоKilometers
{
    class Program
    {
        static void Main(string[] args)
        {
            int input = int.Parse(Console.ReadLine());
            float output = input * 0.001f;
            Console.WriteLine($"{output:f2}");
        }
    }
}
