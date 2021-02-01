using System;
using System.Collections.Generic;

namespace _08MagicSum
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] inputNumbers = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);

            int magicNum = int.Parse(Console.ReadLine());

            for (int i = 0; i < inputNumbers.Length; i++)
            {

                int num1 = int.Parse(inputNumbers[i]);

                for (int j = i + 1; j < inputNumbers.Length; j++)
                {
                    if (j == inputNumbers.Length)
                    {
                        break;
                    }

                    int num2 = int.Parse(inputNumbers[j]);

                    if (magicNum == (num1 + num2))
                    {
                        Console.WriteLine($"{num1} {num2}");
                    }
                }
            }



        }
    }
}
