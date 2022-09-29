using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day01PeopleListInFile
{
    internal class Person
    {
        private string Name;
        private int Age;
        private string City;

        public Person()
        {

        }
        public Person(string name, int age, string city)
        {
            this.Name = name;
            this.Age = age;
            this.City  = city;           
        }        

        public string PersonName
        {
            get { return Name; }
            set {
                if (value.Length <2 || value.Length > 100 || value.Contains(";"))
                {
                    ArgumentException argumentException = new ArgumentException("Name should be 2-100 characters long, not containing semicolons");
                    throw argumentException;                       
                }
                Name = value;  
            }
        }

        public int PersonAge
        {
            get { return Age; }
            set
            {
                if (value < 0 || value > 150)
                {
                    ArgumentException argumentException = new ArgumentException("Age should be 2- 150");
                    throw argumentException;
                }
                Age = value;
            }
        }

        public string PersonCity
        {
            get { return City; }
            set
            {
                if (value.Length < 2 || value.Length > 100 || value.Contains(";"))
                {
                    ArgumentException argumentException = new ArgumentException("City should be 2-100 characters long, not containing semicolons");
                    throw argumentException;
                }
                City = value;
            }
        }

        public override string ToString()
        {
            return base.ToString();
        }










    }
}
