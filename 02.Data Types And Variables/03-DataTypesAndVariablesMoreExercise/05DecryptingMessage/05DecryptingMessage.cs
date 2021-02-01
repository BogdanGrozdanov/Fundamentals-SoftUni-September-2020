using System;

namespace _05DecryptingMessage
{
    class Program
    {
        static void Main(string[] args)
        {
            int key = int.Parse(Console.ReadLine());
            int numLines = int.Parse(Console.ReadLine());
            string decoding = string.Empty;

            for (int i = 0; i < numLines; i++)
            {
                char coding = char.Parse(Console.ReadLine());
                decoding +=(char)(coding + key); ;
                
            }
            Console.WriteLine(decoding);
        }
    }
}
