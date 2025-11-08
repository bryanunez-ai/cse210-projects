using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Exercise3 Project.");
        
        /// Ask Magic Number
        /// Console.WriteLine("What is the magic number?");
        /// int magicNumber = int.Parse(Console.ReadLine());
        
        /// Generate random numner instead
        Random randomGenerator = new Random();
        /// int magicNumber = randomGenerator.Next(1, 100);

        /// Guesses
        int guesses = 0;

        /// Guess
        int guess = 0;

        Console.WriteLine("Guess the magic number between 1 and 100!");

        /// Play Again
        string playAgain = "Y";
        while (playAgain == "Y")
        {
            /// Reset variables
            guesses = 0;
            int magicNumber = randomGenerator.Next(1, 100);
            guess = 0;

            /// Loop until guess is correct
            while (guess != magicNumber)
            {

                /// Ask Guess
                Console.WriteLine("What is your guess?");
                guess = int.Parse(Console.ReadLine());
                guesses++;

                /// Determine higher, lower or equal
                if (guess > magicNumber)
                {
                    Console.WriteLine("Your guess is too high.");
                }
                else if (guess < magicNumber)
                {
                    Console.WriteLine("Your guess is too low.");
                }
                else
                {
                    Console.WriteLine("Congratulations! You guessed the magic number!");
                }
                /// Prin guesses
                Console.WriteLine($"You have guessed {guesses} times.");

            }

            /// Play again?
            Console.WriteLine("Do you want to play again? (Y/N)");
            playAgain = Console.ReadLine();

        }
        
        /// Bye
        Console.WriteLine("Thanks for playing!");
    }
}