using System;

namespace programming_tecnologies
{
    public static class Task3_AgePeriod
    {
        public static void Run()
        {
            Console.Write("Enter your age: ");
            if (!int.TryParse(Console.ReadLine(), out int age) || age < 0)
            {
                Console.WriteLine("Invalid age.");
                return;
            }

            if (age <= 12)
            {
                Console.WriteLine("Period: Childhood");
                Console.WriteLine("Recommendation: Focus on learning, play, and healthy sleep.");
            }
            else if (age >= 13 && age <= 19)
            {
                Console.WriteLine("Period: Adolescence");
                Console.WriteLine("Recommendation: Explore your interests, build good study habits, and stay active.");
            }
            else if (age >= 20 && age <= 59)
            {
                Console.WriteLine("Period: Adulthood");
                Console.WriteLine("Recommendation: Balance career growth, physical health, and personal well-being.");
            }
            else
            {
                Console.WriteLine("Period: Old age");
                Console.WriteLine("Recommendation: Maintain a calm lifestyle, regular gentle walks, and health monitoring.");
            }
        }
    }
}