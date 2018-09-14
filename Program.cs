using System;
using System.IO;

namespace Csharpdoc
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What would you like to name your file:");
            string FileName = Console.ReadLine() + ".txt";
            Console.WriteLine("Okay, {0} it is", FileName);

            Console.WriteLine("What would you like to put into the file:");
            string FileContents = Console.ReadLine();

            var dir = @"c:\users\admin\documents\GitHub\CSharpDocument\";  // folder location
            if (Directory.Exists(dir)) // if it doesn't exist, create
            { 
                Directory.CreateDirectory(dir);

                // use Path.Combine to combine 2 strings to a path
                File.WriteAllText(Path.Combine(dir, FileName), FileContents);
                Console.WriteLine("{0} was saved successfully", FileName);
            }
           
            Console.WriteLine("Press any key to exit.");
            Console.ReadKey();

        }
    }
}
