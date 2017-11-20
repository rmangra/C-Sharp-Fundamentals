using System;

namespace Exercise_67._4_Working_with_Text
{
    class Program
    {
        // Write a program and ask the user to enter a few words separated by a space. Use the words to 
        // create a variable name with PascalCase convention. For example, if the user types: 
        // "number of students", display "NumberOfStudents". Make sure the program is not dependent on 
        // the casing of the input. So if the input is "NUMBER OF STUDENTS", it should still display 
        // "NumberOfStudents". If the user doesn't supply any words, display "Error".

        static void Main(string[] args)
        {
            Console.Write("Please enter a two or more words: ");
            var input = Console.ReadLine();

            if (String.IsNullOrWhiteSpace(input))
            {
                Console.WriteLine("Error");
                return;
            }

            var variableName = "";
            foreach (var word in input.Split(' '))
            {
                var wordWithPascalCase = char.ToUpper(word[0]) + word.ToLower().Substring(1);
                variableName += wordWithPascalCase;
            }

            Console.WriteLine(variableName);
        }
    }
}
