using System;

namespace programming_tecnologies
{
    public static class Task1_SkiRental
    {
        public static void Run()
        {
            Console.Write("Enter rental days: ");
            if (!int.TryParse(Console.ReadLine(), out int days) || days <= 0)
            {
                Console.WriteLine("Invalid number of days.");
                return;
            }

            Console.Write("Choose equipment (1 - Skis, 2 - Snowboard): ");
            string? choice = Console.ReadLine();

            decimal dailyRate = 0;
            string equipmentName = "";

            if (choice == "1")
            {
                dailyRate = 1200m;
                equipmentName = "Skis";
            }
            else if (choice == "2")
            {
                dailyRate = 1400m;
                equipmentName = "Snowboard";
            }
            else
            {
                Console.WriteLine("Invalid equipment choice.");
                return;
            }

            Console.Write("Apply insurance? (yes/no): ");
            string? insuranceInput = Console.ReadLine()?.Trim().ToLower();
            bool applyInsurance = insuranceInput == "yes" || insuranceInput == "y";

            decimal insuranceDailyRate = 200m;
            decimal equipmentTotal = dailyRate * days;
            decimal insuranceTotal = applyInsurance ? (insuranceDailyRate * days) : 0;
            decimal totalCost = equipmentTotal + insuranceTotal;

            Console.WriteLine($"Equipment: {equipmentName}");
            Console.WriteLine($"Rental days: {days}");
            Console.WriteLine($"Insurance: {(applyInsurance ? "Yes" : "No")}");
            Console.WriteLine($"Total cost: {totalCost}");
        }
    }
}