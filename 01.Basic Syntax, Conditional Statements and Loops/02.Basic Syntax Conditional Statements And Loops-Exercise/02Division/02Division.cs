using System;

namespace Division
{
    class Division
    {
        static void Main(string[] args)
        {
            int input = int.Parse(Console.ReadLine());
            int division = 0;

            if (input % 10 == 0)
            {
                division = 10;
            }
            else if (input % 7 == 0)
            {
                division = 7;
            }
            else if (input % 6 == 0)
            {
                division = 6;
            }
            else if (input % 3 == 0)
            {
                division = 3;
            }
            else if (input % 2 == 0)
            {
                division = 2;
            }
            else
            {
                division = 0;
            }

            if (division!=0)
            {
                Console.WriteLine($"The number is divisible by {division}");
            }
            else
            {
                Console.WriteLine($"Not divisible");
            }
            
        }
    }
}
