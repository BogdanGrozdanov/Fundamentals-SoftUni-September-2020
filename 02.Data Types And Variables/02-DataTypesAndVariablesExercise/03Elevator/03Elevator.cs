using System;

namespace _03Elevator
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberOfPeople = int.Parse(Console.ReadLine());
            int capacityPeople = int.Parse(Console.ReadLine());

            double course = Math.Ceiling( numberOfPeople / (double)capacityPeople);
            Console.WriteLine(course);
        }

    }
}
