using System;

namespace Exercise_67._3_Working_with_Text
{
    class Program
    {
        // Write a program and ask the user to enter a time value in the 24-hour time format (e.g. 19:00).
        // A valid time should be between 00:00 and 23:59. If the time is valid, display "Ok"; otherwise, 
        // display "Invalid Time". If the user doesn't provide any values, consider it as invalid time.

        static void Main(string[] args)
        {
            Console.Write("Please enter the time (MM:HH): ");
            var input = Console.ReadLine();

            if (String.IsNullOrWhiteSpace(input))
            {
                Console.WriteLine("Invalid Time");
                return;
            }

            var components = input.Split(':');
            if (components.Length != 2)
            {
                Console.WriteLine("Invalid Time");
                return;
            }

            var hour = Convert.ToInt32(components[0]);
            var minute = Convert.ToInt32(components[1]);

            if (hour >= 0 && hour <= 23 && minute >= 0 && minute <= 59)
                Console.WriteLine("Ok, valid time");
            else
                Console.WriteLine("Invalid Time");
        }
    }
}
