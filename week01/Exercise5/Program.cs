using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Welcome to the program");

        // Ask user for name
        Console.Write("Please enter your name: ");
        string userName = Console.ReadLine();

        // Ask user for favourite number
        Console.Write("Please enter your favourite number: ");
        int favouriteNumber = int.Parse(Console.ReadLine());

        // Find the square of the user's favourite number
        int result = favouriteNumber * favouriteNumber;

        // Print the square
        Console.WriteLine($"The square of your favourite number is {result}");
    }
}