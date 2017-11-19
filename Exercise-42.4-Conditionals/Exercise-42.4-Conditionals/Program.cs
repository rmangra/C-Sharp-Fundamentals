using System;

namespace Exercise_42._4_Conditionals
{
    class Program
    {
        // Your job is to write a program for a speed camera. 
        // Write a program that asks the user to enter the speed limit. Once set, the program asks for the speed of a car.
        // If the user enters a value less than the speed limit, program should display Ok on the console.
        // If the value is above the speed limit, the program should calculate the number of demerit points.
        // For every 5km/hr above the speed limit, 1 demerit points should be incurred and displayed on the console.
        // If the number of demerit points is above 12, the program should display License Suspended.

        static void Main(string[] args)
        {
            Console.Write("Enter the speed limit: ");
            var speedLimit = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter the speed of the car? ");
            var carSpeed = Convert.ToInt32(Console.ReadLine());

            if (carSpeed <= speedLimit)
            {
               Console.WriteLine("OK"); 
            }
            else
            {
                const int kmPerDemeritPoint = 5;
                var demeritPoints = (carSpeed - speedLimit) / kmPerDemeritPoint;
                
                if (demeritPoints > 12)
                    Console.WriteLine("License Suspended");
                else
                    Console.WriteLine("Demerit points: " + demeritPoints);
            }
        }
    }
}
