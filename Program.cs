using System;

namespace CountdownGen
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            Console.ForegroundColor = ConsoleColor.White;

            Console.WriteLine("==================================================");
            Console.WriteLine("        GITHUB COUNTDOWN BADGE GENERATOR          ");
            Console.WriteLine("==================================================\n");

            Console.Write(">> Event name: ");
            string eventName = Console.ReadLine()!;

            Console.Write(">> Target date (YYYY-MM-DD): ");
            string dateInput = Console.ReadLine()!;

            Console.WriteLine("\n--------------------------------------------------");

            try
            {
                DateTimeOffset targetDate = DateTimeOffset.Parse(dateInput);
                long unixTimestamp = targetDate.ToUnixTimeSeconds();
                string encodedName = Uri.EscapeDataString(eventName);
                string badgeUrl = $"https://img.shields.io/date/{unixTimestamp}?label={encodedName}&color=orange&style=for-the-badge";

                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine(">> Success! Your code is ready below:\n");

                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine($"[![Countdown]({badgeUrl})]()");
            }
            catch (FormatException)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("[ERROR] Invalid date format. Please use YYYY-MM-DD.");
            }

            Console.ResetColor();
            Console.WriteLine("\nPress any key to exit...");
            Console.ReadKey();
        }
    }
}