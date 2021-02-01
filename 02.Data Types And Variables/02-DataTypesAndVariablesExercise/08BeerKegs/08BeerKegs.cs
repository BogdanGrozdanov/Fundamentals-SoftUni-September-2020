using System;


namespace _08BeerKegs
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            double biggerKeg = 0;
            string output = string.Empty;

            for (int i = 0; i < n; i++)
            {
                string modelKeg = Console.ReadLine();
                double radius = double.Parse(Console.ReadLine());
                int height = int.Parse(Console.ReadLine());

                double volumeKeg = Math.PI * Math.Pow(radius, 2) * height;
                if (biggerKeg < volumeKeg)
                {
                    biggerKeg = volumeKeg;
                    output = modelKeg;
                }
            }
            Console.WriteLine(output);
        }
    }
}
