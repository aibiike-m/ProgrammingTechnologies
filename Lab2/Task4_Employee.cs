using System;

namespace programming_tecnologies
{
    public class Employee
    {
        public string Name { get; set; }
        public string Position { get; set; }
        public decimal Salary { get; set; }

        public Employee(string name, string position, decimal salary)
        {
            Name = name;
            Position = position;
            Salary = salary;
        }

        public void IncreaseSalary(decimal amount)
        {
            Salary += amount;
        }

        public void PrintInfo()
        {
            Console.WriteLine($"Name: {Name}");
            Console.WriteLine($"Position: {Position}");
            Console.WriteLine($"Salary: {Salary}");
        }
    }

    public static class Task4_EmployeeRunner
    {
        public static void Run()
        {
            Console.Write("Enter employee name: ");
            string? name = Console.ReadLine();

            Console.Write("Enter position: ");
            string? position = Console.ReadLine();

            Console.Write("Enter salary: ");
            decimal.TryParse(Console.ReadLine(), out decimal salary);

            Employee emp = new Employee(name ?? "Unknown", position ?? "Unknown", salary);
            emp.PrintInfo();

            Console.Write("Enter amount to increase salary: ");
            decimal.TryParse(Console.ReadLine(), out decimal increase);

            emp.IncreaseSalary(increase);
            Console.WriteLine("Salary updated.");
            emp.PrintInfo();
        }
    }
}
