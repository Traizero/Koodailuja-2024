// See https://aka.ms/new-console-template for more information
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

static bool print(string line)
{
    if (line == "error")
        return false;
    else
        Console.WriteLine(line);
    return true;
}


Console.WriteLine("Hello, World!");

print("Do you want to do single pull or 10-roll? (1, 10)");


string number1Input = Console.ReadLine();

