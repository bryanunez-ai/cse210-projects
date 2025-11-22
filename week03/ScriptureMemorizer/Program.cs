using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the ScriptureMemorizer Project.");

        Console.WriteLine("Please select an option to memorize:");
        Console.WriteLine("1. 1 Nephi 3:5-7");
        Console.WriteLine("2. John 3:16");
        Console.WriteLine("3. Random scripture");

        int option = int.Parse(Console.ReadLine());

        // Validate option
        while (option != 1 && option != 2 && option != 3)
        {
            Console.WriteLine("Invalid option. Please try again.");
            Console.WriteLine("Please select an option to memorize:");
            Console.WriteLine("1. 1 Nephi 3:5-7");
            Console.WriteLine("2. John 3:16");
            Console.WriteLine("3. Random scripture");
            option = int.Parse(Console.ReadLine());
        }

        Scripture scripture;

        if (option == 3)
        {
            scripture = new Scripture();  // Random
        }
        else
        {
            scripture = new Scripture(option);  // Options 1 or 2
        }


        // This will start by displaying the scripture and waiting for the user to press the enter key
        Console.WriteLine(scripture.GetDisplayText());
        string input = "";

        while (input.ToLower() != "quit" && !scripture.IsCompletelyHidden())
        {
            Console.Write("\nPress enter to continue or type 'quit' to finish: ");
            input = Console.ReadLine();

            if (input.ToLower() != "quit")
            {
                // This will clear the console
                Console.Clear();

                // Hide random words
                scripture.HideRandomWords(3);

                // This will show the scripture with words hidden
                Console.WriteLine(scripture.GetDisplayText());
            }
        }
    }
}