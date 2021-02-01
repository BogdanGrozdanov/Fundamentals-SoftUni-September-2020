using System;
using System.Security.Cryptography;

namespace _03GamingStore
{
    class Program
    {
        static void Main(string[] args)
        {
            double curentBalance = double.Parse(Console.ReadLine());

            double leftMoney = curentBalance;
            string output = "";
            double price = 0;
            bool flag = true;
            string typeOfGame = Console.ReadLine();


            while (typeOfGame != "Game Time")
            {
                if (typeOfGame == "OutFall 4" || typeOfGame == "RoverWatch Origins Edition" || typeOfGame == "CS: OG" || typeOfGame == "Zplinter Zell" || typeOfGame == "Honored 2" || typeOfGame == "RoverWatch")
                {
                    if (typeOfGame == "OutFall 4")
                    {
                        price = 39.99;
                        output=($"Bought {typeOfGame}");
                    }
                    else if (typeOfGame == "RoverWatch Origins Edition")
                    {
                        price = 39.99;
                        output=($"Bought {typeOfGame}");
                    }
                    else if (typeOfGame == "CS: OG")
                    {
                        price = 15.99;
                        output=($"Bought {typeOfGame}");
                    }
                    else if (typeOfGame == "Zplinter Zell")
                    {
                        price = 19.99;
                        output=($"Bought {typeOfGame}");
                    }
                    else if (typeOfGame == "Honored 2")
                    {
                        price = 59.99;
                        output=($"Bought {typeOfGame}");
                    }
                    else if (typeOfGame == "RoverWatch")
                    {
                        price = 29.99;
                        output=($"Bought {typeOfGame}");
                    }

                }
                else
                {
                    Console.WriteLine("Not Found");
                }

                if (curentBalance < price)
                {
                    Console.WriteLine("Too Expensive");
                }
                else
                {
                    Console.WriteLine(output);
                    curentBalance -= price;
                }
                

                if (curentBalance <= 0)
                {
                    Console.WriteLine("Out of money!");
                    flag = false;
                    break;
                }
                typeOfGame = Console.ReadLine();

            }
            if (flag == false)
            {

            }
            else
            {
                Console.WriteLine($"Total spent: ${leftMoney - curentBalance:F2}. Remaining: ${curentBalance:F2}");
            }
        }
    }
}
