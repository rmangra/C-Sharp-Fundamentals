﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_55._5_Arrays_and_Lists
{
    class Program
    {
        // Write a program and ask the user to supply a list of comma separated numbers(e.g 5, 1, 9, 2, 10). If the list is 
        // empty or includes less than 5 numbers, display "Invalid List" and ask the user to re-try; otherwise, display 
        // the 3 smallest numbers in the list.

        static void Main(string[] args)
        {
            string[] items;
            while (true)
            {
                Console.Write("Please enter a list of 5 or more comma-separated numbers: ");
                var input = Console.ReadLine();

                if (!String.IsNullOrWhiteSpace(input))
                {
                   items = input.Split(',');
                    if (items.Length >= 5)
                        break;
                }

                Console.WriteLine("Invalid List");
            }
        }
    }
}
