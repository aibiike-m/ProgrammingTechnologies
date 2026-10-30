using System;

namespace programming_tecnologies
{
    public static class Task3_OrderExceptionRunner
    {
        public static void Run()
        {
            try
            {
                Console.Write("Enter quantity: ");
                int quantity = int.Parse(Console.ReadLine() ?? "0");

                Console.Write("Enter price per unit: ");
                decimal price = decimal.Parse(Console.ReadLine() ?? "0");

                if (quantity < 0 || price < 0)
                {
                    throw new ArgumentException("Quantity and price cannot be negative.");
                }

                decimal total = quantity * price;
                Console.WriteLine($"Total order cost: {total}");
            }
            catch (FormatException)
            {
                Console.WriteLine("Error: Please enter valid numeric values.");
            }
            catch (ArgumentException ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Unexpected error: {ex.Message}");
            }
        }
    }
}