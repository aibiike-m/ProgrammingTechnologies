using System;

namespace programming_tecnologies
{
    public class Book
    {
        public string Title { get; set; }
        public string Author { get; set; }
        public bool IsAvailable { get; set; }

        public Book(string title, string author, bool isAvailable)
        {
            Title = title;
            Author = author;
            IsAvailable = isAvailable;
        }

        public void ChangeStatus()
        {
            IsAvailable = !IsAvailable;
        }

        public void PrintInfo()
        {
            Console.WriteLine($"Title: {Title}");
            Console.WriteLine($"Author: {Author}");
            Console.WriteLine($"Status: {(IsAvailable ? "Available" : "Issued")}");
        }
    }

    public static class Task3_LibraryRunner
    {
        public static void Run()
        {
            Console.Write("Enter book title: ");
            string? title = Console.ReadLine();

            Console.Write("Enter author: ");
            string? author = Console.ReadLine();

            Book book = new Book(title ?? "Unknown", author ?? "Unknown", true);
            book.PrintInfo();

            Console.Write("Change status? (yes/no): ");
            string? choice = Console.ReadLine()?.Trim().ToLower();
            if (choice == "yes" || choice == "y")
            {
                book.ChangeStatus();
                Console.WriteLine("Status changed.");
                book.PrintInfo();
            }
        }
    }
}