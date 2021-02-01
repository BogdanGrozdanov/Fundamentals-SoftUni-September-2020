using System;

namespace _06BalancedBrackets
{
    class Program
    {
        static void Main(string[] args)
        {
            int numLines = int.Parse(Console.ReadLine());

            int openBrackets = 0;
            int closeBracket = 0;

            for (int i = 0; i < numLines; i++)
            {
                string input = Console.ReadLine();

                if (input == "(")
                {
                    openBrackets += 1;
                }
                else if (input == ")")
                {
                    closeBracket += 1;
                }
            }

            if (openBrackets == closeBracket)
            {
                Console.WriteLine("BALANCED");
            }
            else
            {
                Console.WriteLine("UNBALANCED");
            }
        }
    }
}
