using System;
using System.Linq;

namespace _05TopIntegers
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = Console.ReadLine()
                       .Split(" ")
                       .Select(int.Parse)
                       .ToArray();
            bool isBiger = true;
            for (int i = 0; i < arr.Length; i++)
            {
                int currentInt = arr[i];

                for (int j = i+1; j < arr.Length; j++)
                {
                    if (arr[j]>=currentInt)
                    {
                        isBiger = false;
                        break;
                    }
                }
                if (isBiger)
                {
                    Console.Write(currentInt+ " ");
                }
                isBiger = true;
            }
        }
    }
}
