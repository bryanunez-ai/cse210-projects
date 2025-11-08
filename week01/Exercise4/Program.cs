using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Exercise4 Project.");

        /// Ask series of numbers
        List<int> numbers = new List<int>();
        int number = -1;

        /// Instructions
        Console.WriteLine("Enter a lis of numbers, type 0 when finished.");

        while (number != 0)
        {
            /// Ask number
            Console.WriteLine("Enter a number:");
            number = int.Parse(Console.ReadLine());

            /// Add number to list
            if (number != 0)
            {
                numbers.Add(number);
            }         
        }

        /// Sum numbers in list
        int sum = 0;
        foreach (int num in numbers)
        {
            sum = sum + num;
        }

        /// Print sum result
        Console.WriteLine($"The sum is: {sum}");

        /// Calculate average
        double average = 0;
        int countOfNumbers = 0;
        countOfNumbers = numbers.Count();
        average = ((double)sum) / countOfNumbers;

        /// Print average result
        Console.WriteLine($"The average is: {average}");

        /// Get and print largest
        int largest = int.MinValue;
        foreach (int max in numbers)
        {
            if (max > largest)
            {
                largest = max;
            }
        }
        Console.WriteLine($"The largest number is: {largest}");

    }
}