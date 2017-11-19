using System;

namespace Exercise_48._2_Loops
{
    class Program
    {
        // Write a program and continuously ask the user to enter a number or "ok" to exit.
        // Calculate the sum of all the previously entered numbers and display it on the console.

        static void Main(string[] args)
        {
            var sum = 0;
            while (true)
            {
                Console.Write("Please enter a number (or 'ok' to exit): ");
                var input = Console.ReadLine();

                if (input.ToLower() == "ok")
                    break;

                sum += Convert.ToInt32(input);
            }
            Console.WriteLine("The sum of all the numbers entered is: " + sum);
        }
    }
}
