using System;

namespace Exercise_48._3_Loops
{
    class Program
    {
        // Write a program which takes a single argument from the console, computes the factorial and prints the 
        // value on the console. For example, if the user enters 5, the program should calculate 5 x 4 x 3 x 2 x 1 
        // and display it as 5! = 120.
        static void Main(string[] args)
        {
            Console.Write("Please enter a number: ");
            var number = Convert.ToInt32(Console.ReadLine());

            var factorial = 1;
            for (var i = 1; i <= number; i++)
                factorial = factorial * i;

            Console.WriteLine("{0}! = {1}", number, factorial);
        }
    }
}
