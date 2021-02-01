using System;
using System.Linq;
using System.Xml;

namespace _01Train
{
    class Program
    {
        static void Main(string[] args)
        {
            int wagon = int.Parse(Console.ReadLine());
            int allPeople = 0;
            int[] people = new int[wagon];
            for (int i = 0; i < wagon; i++)
            {
                people[i] = int.Parse(Console.ReadLine());
                allPeople += people[i];
            }
            foreach (var peopleInWagon in people)
            {
                Console.Write(peopleInWagon + " ");
            }
            Console.WriteLine();
            Console.WriteLine(allPeople);
        }
    }
}
