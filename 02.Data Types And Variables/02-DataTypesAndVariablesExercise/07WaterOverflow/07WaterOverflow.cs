using System;

namespace _07WaterOverflow
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int capacity = 255;
            int sum = 0;

            for (int i = 0; i < n; i++)
            {
                int addCapacity = int.Parse(Console.ReadLine());
                sum += addCapacity;

                if (sum > capacity)
                {
                    sum -= addCapacity;
                    Console.WriteLine("Insufficient capacity!");
                }
            }
            Console.WriteLine(sum);


        }
    }
}
