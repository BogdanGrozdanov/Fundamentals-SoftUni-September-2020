using System;
using System.Diagnostics.CodeAnalysis;

namespace StrongNumber
{
    class StrongNumber
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());

            //145 % 10 = 5
            //145 - 5 = 140 / 10 = 4
            //14 % 10 = 4
            //14 - 4 = 10 / 10 = 1
            //1 % 10 = 1

            int tempNum = num;
            string strNum = "";
            strNum += num;
            int sum = 0;

            for (int i = 0; i < strNum.Length; i++)
            {
                int currentDigit = tempNum % 10;
                tempNum = (tempNum - currentDigit) / 10;

                //5!=1*2*3*4*5

                int factorial = 1;

                for (int j = 1; j <= currentDigit; j++)
                {
                    factorial *= j;
                }
                sum += factorial;
            }
            if (num == sum)
            {
                Console.WriteLine("yes");
            }
            else
            {
                Console.WriteLine("no");
            }
        }
    }
}
