using System;

namespace _04RefactoringPrimeChecker
{
    class Program
    {
        static void Main(string[] args)
        {
            int numRnge = int.Parse(Console.ReadLine());

            for (int i = 2; i <= numRnge; i++)
            {
                bool isPrime = true;
                for (int j = 2; j < i; j++)
                {
                    if (i % j == 0)
                    {
                        isPrime = false;
                        break;
                    }
                }
                Console.WriteLine($"{i} -> {isPrime.ToString().ToLower()}");
            }

        }
    }
}
