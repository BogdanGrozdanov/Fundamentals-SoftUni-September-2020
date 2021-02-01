using System;

namespace EnglishNameOfTheLastDigit
{
    class EnglishNameOfTheLastDigit
    {
        static void Main(string[] args)
        {
            string number = Console.ReadLine();
            string num =String.Empty;
            char a = '0';
            string output = "";
            for (int i = number.Length - 1; i >= 0; i--)
            {
                num += number[i];
                
            }
            a = num[0];

            switch (a)
            {
                case '1':
                    output = "one";
                    break;
                case '2':
                    output = "two";
                    break;
                case '3':
                    output = "three";
                    break;
                case '4':
                    output = "four";
                    break;
                case '5':
                    output = "five";
                    break;
                case '6':
                    output = "six";
                    break;
                case '7':
                    output = "seven";
                    break;
                case '8':
                    output = "eight";
                    break;
                case '9':
                    output = "nine";
                    break;
                case '0':
                    output = "zero";
                    break;
            }
            Console.WriteLine(output);
        }
    }
}
