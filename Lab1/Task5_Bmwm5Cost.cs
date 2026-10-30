using System;

namespace programming_tecnologies
{
    public static class Task5_Bmwm5Cost
    {
        public static void Run()
        {
            Console.Write("Enter average fuel consumption per 100 km (liters): ");
            if (!double.TryParse(Console.ReadLine(), out double fuelPer100) || fuelPer100 <= 0)
            {
                Console.WriteLine("Invalid input.");
                return;
            }

            Console.Write("Enter average fuel price per liter: ");
            if (!double.TryParse(Console.ReadLine(), out double fuelPrice) || fuelPrice <= 0)
            {
                Console.WriteLine("Invalid input.");
                return;
            }

            Console.Write("Enter annual mileage (km): ");
            if (!double.TryParse(Console.ReadLine(), out double mileage) || mileage < 0)
            {
                Console.WriteLine("Invalid input.");
                return;
            }

            Console.Write("Enter annual insurance cost: ");
            if (!double.TryParse(Console.ReadLine(), out double insurance) || insurance < 0)
            {
                Console.WriteLine("Invalid input.");
                return;
            }

            double fuelCost = (mileage / 100.0) * fuelPer100 * fuelPrice;
            double totalCost = fuelCost + insurance;

            Console.WriteLine($"Annual fuel cost: {fuelCost:F2}");
            Console.WriteLine($"Annual insurance cost: {insurance:F2}");
            Console.WriteLine($"Total annual ownership cost: {totalCost:F2}");
        }
    }
}