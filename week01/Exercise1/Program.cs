using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Exercise1 Project.");

        /// Get first name
        Console.WriteLine("What is your first name?");
        string firstName = Console.ReadLine();

        /// Get last name
        Console.WriteLine("What is your last name?");
        string lastName = Console.ReadLine();

        /// Create full name
        string fullName = firstName + " " + lastName;

        /// Print name as cool as James Bond would do it
        Console.WriteLine($"Your name is {lastName}, {fullName}.");
    }
}