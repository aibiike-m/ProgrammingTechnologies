using System;
using System.IO;

namespace programming_tecnologies
{
    public static class Task4_EventLogRunner
    {
        public static void Run()
        {
            string filePath = "log.txt";
            string logEntry = $"User login at: {DateTime.Now}\n";

            File.AppendAllText(filePath, logEntry);

            Console.WriteLine("Event log content:");
            string logContent = File.ReadAllText(filePath);
            Console.WriteLine(logContent);
        }
    }
}