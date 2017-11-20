using System;
using System.Collections.Generic;

namespace Exercise_67._2_Working_with_Text
{
    class Program
    {
        // Write a program and ask the user to enter a few numbers separated by a hyphen. If the user simply 
        // presses Enter without supplying an input, exit immediately; otherwise, check to see if there are 
        // any duplicates. If so, display "Duplicate" on the console.

        static void Main(string[] args)
        {
            Console.Write("Please enter a series of numbers (1-2-3-4): ");
            var input = Console.ReadLine();

            if (String.IsNullOrWhiteSpace(input))
                return;

            var numbers = new List<int>();
            foreach (var number in input.Split('-'))
                numbers.Add(Convert.ToInt32(number));

            var uniques = new List<int>();
            var hasDuplicates = false;
            foreach (var number in numbers)
            {
                if (!uniques.Contains(number))
                    uniques.Add(number);
                else
                {
                    hasDuplicates = true;
                    break;
                }
            }

            if (hasDuplicates)
                Console.WriteLine("Has duplicate entries");
            else
                Console.WriteLine("No duplicates");
        }
    }
}
