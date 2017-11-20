using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_55._1_Arrays_and_Lists
{
    class Program
    {
        // Write a program and continuously ask the user to enter different names, until the user presses
        // Enter(without supplying a name). Depending on the number of names provided, display a message 
        // based on the following pattern:
        //
        //  - If no one likes your post, it doesn't display anything.
        //  - If only one person likes your post, it displays: [Friend's Name] likes your post.
        //  - If two people like your post, it displays: [Friend 1] and [Friend 2] like your post.
        //  - If more than two people like your post, it displays: [Friend 1], [Friend 2] and
        //    [Number of Other People] others like your post..

        static void Main(string[] args)
        {
            var names = new List<string>();

            while (true)
            {
                Console.Write("Please enter a name (or hit ENTER to quit): ");

                var name = Console.ReadLine();
                if (name == "")
                    break;
                names.Add(name);
            }
            
        }
    }
}
