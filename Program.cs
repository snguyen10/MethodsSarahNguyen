//
/*
Author: Sarah Nguyen
Date: 02/06/2020
Topic: Methods 
*/
using System;

namespace MethodsSarahNguyen
{
    class Program
    {
        static void Main(string[] args)
        {
            // Ask user for input
            Console.Write("Please enter your name:");
            // Validate Errors 
            try
            {
                // Read input .
                string name = Console.ReadLine();

                // Call method user input
                UserName(name);

            }
            catch
            {
                // Wrong input message
                Console.WriteLine("Invalid Input!");
            }
        }
        // Customer method
        private static string UserName (string input_name)
        {
            Console.WriteLine("");

            // Hello and UserName Message
            Console.Write("Hello " + input_name + "!");
            // Return value
            return input_name;
        }
    }
}

