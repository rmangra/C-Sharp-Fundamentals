using System;

namespace Exercise_55._2_Arrays_and_Lists
{
    class Program
    {
        // Write a program and ask the user to enter their name. 
        // Use an array to reverse the name and then store the result in a new string. 
        // Display the reversed name on the console.

        static void Main(string[] args)
        {
            Console.Write("Please enter your name: ");
            var name = Console.ReadLine().ToCharArray();

            Array.Reverse(name);

            var reversed = new string(name);
            Console.WriteLine("Reversed name: " + reversed);
        }
    }
}
