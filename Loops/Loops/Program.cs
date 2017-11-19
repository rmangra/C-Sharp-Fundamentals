using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Loops
{
    class Program
    {
        static void Main(string[] args)
        {
            // FOR LOOP

            for (var i = 0; i <= 10; i++)
            {
                if (i % 2 == 0)
                    Console.WriteLine(i);
            }

            for (var i = 10; i >= 0; i--)
            {
                if (i % 2 == 0)
                    Console.WriteLine(i);
            }

            var name = "John Smith";

            // for (var i = 0; i < name.Length; i++)
            // {
            //    Console.WriteLine(name[i]);
            // }

            // FOREACH

            foreach (var character in name)
            {
                Console.WriteLine(character);
            }

            var numbers = new int[] {1, 2, 3, 4};
            foreach (var number in numbers)
            {
                Console.WriteLine(number);
            }

            // WHILE LOOP

            var j = 0;
            while (j <= 10)
            {
                if (j % 2 == 0)
                    Console.WriteLine(j);
                j++;
            }

            while (true)
            {
                Console.Write("Type your name: ");
                var input = Console.ReadLine();

                if (!String.IsNullOrWhiteSpace(input))
                {
                    Console.WriteLine("@Echo: " + input);
                    continue;
                }
                    break;
            }
         
        }
    }
}
