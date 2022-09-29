using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Day01PeopleListInFile
{
    internal class Program
    {
        
        static void Main(string[] args)
        {
            try
            {
                List<Person> listperson = DataFile.ReadAllPeopleFromFile(); // read data to list
                int option; //option pour choisir le menu
                string confirm = string.Empty;
                string subconfirm = string.Empty;

                do
                {
                    // affichage du menu
                    option = GetMenu();
                    Console.Clear();

                    switch (option)
                    {
                        case 1:  // Add person info;                        

                            Person newper = AddNewPerson();
                            listperson.Add(newper);
                            break;

                        case 2: // List persons info

                            ListAllPersons(listperson);
                            break;

                        case 3: // Find and list a person by name

                            FindByName(listperson);
                            break;

                        case 4:  // Find and list persons younger than age                            
                            
                            FindYounger(listperson);
                            break;
                        
                        case 5:  // Exit

                            DataFile.SaveAllPeopleToFile(listperson); // save data to file
                            Environment.Exit(0);
                            break;
                    }

                    Console.Write("Press y or Y to continue: ");
                    confirm = Console.ReadLine().ToString();
                    Console.Clear();

                } while (confirm == "y" || confirm == "Y");
            }

            finally
            {
                Console.WriteLine("Press any key to finish");
                Console.ReadLine();
            }

        }

        static int GetMenu()
        {
            Console.WriteLine("======================================================");
            Console.WriteLine("\t\t\t MAIN MENU");
            Console.WriteLine("======================================================");
            Console.WriteLine("1. Add person info");
            Console.WriteLine("2. List persons info");
            Console.WriteLine("3. Find a person by name");
            Console.WriteLine("4. Find all persons younger than age");
            Console.WriteLine("5. Exit");
            Console.WriteLine("Select an option (1) to (5):");
            int option = 0;
            try
            {
                option = Convert.ToInt16(Console.ReadLine());
                
                while (option != 1 && option != 2 && option != 3 && option != 4 && option != 5)
                {
                    Console.WriteLine("Please, Select an option (1) to (5):");
                    option = Convert.ToInt16(Console.ReadLine());
                }
            }
            catch (FormatException ex)
            {
                Console.WriteLine("Invalid numerical input");
            }
            
            return option;
        }

        private static Person AddNewPerson()
        {
            Console.WriteLine("------------------------------------------------------");
            Console.WriteLine("\tAdding a person");
            Console.WriteLine("------------------------------------------------------");

            Person newper = new Person();
            Console.WriteLine("Enter name: ");
            newper.PersonName = Console.ReadLine();
            Console.WriteLine("Enter age: ");
            newper.PersonAge = Convert.ToInt16(Console.ReadLine());
            Console.WriteLine("Enter city: ");
            newper.PersonCity = Console.ReadLine();
            
            return newper;
        }

        private static void ListAllPersons(List<Person> lstperson)
        {
            Console.WriteLine("------------------------------------------------------");
            Console.WriteLine("Listing all persons");
            Console.WriteLine("------------------------------------------------------");

            foreach (var person in lstperson)
            {
                Console.WriteLine($"{person.PersonName} is {person.PersonAge} from {person.PersonCity}");
            }            
        }

        private static void FindByName(List<Person> lstperson)
        {
            Console.WriteLine("------------------------------------------------------");
            Console.WriteLine("Find a person by name");
            Console.WriteLine("------------------------------------------------------");

            Console.WriteLine("Enter partial person name: ");
            string str = Console.ReadLine();

            Console.WriteLine("Matches found: ");

            foreach (var person in lstperson)
            {
                if (person.PersonName.Contains(str))
                    Console.WriteLine($"{person.PersonName} is {person.PersonAge} from {person.PersonCity}");
            }
        }

        private static void FindYounger(List<Person> lstperson)
        {
            Console.WriteLine("------------------------------------------------------");
            Console.WriteLine("Find all persons younger than age");
            Console.WriteLine("------------------------------------------------------");

            Console.WriteLine("Enter maximum age:");
            int age = Convert.ToInt16(Console.ReadLine());

            Console.WriteLine("Matches found: ");

            foreach (var person in lstperson)
            {
                if (person.PersonAge <= age)
                    Console.WriteLine($"{person.PersonName} is {person.PersonAge} from {person.PersonCity}");
            }
        }
    }
}
