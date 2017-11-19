using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Exercise_48._1_Loops
{
    class Program
    {
        // Write a program to count how many numbers between 1 and 100 are divisible by 3 with no remainder.
        // Display the count on the console.
        static void Main(string[] args)
        {
            var count = 0;
            for (var i = 0; i <= 100; i++)
            {
                if (i % 3 == 0)
                    count++;
            }
            Console.WriteLine(count);
        }
    }
}
