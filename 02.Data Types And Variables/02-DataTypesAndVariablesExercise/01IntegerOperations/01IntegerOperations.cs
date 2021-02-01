using System;

namespace _01IntegerOperations
{
    class Program
    {
        static void Main(string[] args)
        {
            int firstNumber = int.Parse(Console.ReadLine());
            int secondNumber = int.Parse(Console.ReadLine());
            int thirdNumber = int.Parse(Console.ReadLine());
            int fourttNumber = int.Parse(Console.ReadLine());

            Console.WriteLine(((firstNumber+secondNumber)/thirdNumber)*fourttNumber);
        }
    }
}
