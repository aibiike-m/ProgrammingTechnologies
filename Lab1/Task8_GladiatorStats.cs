using System;

namespace programming_tecnologies
{
    public static class Task8_GladiatorStats
    {
        public static void Run()
        {
            int wins = 0;
            int losses = 0;

            while (true)
            {
                Console.Write("Enter battle result (win / loss, or type 'stop' to finish): ");
                string? result = Console.ReadLine()?.Trim().ToLower();

                if (result == "stop")
                {
                    break;
                }
                else if (result == "win")
                {
                    wins++;
                }
                else if (result == "loss")
                {
                    losses++;
                }
                else
                {
                    Console.WriteLine("Invalid input. Type 'win', 'loss', or 'stop'.");
                }
            }

            int totalBattles = wins + losses;
            if (totalBattles == 0)
            {
                Console.WriteLine("No battles recorded.");
                return;
            }

            double winRate = (double)wins / totalBattles * 100;

            Console.WriteLine($"Total battles: {totalBattles}");
            Console.WriteLine($"Wins: {wins}");
            Console.WriteLine($"Losses: {losses}");
            Console.WriteLine($"Win rate: {winRate:F2}%");

            if (winRate >= 80)
            {
                Console.WriteLine("Motivational message: Legendary gladiator! The crowd roars for you!");
            }
            else if (winRate >= 50)
            {
                Console.WriteLine("Motivational message: Solid performance. Keep sharpening your skills!");
            }
            else
            {
                Console.WriteLine("Motivational message: Do not despair. Every defeat brings experience for future victories.");
            }
        }
    }
}