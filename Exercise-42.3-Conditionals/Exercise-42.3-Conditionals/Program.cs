using System;

namespace Exercise_42._3_Conditionals
{
    class Program
    {
        // Write a program and ask the user to enter the width and height of an image.
        // Then tell if the image is landscape or portrait.

        static void Main(string[] args)
        {
            Console.Write("Please enter image width: ");
            var width = Convert.ToInt32(Console.ReadLine());

            Console.Write("Please enter image height: ");
            var height = Convert.ToInt32(Console.ReadLine());

            if (width > height)
            {
                Console.WriteLine("The image is in landscape orientation.");
            }
            else
            {
                Console.WriteLine("The image is in portrait orientation.");
            }
        }
    }
}
