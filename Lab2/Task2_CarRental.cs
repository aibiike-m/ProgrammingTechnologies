using System;

namespace programming_tecnologies
{
    public class Car
    {
        public string Brand { get; set; }
        public string Model { get; set; }
        public int Year { get; set; }
        public decimal DailyRate { get; set; }

        public Car(string brand, string model, int year, decimal dailyRate)
        {
            Brand = brand;
            Model = model;
            Year = year;
            DailyRate = dailyRate;
        }

        public decimal CalculateRentalCost(int days)
        {
            return DailyRate * days;
        }

        public void PrintInfo()
        {
            Console.WriteLine($"Brand: {Brand}");
            Console.WriteLine($"Model: {Model}");
            Console.WriteLine($"Year: {Year}");
            Console.WriteLine($"Daily rate: {DailyRate}");
        }
    }

    public static class Task2_CarRentalRunner
    {
        public static void Run()
        {
            Console.Write("Enter brand: ");
            string? brand = Console.ReadLine();

            Console.Write("Enter model: ");
            string? model = Console.ReadLine();

            Console.Write("Enter year: ");
            int.TryParse(Console.ReadLine(), out int year);

            Console.Write("Enter daily rate: ");
            decimal.TryParse(Console.ReadLine(), out decimal rate);

            Car car = new Car(brand ?? "Unknown", model ?? "Unknown", year, rate);
            car.PrintInfo();

            Console.Write("Enter rental days: ");
            int.TryParse(Console.ReadLine(), out int days);

            Console.WriteLine($"Total rental cost for {days} days: {car.CalculateRentalCost(days)}");
        }
    }
}