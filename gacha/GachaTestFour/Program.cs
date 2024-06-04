using System;
using System.Collections.Generic;

namespace GachaApplication
{
    class Program
    {
        static int totalPulls = 0; // Track the total number of pulls

        // Mapping between item numbers and their names
        static Dictionary<int, string> itemNames = new Dictionary<int, string>
        {
            { 1, "Bronze Sword" },
            { 2, "Rusty Claymore" },
            { 3, "Piper's Boot" },
            { 4, "Poop Blade" },
            { 5, "Ordinary Bow" },
            { 6, "Iron Sword" },
            { 7, "Epic" },
            { 8, "4-star Weapon" },
            { 9, "Gaia's Breath" },
            { 10, "Legendary Smacker" }
        };

        static bool print(string line, ConsoleColor color)
        {
            Console.ForegroundColor = color;
            Console.WriteLine(line);
            Console.ResetColor();
            return true;
        }

        static void Main(string[] args)
        {
            bool exit = false;

            while (!exit)
            {
                Console.WriteLine("Hello, World!");

                print("Do you want to do single pull or 10-roll? (1, 10)", ConsoleColor.Cyan);

                string number1Input = Console.ReadLine();

                if (number1Input == "1")
                {
                    // Perform single pull
                    string item = SinglePull();
                    print($"You received: {GetItemName(item)}", ConsoleColor.Yellow);
                }
                else if (number1Input == "10")
                {
                    // Perform 10-roll
                    for (int i = 0; i < 10; i++)
                    {
                        string item = SinglePull();
                        print($"You received: {GetItemName(item)}", ConsoleColor.Yellow);
                    }
                }
                else
                {
                    print("Invalid input. Please enter either 1 for single pull or 10 for 10-roll.", ConsoleColor.Red);
                }

                print("Do you want to continue? (yes/no)", ConsoleColor.Cyan);
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
                { "Bronze Sword", 0.186 },
                { "Rusty Claymore", 0.186 },
                { "Piper's Boot", 0.186 },
                { "Poop Blade", 0.186 },
                { "Ordinary Bow", 0.186 },
                { "Iron Sword", 0.017 },
                { "Epic", 0.017 },
                { "4-star Weapon", 0.017 },
                { "Gaia's Breath", 0.008 },
                { "Legendary Smacker", 0.008 }
            };

            // Adjust probabilities dynamically based on the total number of pulls
            if (totalPulls >= 74 && totalPulls <= 89)
            {
                // Calculate the increased probability linearly
                double increasedProbability = 0.002 + (totalPulls - 74) * 0.002;
                items["Gaia's Breath"] = increasedProbability; // Increase probability of Gaia's Breath
                items["Legendary Smacker"] = increasedProbability; // Increase probability of Legendary Smacker
            }
            else if (totalPulls >= 90)
            {
                // Guarantee Gaia's Breath or Legendary Smacker after 90 pulls
                items["Gaia's Breath"] = 0.05; // Set probability of Gaia's Breath to 5%
                items["Legendary Smacker"] = 0.05; // Set probability of Legendary Smacker to 5%
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

        static string GetItemName(string item)
        {
            // Extract the item number from the item string
            int itemNumber;
            if (!int.TryParse(item.Substring(5), out itemNumber))
            {
                // If parsing fails, return an error message
                return "Unknown Item";
            }

            // Look up the item name based on the item number
            if (itemNames.ContainsKey(itemNumber))
            {
                return itemNames[itemNumber];
            }
            else
            {
                return "Unknown Item";
            }
        }
    }
}