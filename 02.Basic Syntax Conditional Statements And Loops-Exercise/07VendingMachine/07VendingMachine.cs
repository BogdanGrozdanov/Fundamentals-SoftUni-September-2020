using System;

namespace _07VendingMachine
{
    class Program
    {
        static void Main(string[] args)
        {
            double input = double.Parse(Console.ReadLine());
            double sum = 0;
            string strCoins = "";
            strCoins += input;

            while (strCoins != "Start")
            {
                input = double.Parse(strCoins);
                if (input == 0.1 || input == 0.2 || input == 0.5 || input == 1 || input == 2)
                {
                    sum += input;
                }
                else
                {
                    Console.WriteLine($"Cannot accept {input}");
                }
                strCoins = Console.ReadLine();
            }

            string product = Console.ReadLine();

            while (product != "End")
            {
                if (product == "Nuts" || product == "Water" || product == "Crisps" || product == "Soda" || product == "Coke")
                {
                    switch (product)
                    {
                        case "Nuts":
                            if (sum >= 2.0)
                            {
                                Console.WriteLine($"Purchased {product.ToLower()}");
                                sum -= 2.0;
                            }
                            else
                            {
                                Console.WriteLine("Sorry, not enough money");
                            }
                            break;
                        case "Water":
                            if (sum >= 0.7)
                            {
                                Console.WriteLine($"Purchased {product.ToLower()}");
                                sum -= 0.7;
                            }
                            else
                            {
                                Console.WriteLine("Sorry, not enough money");
                            }
                            break;
                        case "Crisps":
                            if (sum >= 1.5)
                            {
                                Console.WriteLine($"Purchased {product.ToLower()}");
                                sum -= 1.5;
                            }
                            else
                            {
                                Console.WriteLine("Sorry, not enough money");
                            }
                            break;
                        case "Soda":
                            if (sum >= 0.8)
                            {
                                Console.WriteLine($"Purchased {product.ToLower()}");
                                sum -= 0.8;
                            }
                            else
                            {
                                Console.WriteLine("Sorry, not enough money");
                            }
                            break;
                        case "Coke":
                            if (sum >= 1.0)
                            {
                                Console.WriteLine($"Purchased {product.ToLower()}");
                                sum -= 1.0;
                            }
                            else
                            {
                                Console.WriteLine("Sorry, not enough money");
                            }
                            break;
                    }
                }
                else
                {
                    Console.WriteLine("Invalid product");
                }

                product = Console.ReadLine();
            }
            Console.WriteLine($"Change: {sum:f2}");
        }
    }
}
