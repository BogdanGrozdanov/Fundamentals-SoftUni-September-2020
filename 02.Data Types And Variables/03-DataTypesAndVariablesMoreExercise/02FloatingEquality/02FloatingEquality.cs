using System;

namespace _02FloatingEquality
{
    class Program
    {
        static void Main(string[] args)
        {
            double a = double.Parse(Console.ReadLine());
            double b = double.Parse(Console.ReadLine());

            double eps = 0.000001;
            bool isEqual = false;

            if ( a - b <= eps && a + eps !=b &&b+ eps !=a)
            {
                isEqual = true;
            }
            else
            {
                isEqual = false;
            }
            Console.WriteLine(isEqual);
        }
    }
}
