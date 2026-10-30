using System;

namespace programming_tecnologies
{
    public static class Task4_GladiatorTraining
    {
        public static void Run()
        {
            Console.Write("Enter training type (sword fight, running, strength): ");
            string? type = Console.ReadLine()?.Trim().ToLower();

            Console.Write("Enter daily training hours: ");
            if (!double.TryParse(Console.ReadLine(), out double hoursPerDay) || hoursPerDay <= 0)
            {
                Console.WriteLine("Invalid hours.");
                return;
            }

            Console.Write("Enter training days per week (1-7): ");
            if (!int.TryParse(Console.ReadLine(), out int daysPerWeek) || daysPerWeek < 1 || daysPerWeek > 7)
            {
                Console.WriteLine("Invalid number of days.");
                return;
            }

            double totalWeeklyHours = hoursPerDay * daysPerWeek;
            Console.WriteLine($"Training type: {type}");
            Console.WriteLine($"Total weekly training hours: {totalWeeklyHours}");

            if (type == "sword fight")
            {
                Console.WriteLine("Recovery recommendation: Focus on upper body stretching and joint care.");
            }
            else if (type == "running")
            {
                Console.WriteLine("Recovery recommendation: Rehydrate thoroughly and stretch leg muscles.");
            }
            else if (type == "strength")
            {
                Console.WriteLine("Recovery recommendation: Ensure high protein intake and adequate sleep for muscle repair.");
            }
            else
            {
                Console.WriteLine("Recovery recommendation: Rest well and stay hydrated.");
            }
        }
    }
}