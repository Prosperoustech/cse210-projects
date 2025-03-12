using System;

class Program
{
    static void Main(string[] args)
    {
        string playAgain = "yes";
        Random random = new Random();

        while (playAgain == "yes")
        {
            int magicNumber = random.Next(1, 101); // Generates a random number between 1 and 100
            Console.WriteLine();

            int guess = -1; // Set to a value that ensures the loop starts
            int guessesTrack = 0;

            while (guess != magicNumber) // Loop until the guess is correct
            {
                Console.Write("What is your guess? ");
                guess = int.Parse(Console.ReadLine());
                guessesTrack++; // Increases guesses count

                if (guess < magicNumber)
                {
                    Console.WriteLine("Higher");
                }
                else if (guess > magicNumber)
                {
                    Console.WriteLine("Lower");
                }
                else
                {
                    Console.WriteLine($"Congratulations! You guessed it in {guessesTrack} attempts!");
                }
            }
            
            Console.Write("Do you want to play again? ");
            playAgain = Console.ReadLine().ToLower();
        }
    }
}