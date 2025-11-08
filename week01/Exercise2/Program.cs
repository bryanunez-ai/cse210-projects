using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Exercise2 Project.");

        /// Ask grade percetnage
        Console.WriteLine("Please enter your grade percentage:");
        int gradePercentage = int.Parse(Console.ReadLine());
        string gradeLetter = "N/A";

        /// Validate input
        if (gradePercentage < 0 || gradePercentage > 100)
        {
            Console.WriteLine("Invalid grade percentage. Must be between 0 and 100.");
        }
        else
        {
            /// Assign letter grade
            if (gradePercentage >= 90)
            {
                gradeLetter = "A";
            }
            else if (gradePercentage >= 80)
            {
                gradeLetter = "B";
            }
            else if (gradePercentage >= 70)
            {
                gradeLetter = "C";
            }
            else if (gradePercentage >= 60)
            {
                gradeLetter = "D";
            }
            else
            {
                gradeLetter = "F";
            }

            /// Stretch Challenge
            /// Assign + or - to letter grade

            /// Get remainder
            int remainder = gradePercentage % 10;
            string sign = "";

            /// Assign sign
            if (remainder >= 7)
            {   
                /// Handle Exceptions
                if (gradeLetter == "A" || gradeLetter == "F")
                {
                    sign = "";
                }
                else
                {
                    sign = "+";
                }
            }
            else if (remainder < 3)
            {   
                // Handle Exceptions
                if (gradeLetter == "F")
                {
                    sign = "";
                }
                else
                {
                    sign = "-";
                }
            }
            else
            {
                sign = "";
            }

            /// Print letter grade if valid percentage was entered.
            Console.WriteLine($"Your grade is {gradeLetter}{sign}.");
            /// Congratulate or print sad message :(
            if (gradeLetter == "A" || gradeLetter == "B" || gradeLetter == "C")
            {
                Console.WriteLine("Congratulations! You passed!");
            }
            else
            {
                Console.WriteLine("Sorry, you failed. :(, try again next time. You can do it!");
            }  
        }
    }
}