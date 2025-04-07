using System;
using System.Linq;

class Program
{
    static void Main(string[] args)
    {
        try
        {
            Console.WriteLine("Program Started. Press any key to continue...");
            Console.ReadKey();

            Console.Write("Current rate of point generation: ");
            int rate = int.Parse(Console.ReadLine());

            Console.Write("Enter start time (HH:MM): ");
            var start = Console.ReadLine().Split(':').Select(int.Parse).ToArray();

            Console.Write("Enter end time (HH:MM): ");
            var end = Console.ReadLine().Split(':').Select(int.Parse).ToArray();

            int startMin = start[0] * 60 + start[1];
            int endMin = end[0] * 60 + end[1];

            int time = (endMin - startMin + 1440) % 1440;
            int points = rate * time;

            Console.WriteLine($"Points for the selected timeframe: {points}");

            
            Console.WriteLine();
            Console.WriteLine("© Neurosamaclipper 2025. All Rights Reserved.");

            Console.WriteLine("Press any key to exit...");
            Console.ReadKey();
        }
        catch (Exception ex)
        {
            Console.WriteLine("Oops! An error occurred: " + ex.Message);
            Console.WriteLine("© Neurosamaclipper 2025. All Rights Reserved.");
            Console.ReadKey();
        }
    }
}
