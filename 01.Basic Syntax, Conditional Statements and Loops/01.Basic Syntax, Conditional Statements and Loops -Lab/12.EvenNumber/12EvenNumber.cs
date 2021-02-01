using System;
using System.Runtime.CompilerServices;

namespace EvenNumber
{
    class EvenNumber
    {
        static void Main(string[] args)
        {
            var num = int.Parse(Console.ReadLine());

            while (num % 2 != 0)
            {
                Console.WriteLine("Please write an even number.");
                num = int.Parse(Console.ReadLine());
            }
            Console.WriteLine($"The number is: {Math.Abs(num)}");
        }
    }
}
