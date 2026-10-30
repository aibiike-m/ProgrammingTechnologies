using System;
using System.IO;
using System.Threading.Tasks;

namespace programming_tecnologies
{
    public static class Task5_AsyncReportRunner
    {
        public static async Task RunAsync()
        {
            Console.WriteLine("Starting report download...");
            
            await Task.Delay(2000);

            string reportData = "Sales Report: Total revenue - $50,000, Orders - 1200.";
            await File.WriteAllTextAsync("report.txt", reportData);

            Console.WriteLine("Report downloaded and saved to 'report.txt'.");
        }

        public static void Run()
        {
            RunAsync().GetAwaiter().GetResult();
        }
    }
}