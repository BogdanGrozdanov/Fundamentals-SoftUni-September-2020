using System;

namespace Vacation1
{
    class Vacation1
    {
        static void Main(string[] args)
        {

            double travelPrice = double.Parse(Console.ReadLine());
            double ownedMoney = double.Parse(Console.ReadLine());
            int dayCount = 0;
            int spending = 0;
            bool isEnoughMoney = true;
            while (ownedMoney < travelPrice)
            {
                string saveSpend = Console.ReadLine();
                double money = double.Parse(Console.ReadLine());

                dayCount++;

                if (saveSpend == "spend")
                {
                    spending++;

                    if (spending == 5)
                    {
                        isEnoughMoney = false;
                        break;
                    }
                    ownedMoney -= money;
                    if (ownedMoney < 0)
                    {
                        ownedMoney = 0;
                    }
                }
                else if (saveSpend == "save")
                {
                    ownedMoney += money;
                    spending = 0;
                }
                
            }
            if (isEnoughMoney)
            {
                Console.WriteLine($"You saved the money for {dayCount} days.");
            }
            else
            {
                Console.WriteLine("You can't save the money.");
                Console.WriteLine($"{dayCount}");
            }
        }
    }
}
