using System;

namespace BackIn30Minutes
{
    class BackIn30Minutes
    {
        static void Main(string[] args)
        {
            int hour = int.Parse(Console.ReadLine());
            int minute = int.Parse(Console.ReadLine());

            minute += 30;

            if (minute > 59)
            {
                minute -= 60;
                hour += 1;
            }
            if (hour > 23)
            {
                hour -= 24;
            }
            Console.WriteLine($"{hour}:{minute:d2}");
        }
    }
}
