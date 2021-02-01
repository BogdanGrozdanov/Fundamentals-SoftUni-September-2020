﻿using System;

namespace Login
{
    class Login
    {
        static void Main(string[] args)
        {
            string username = Console.ReadLine();

            string password = String.Empty;

            for (int i = username.Length - 1; i >= 0; i--)
            {
                password += username[i];
            }

            string input = Console.ReadLine();
            int counter = 1;

            while (input != password)
            {

                if (counter == 4)
                {
                    Console.WriteLine($"User {username} blocked!");
                    break;
                }
                Console.WriteLine("Incorrect password. Try again.");
                input = Console.ReadLine();
                counter++;
            }
            if (input == password)
            {
                Console.WriteLine($"User {username} logged in.");
            }
        }
    }
}
