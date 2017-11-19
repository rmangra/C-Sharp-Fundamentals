using System;

namespace Exercise_Conditionals_42._1
{
    class Program
    {
        // Write a program and ask the user to enter a number between 1 to 10. If the user enters 
        // a valid number, display "Valid" on the console. Otherwise, display "Invalid".

        static void Main(string[] args)
        {
            Console.Write("Please enter a number between 1 to 10: ");
            var number = Convert.ToInt32(Console.ReadLine());
            if (number >= 1 && number <= 10)
            {
                Console.WriteLine("Valid");
            }
            else
            {
                Console.WriteLine("Invalid");
            }
        }
    }
}