using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_55._4_Arrays_and_Lists
{
    // Write a program and ask the user to continuously enter a number or type "Quit" to exit.
    // The list of numbers may include duplicates. Display the unique numbers that the user has entered.

    class Program
    {
        static void Main(string[] args)
        {
            var numbers = new List<int>();

            while (true)
            {
                Console.Write("Enter a number (or 'Quit' to exit): ");
                var input = Console.ReadLine();

                if (input.ToLower() == "quit")
                    break;

                numbers.Add(Convert.ToInt32(input));
            }
        }
    }
}
