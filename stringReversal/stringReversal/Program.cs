using System;

class Program
{
    // Method to reverse a string using a loop
    static string Reversed(string input)
    {
        string reversedString = "";

        
        for (int i = input.Length - 1; i >= 0; i--)
        {
            reversedString += input[i];
        }

        return reversedString;
    }

    static void Main(string[] args)
    {
        Console.Write("Enter a string: ");
        string input = Console.ReadLine();

        Console.WriteLine("Reversed String: " + Reversed(input));
    }
}
