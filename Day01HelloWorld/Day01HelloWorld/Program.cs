﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day01HelloWorld
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                // this method get boolean to decide
                Console.WriteLine("What is your name? ");
                string name = Console.ReadLine();
                Console.WriteLine("What is your age? ");
                string ageStr = Console.ReadLine();

                if (!int.TryParse(ageStr, out int age))
                {
                    Console.WriteLine("Invalid numerical input");
                    return;
                }

                if (name.ToLower() == "santa")
                {
                    Console.WriteLine("SANTA!!! Can't believe it's you");
                }
                else
                {
                    Console.WriteLine($"Hello {name}! You are {age} y/o!");
                    Console.WriteLine("Hello {0}! You are {1} y/o. Nice to meet you {0}!", name, age);
                }
            }
            finally
            {
                Console.ReadLine();
            }
                      

            // this method get exception
            //Console.WriteLine("What is your name? ");
            //string name = Console.ReadLine();
            //Console.WriteLine("What is your age? ");
            //try
            //{
            //    string ageStr = Console.ReadLine();
            //    int age = int.Parse(ageStr);
            //    //Console.WriteLine("Hello " + name + "! You are " + age + " y/o!");
            //    Console.WriteLine($"Hello {name}! You are {age} y/o!");
            //} catch(FormatException ex)
            //{
            //     Console.WriteLine("Invalid numerical input");
            //} 
            
        }
    }
}
