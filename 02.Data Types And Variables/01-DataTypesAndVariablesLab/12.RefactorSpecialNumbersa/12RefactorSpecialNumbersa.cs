using System;

namespace _12RefactorSpecialNumbersa
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int sumDigits = 0;
            int takova = 0;
            bool isSpecial = false;
            for (int num = 1; num <= n; num++)
            {
                takova = num;
                while (num > 0)
                {
                    sumDigits += num % 10;
                    num = num / 10;
                }
                isSpecial = (sumDigits == 5) || (sumDigits == 7) || (sumDigits == 11);
                sumDigits = 0;
                num = takova;
                Console.WriteLine("{0} -> {1}", num, isSpecial);

            }

        }
    }
}
