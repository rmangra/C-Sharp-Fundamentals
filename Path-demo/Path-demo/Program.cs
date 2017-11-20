using System;
using System.IO;

namespace Path_demo
{
    class Program
    {
        static void Main(string[] args)
        {
            var path = @"C:\temp\HelloWorld.sln";

            Console.WriteLine("Extension: " + Path.GetExtension(path));
            Console.WriteLine("File Name: " + Path.GetFileName(path));
            Console.WriteLine("File Name without extension: " + Path.GetFileNameWithoutExtension(path));
            Console.WriteLine("Directory Name: " + Path.GetDirectoryName(path));
        }
    }
}
