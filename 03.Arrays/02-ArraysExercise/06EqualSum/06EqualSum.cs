using System;
using System.Linq;

namespace _06EqualSum
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = Console.ReadLine()
                             .Split(" ")
                             .Select(int.Parse)
                             .ToArray();
            bool isFound = false;

            for (int curr = 0; curr < arr.Length; curr++)
            {
                int rightSum = 0;

                for (int i = curr + 1; i < arr.Length; i++)
                {
                    rightSum += arr[i];
                }

                int LeftSum = 0;

                for (int i = curr - 1; i >= 0; i--)
                {
                    LeftSum += arr[i];
                }
                if (rightSum == LeftSum)
                {
                    Console.WriteLine(curr);
                    isFound = true;
                    break;
                }
            }
            if (!isFound)
            {
                Console.WriteLine("no");
            }
        }
    }
}
