using System;

namespace PrintAndSum
{
    class PrintAndSum
    {
        static void Main(string[] args)
        {
            int startNum = int.Parse(Console.ReadLine());
            int endNum = int.Parse(Console.ReadLine());

            double sum = 0;

            for (int i = startNum; i <= endNum; i++)
            {
                Console.Write($"{startNum} ");
                sum += startNum;
                startNum++;
            }
            Console.WriteLine();
            Console.WriteLine($"Sum: {sum}");
        }
    }
}
