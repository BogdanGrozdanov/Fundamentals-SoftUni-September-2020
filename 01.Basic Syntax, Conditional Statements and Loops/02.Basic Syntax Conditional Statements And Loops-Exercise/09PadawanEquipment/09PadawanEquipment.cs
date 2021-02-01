using System;
using System.Data.SqlTypes;

namespace _09PadawanEquipment
{
    class Program
    {
        static void Main(string[] args)
        {
            double budget = double.Parse(Console.ReadLine());
            int countStudent = int.Parse(Console.ReadLine());
            double lightSaberPrice = double.Parse(Console.ReadLine());
            double robePrice = double.Parse(Console.ReadLine());
            double beltPrice = double.Parse(Console.ReadLine());

            double moneyForSaber = lightSaberPrice * Math.Ceiling(countStudent * 1.10);
            double freeBelts = countStudent / 6;
            double moneyForBelts = beltPrice * (countStudent - freeBelts);
            double moneyForRobe = robePrice * countStudent;
            double totalMoney = moneyForSaber + moneyForBelts + moneyForRobe;

            if (budget >= totalMoney)
            {
                Console.WriteLine($"The money is enough - it would cost {totalMoney:f2}lv.");
            }
            else
            {
                Console.WriteLine($"Ivan Cho will need {totalMoney - budget:f2}lv more.");
            }
        }
    }
}
