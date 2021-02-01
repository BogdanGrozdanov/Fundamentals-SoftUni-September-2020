using System;
using System.Linq;

namespace _03Zig_ZagArrays
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int[] inputArr = new int[2];
            string[] arr1 = new string[n];
            string[] arr2 = new string[n];

            for (int i = 0; i < n; i++)
            {
                string[] currentArray = Console.ReadLine().Split(" ").ToArray();
                
                if (i % 2 == 0)
                {
                    arr1[i] = currentArray[0];
                    arr2[i] = currentArray[1];
                }
                else if (i % 2 == 1)
                {
                    arr1[i] = currentArray[1];
                    arr2[i] = currentArray[0];
                }

            }
            Console.WriteLine(string.Join(" ", arr1));
            Console.WriteLine(string.Join(" ", arr2));
        }
    }
}
