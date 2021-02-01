using System;

namespace MultiplicationTable2._0
{
    class Program
    {
        static void Main(string[] args)
        {
            var num = int.Parse(Console.ReadLine());
            var num2 = int.Parse(Console.ReadLine());

            if (num2 >= 10)
            {
                Console.WriteLine($"{num} X {num2} = {num * num2}");
            }
            else
            {
                for (int i = num2; num2 <= 10; num2++)
                {
                    Console.WriteLine($"{num} X {num2} = {num * num2}");
                }
            }
            
        }
    }
}
