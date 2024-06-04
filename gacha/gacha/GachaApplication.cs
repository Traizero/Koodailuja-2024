using System;
using System.Collections.Generic;

namespace GachaApplication
{
    class Program
    {
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
        }

        static string SinglePull()
        {
            // List of items with probabilities
            Dictionary<string, double> items = new Dictionary<string, double>
            {
            
                { "Bronze Sword", 0.186 },  // 20% chance
                { "Rusty Claymore", 0.186 },  // 30% chance
                { "Piper's Boot", 0.186 },  // 10% chance
                { "Poop Blade", 0.186 },  // 10% chance
                { "Ordinary Bow", 0.186 },  // 10% chance
                { "Iron Sword", 0.017 }, // 5% chance
                { "Epic", 0.017 }, // 5% chance
                { "4-star Weapon", 0.017 }, // 5% chance
                { "Gaia's Breath", 0.008 }, // 2% chance
                { "Legendary Smacker", 0.008 } // 2% chance
            
        };

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