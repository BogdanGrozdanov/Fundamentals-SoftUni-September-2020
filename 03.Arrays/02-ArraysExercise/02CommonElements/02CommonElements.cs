using System;
using System.Linq;

namespace _02CommonElements
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] firstArr = Console.ReadLine().Split(" ").ToArray();
            string[] secoundArr = Console.ReadLine().Split(" ").ToArray();

            foreach (string output in secoundArr)
            {
                for (int i = 0; i < firstArr.Length; i++)
                {
                    if (output==firstArr[i])
                    {
                        Console.Write(output + " ");
                        break;
                    }
                }
            }
        }
    }
}
