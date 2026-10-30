using System;
using System.Collections.Generic;

namespace programming_tecnologies
{
    public static class Task6_BeautySalon
    {
        public static void Run()
        {
            var clients = new List<(string Name, string Services, decimal Amount)>();

            while (true)
            {
                Console.Write("Enter client name (or type 'stop' to finish): ");
                string? name = Console.ReadLine()?.Trim();
                if (string.IsNullOrEmpty(name) || name.ToLower() == "stop")
                {
                    break;
                }

                Console.Write("Enter services (e.g., haircut, manicure): ");
                string? services = Console.ReadLine()?.Trim();

                Console.Write("Enter total payment amount: ");
                if (!decimal.TryParse(Console.ReadLine(), out decimal amount) || amount < 0)
                {
                    Console.WriteLine("Invalid amount. Try again.");
                    continue;
                }

                clients.Add((name, services ?? "None", amount));
                Console.WriteLine("Client added successfully.\n");
            }

            Console.WriteLine("\nDaily Client List:");
            if (clients.Count == 0)
            {
                Console.WriteLine("No clients recorded today.");
                return;
            }

            decimal totalRevenue = 0;
            foreach (var client in clients)
            {
                Console.WriteLine($"Client: {client.Name} | Services: {client.Services} | Amount: {client.Amount}");
                totalRevenue += client.Amount;
            }

            Console.WriteLine($"Total daily revenue: {totalRevenue}");
        }
    }
}