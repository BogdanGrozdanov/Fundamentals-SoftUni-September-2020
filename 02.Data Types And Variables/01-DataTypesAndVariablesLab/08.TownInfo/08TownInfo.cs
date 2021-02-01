using System;

namespace _08TownInfo
{
    class Program
    {
        static void Main(string[] args)
        {
            string townName = Console.ReadLine();
            int population = int.Parse(Console.ReadLine());
            double square = double.Parse(Console.ReadLine());

            Console.WriteLine($"Town {townName} has population of {population} and area {square} square km.");
        }
    }
}
