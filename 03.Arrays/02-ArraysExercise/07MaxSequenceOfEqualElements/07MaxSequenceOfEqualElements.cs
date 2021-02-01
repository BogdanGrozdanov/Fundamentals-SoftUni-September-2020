using System;
using System.Linq;

namespace _07MaxSequenceOfEqualElements
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] array = Console.ReadLine()
                               .Split(" ")
                               .ToArray();
            int counter = 0;
            int bestIndex = 0;

            for (int i = 0; i < array.Length; i++)
            {
                string currentElement = array[i];
                int currentCounter = 1;

                for (int j = i + 1; j < array.Length; j++)
                {
                    if (currentElement == array[j])
                    {
                        currentCounter++;
                    }
                    else
                    {
                        break;
                    }
                }
                if (currentCounter > counter)
                {
                    counter = currentCounter;
                    bestIndex = i;
                }
            }
            for (int i = 0; i < counter; i++)
            {
                Console.Write(array[bestIndex] + " ");
            }
            

        }
    }
}
