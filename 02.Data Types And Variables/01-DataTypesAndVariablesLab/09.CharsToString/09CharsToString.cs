using System;

namespace _09CharsToString
{
    class Program
    {
        static void Main(string[] args)
        {
            char firstChar = char.Parse(Console.ReadLine());
            char secondChar = char.Parse(Console.ReadLine());
            char thirtChar = char.Parse(Console.ReadLine());
            Console.WriteLine($"{firstChar}{secondChar}{thirtChar}");
        }
    }
}
