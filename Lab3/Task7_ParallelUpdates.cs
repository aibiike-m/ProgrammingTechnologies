using System;
using System.Threading.Tasks;

namespace programming_tecnologies
{
    public static class Task7_ParallelUpdatesRunner
    {
        public static async Task RunAsync()
        {
            Console.WriteLine("Updating data from multiple sources...");

            Task<string> weatherTask = FetchWeatherAsync();
            Task<string> newsTask = FetchNewsAsync();
            Task<string> currencyTask = FetchCurrencyAsync();

            string[] results = await Task.WhenAll(weatherTask, newsTask, currencyTask);

            Console.WriteLine("\nAll data updated successfully:");
            Console.WriteLine(results[0]);
            Console.WriteLine(results[1]);
            Console.WriteLine(results[2]);
        }

        private static async Task<string> FetchWeatherAsync()
        {
            await Task.Delay(1500);
            return "Weather: +22°C, Sunny";
        }

        private static async Task<string> FetchNewsAsync()
        {
            await Task.Delay(1000);
            return "News: Tech markets rise globally.";
        }

        private static async Task<string> FetchCurrencyAsync()
        {
            await Task.Delay(2000);
            return "Currency: USD/EUR = 0.92";
        }

        public static void Run()
        {
            RunAsync().GetAwaiter().GetResult();
        }
    }
}