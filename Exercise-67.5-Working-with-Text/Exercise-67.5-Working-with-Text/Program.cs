using System;
using System.Collections.Generic;

namespace Exercise_67._5_Working_with_Text
{
    class Program
    {
        // Write a program and ask the user to enter an English word. Count the number of vowels
        // (a, e, o, u, i) in the word. So, if the user enters "inadequate", the program should 
        // display 6 on the console.

        static void Main(string[] args)
        {
            Console.Write("Please enter a word: ");
            
            var input = Console.ReadLine().ToLower();

            var vowels = new List<char>(new char[] { 'a', 'e', 'o', 'u', 'i' });
            var vowelsCount = 0;
            foreach (var character in input)
            {
                if (vowels.Contains(character))
                    vowelsCount++;
            }

            Console.WriteLine("Vowels in the word: " + vowelsCount);
        }
    }
}
