using System;

namespace programming_tecnologies
{
    public class Order
    {
        public string DishName { get; set; }
        public int Quantity { get; set; }
        public decimal PricePerUnit { get; set; }

        public Order(string dishName, int quantity, decimal pricePerUnit)
        {
            DishName = dishName;
            Quantity = quantity;
            PricePerUnit = pricePerUnit;
        }

        public decimal GetTotalPrice()
        {
            return Quantity * PricePerUnit;
        }

        public void PrintInfo()
        {
            Console.WriteLine($"Dish: {DishName}");
            Console.WriteLine($"Quantity: {Quantity}");
            Console.WriteLine($"Price per unit: {PricePerUnit}");
            Console.WriteLine($"Total price: {GetTotalPrice()}");
        }
    }

    public static class Task1_RestaurantOrderRunner
    {
        public static void Run()
        {
            Console.Write("Enter dish name: ");
            string? dish = Console.ReadLine();

            Console.Write("Enter quantity: ");
            int.TryParse(Console.ReadLine(), out int qty);

            Console.Write("Enter price per unit: ");
            decimal.TryParse(Console.ReadLine(), out decimal price);

            Order order = new Order(dish ?? "Unknown", qty, price);
            order.PrintInfo();
        }
    }
}