using System;

namespace Exercise_Conditionals_42._2
{
    class Program
    {
        // Write a program which takes two numbers from the console 
        // and displays the maximum of the two.

        static void Main(string[] args)
        {
            Console.Write("Enter a number: ");
            var num1 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter a second number: ");
            var num2 = Convert.ToInt32(Console.ReadLine());

            if (num1 > num2)
            {
                Console.WriteLine("The max value is " + num1);
            }
            else
            {
                Console.WriteLine("The max value is " + num2);
            }
        }
    }
}