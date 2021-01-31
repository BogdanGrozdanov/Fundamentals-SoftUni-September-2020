using System;

namespace Ages
{
    class Ages
    {
        static void Main(string[] args)
        {
            var input = int.Parse(Console.ReadLine());
            string output = "";

            if (input <= 2)
            {
                output = "baby";
            }
            else if (input <= 13)
            {
                output = "child";
            }
            else if (input <= 19)
            {
                output = "teenager";
            }
            else if (input <= 65)
            {
                output = "adult";
            }
            else if (input >= 66)
            {
                output = "elder";
            }
            Console.WriteLine(output);
        }
    }
}
