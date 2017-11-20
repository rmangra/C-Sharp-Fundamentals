using System;
using System.Collections.Generic;

namespace Exercise_55._3_Arrays_and_Lists
{
    // Write a program and ask the user to enter 5 numbers. If a number has been previously entered,
    // display an error message and ask the user to re-try. Once the user successfully enters 5 unique numbers,
    // sort them and display the result on the console.

    class Program
    {
        static void Main(string[] args)
        {
            var numbers = new List<int>();
            const int limit = 5;
            
            while (numbers.Count < limit)
            {
                Console.Write("Enter " + limit + " different numbers (one per line): ");
                var number = Convert.ToInt32(Console.ReadLine());
                if (numbers.Contains(number))
                {
                    Console.WriteLine("You've previously entered " + number);
                    continue;
                }

                numbers.Add(number);
            }

            numbers.Sort();

            foreach (var number in numbers)
                Console.WriteLine(number);
        }
    }
}
