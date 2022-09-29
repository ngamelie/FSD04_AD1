using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day01TextFile
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("What is your name? ");
                string name = Console.ReadLine();
                Console.WriteLine("Enter the number ");
                int number = int.Parse(Console.ReadLine());

                try
                {
                    using (StreamWriter writetext = new StreamWriter("data.txt"))
                    {
                        for (int i = 0; i < number; i++)
                        {
                            writetext.WriteLine(name);
                        }
                    }
                    // Create an instance of StreamReader to read from a file.
                    // The using statement also closes the StreamReader.
                    using (StreamReader sr = new StreamReader("data.txt"))
                    {
                        string line;
                        // Read and display lines from the file until the end of the file is reached. 
                        while ((line = sr.ReadLine()) != null)
                        {
                            Console.WriteLine(line);
                        }
                    }
                }
                catch (Exception e)
                {
                    // Let the user know what went wrong.
                    Console.WriteLine("The file could not be read:");
                    Console.WriteLine(e.Message);
                }
            }

            finally
            {
                Console.WriteLine("Press any key to finish");
                Console.ReadLine();
            }
        }
    }
}
