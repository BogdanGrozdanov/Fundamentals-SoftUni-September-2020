using System;

namespace _04ReverseString
{
    class Program
    {
        static void Main(string[] args)
        {
            string word = Console.ReadLine();
            string reverse = "";

            for (int i = word.Length - 1; i >= 0; i--)
            {
                reverse += word[i];
            }
            Console.Write(reverse);
        }
    }
}
