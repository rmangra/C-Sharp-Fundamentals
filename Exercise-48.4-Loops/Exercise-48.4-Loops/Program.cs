using System;

namespace Exercise_48._4_Loops
{
    class Program
    {
        // Write a program that picks a random number between 1 and 10. 
        // Give the user 4 chances to guess the number. If the user guesses the number, display “You won";
        // otherwise, display “You lost".
        
        static void Main(string[] args)
        {
            var number = new Random().Next(1, 10);
            const int chances = 4;
            for (var i = chances; i > 0; i--)
            {
                Console.Write("You have " + i + " chance(s) to guess the secret number (between 1 to 10): ");
                var guess = Convert.ToInt32(Console.ReadLine());
                
                if (guess == number)
                {
                    Console.WriteLine("You won!");
                    Console.WriteLine("The secret number is " + number);
                    return;
                }
            }
            Console.WriteLine("You lost!");
            Console.WriteLine("The secret number is " + number);
        }
    }
}