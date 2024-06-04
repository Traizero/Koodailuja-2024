using System;
using System.Collections.Generic;

namespace GachaApplication
{
    class Program
    {
        static int totalPulls = 0; // Track the total number of pulls

        static bool print(string line)
        {
            if (line == "error")
                return false;
            else
                Console.WriteLine(line);
            return true;
        }

        static void Main(string[] args)
        {
            bool exit = false;

            while (!exit)
            {
                Console.WriteLine("Hello, World!");

                print("Do you want to do single pull or 10-roll? (1, 10)");

                string number1Input = Console.ReadLine();

                if (number1Input == "1")
                {
                    // Perform single pull
                    string item = SinglePull();
                    print($"You received: {item}");
                }
                else if (number1Input == "10")
                {
                    // Perform 10-roll
                    for (int i = 0; i < 10; i++)
                    {
                        string item = SinglePull();
                        print($"You received: {item}");
                    }
                }
                else
                {
                    print("Invalid input. Please enter either 1 for single pull or 10 for 10-roll.");
                }

                print("Do you want to continue? (yes/no)");
                string continueInput = Console.ReadLine();
                if (continueInput.ToLower() != "yes")
                {
                    exit = true;
                }
            }
        }

        static string SinglePull()
        {
            // Increment the total number of pulls
            totalPulls++;

            // List of items with initial probabilities
            Dictionary<string, double> items = new Dictionary<string, double>
            {
                { "Item 1", 0.2 },  // 20% chance
                { "Item 2", 0.3 },  // 30% chance
                { "Item 3", 0.1 },  // 10% chance
                { "Item 4", 0.1 },  // 10% chance
                { "Item 5", 0.1 },  // 10% chance
                { "Item 6", 0.05 }, // 5% chance
                { "Item 7", 0.05 }, // 5% chance
                { "Item 8", 0.05 }, // 5% chance
                { "Item 9", 0.025 }, // 2% chance initially
                { "Item 10", 0.025 } // 2% chance initially
            };

            // Adjust probabilities dynamically based on the total number of pulls
            // Adjust probabilities dynamically based on the total number of pulls
            if (totalPulls >= 74 && totalPulls <= 89)
            {
                // Calculate the increased probability linearly
                double increasedProbability = 0.02 + (totalPulls - 74) * 0.02;
                items["Item 9"] = increasedProbability; // Increase probability of Item 9
                items["Item 10"] = increasedProbability; // Increase probability of Item 10
            }
            else if (totalPulls >= 90)
            {
                // Guarantee Item 9 or Item 10 after 90 pulls
                items["Item 9"] = 0.5; // Set probability of Item 9 to 50%
                items["Item 10"] = 0.5; // Set probability of Item 10 to 50%
            }

            // Generate a random number between 0 and 1
            double randomNumber = new Random().NextDouble();

            // Calculate cumulative probability
            double cumulativeProbability = 0.0;
            foreach (var kvp in items)
            {
                cumulativeProbability += kvp.Value;
                if (randomNumber < cumulativeProbability)
                {
                    return kvp.Key;
                }
            }

            // This should not be reached, but just in case
            return "No item";
        }
    }
}