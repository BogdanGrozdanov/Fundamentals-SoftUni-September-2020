using System;
using System.Text;

namespace _05PrintPartOfASCIITable
{
    class Program
    {
        static void Main(string[] args)
        {
            int start = int.Parse(Console.ReadLine());
            int end = int.Parse(Console.ReadLine());

            for (int i = start; i <= end; i++)
            {
                char output = (char)i;
                
                Console.Write($"{output} ");
            }
        }
    }
}
