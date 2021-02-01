using System;

namespace _10LowerOrUpper
{
    class Program
    {
        static void Main(string[] args)
        {
            char input = char.Parse(Console.ReadLine());
            int lower = (int)input;

            if (lower>=65&&lower<=90)
            {
                Console.WriteLine("upper-case");
            }
            else if (lower>=97&&lower<=122)
            {
                Console.WriteLine("lower-case");
            }

            

            
        }
    }
}
