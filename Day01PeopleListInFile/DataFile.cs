using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Day01PeopleListInFile
{
    class DataFile
    {
        public static List<Person> ReadAllPeopleFromFile()
        {
            List<Person> lstperson = new List<Person>();
            try
            {
                if (File.Exists("people.txt"))
                {
                    using (StreamReader sr = new StreamReader("people.txt"))
                    {
                        string line;
                        // Read and display lines from the file until the end of the file is reached. 
                        while ((line = sr.ReadLine()) != null)
                        {
                            string[] substrings = line.Split(';');
                            Person p = new Person(substrings[0], Int32.Parse(substrings[1]), substrings[2]);
                            lstperson.Add(p);
                        }
                    }
                }
                else
                {
                    //It will create the file if it doesn't exist 
                    using (StreamWriter w = File.AppendText("people.txt")) ;
                }

                
            }
            catch (Exception e)
            {
                // Let the user know what went wrong.
                Console.WriteLine("The file could not be read:");
                Console.WriteLine(e.Message);
            }
            return lstperson;
        }

        public static void SaveAllPeopleToFile(List<Person> lstperson)
        {
            try
            {
                using (StreamWriter writetext = new StreamWriter("people.txt"))
                {
                    foreach (var person in lstperson)
                    {
                        writetext.WriteLine($"{person.PersonName};{person.PersonAge};{person.PersonCity}");
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

        
    }
}
