using System;

namespace _04SumOfChars
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberOfchar = int.Parse(Console.ReadLine());
            int sum = 0;
            for (int j = 0; j < numberOfchar; j++)
            {
                char input = char.Parse(Console.ReadLine());
                sum += input;
                
            }
            Console.WriteLine($"The sum equals: {sum}");
        }
    }
}
