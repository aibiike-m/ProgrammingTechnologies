using System;

namespace programming_tecnologies
{
    public static class Task2_AlcoholTracker
    {
        public static void Run()
        {
            Console.Write("Enter drink type (beer, wine, vodka): ");
            string? drink = Console.ReadLine()?.Trim().ToLower();

            Console.Write("Enter number of servings: ");
            if (!int.TryParse(Console.ReadLine(), out int servings) || servings < 0)
            {
                Console.WriteLine("Invalid number of servings.");
                return;
            }

            double totalVolume = 0;
            if (drink == "beer")
            {
                totalVolume = servings * 500;
            }
            else if (drink == "wine")
            {
                totalVolume = servings * 150;
            }
            else if (drink == "vodka")
            {
                totalVolume = servings * 50;
            }
            else
            {
                Console.WriteLine("Unknown drink type.");
                return;
            }

            Console.WriteLine($"Total drink volume: {totalVolume} ml");

            if (servings > 3)
            {
                Console.WriteLine("Warning: Exceeding safe consumption limit!");
            }
            else
            {
                Console.WriteLine("Within safe limits.");
            }
        }
    }
}