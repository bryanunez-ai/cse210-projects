using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Journal Project.");

        Journal journal = new Journal();
        Menu menu = new Menu();
        PromptGenerator promptGenerator = new PromptGenerator();

        Console.WriteLine("Welcome to your Journal!");

        int option = 0;
        
        while (option != 5)
        {   
            // EXCEEDING CORE REQUIREMENTS
            // Developed a new class that creates a Menu object and has the DisplayMenu method that displays the menu everytime. Applied abstraction in this class as well.
            // Display menu and get option
            menu.DisplayMenu();
            option = int.Parse(Console.ReadLine());


            if (option == 1)
            {
                // Create new entry
                Entry entry = new Entry();
                string prompt = promptGenerator.GeneratePrompt();
                Console.WriteLine(prompt);
                entry._entryText = Console.ReadLine();
                entry._date = DateTime.Now.ToShortDateString();
                entry._promptText = prompt;

                // Add entry to journal
                journal.AddEntry(entry);

            }
            else if (option == 2)
            {
                // Display all entries
                journal.DisplayAll();
            }
            else if (option == 3)
            {
                // Load from file
                Console.WriteLine("Please enter the filename:");
                string filename = Console.ReadLine();
                journal.LoadFromFile(filename);
            }
            else if (option == 4)
            {
                // Save to file
                Console.WriteLine("Please enter the filename:");
                string filename = Console.ReadLine();
                journal.SaveToFile(filename);
            }
            else if (option == 5)
            {
                // Quit
                Console.WriteLine("See you next time.");
            }
            else
            {
                Console.WriteLine("Invalid option. Please enter an integer from 1 to 5.");
            }

        }

    }
}