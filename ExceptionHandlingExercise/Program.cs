using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;

namespace ExceptionHandlingExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            // -----------------------------------------------------------------------------
            // First create an char[], it must contain 6 numbers and 3 letters - name it arr
            // Create a list called numbers that will hold integers
            // Create an string variable with an empty string initializer - name it str

            // using a foreach loop, attempt to parse the elements in your char[] with int.Parse()
            // and Exceptions will be thrown 
            // Below we will set this up 
            // ------------------------------------------------------------------------------
            var arr = new char[]
            {
                '4', '9' , '7' , '6' , '3' , '8' , 'j' , 'z' , 'o'
            };

            var numbers = new List<int>();

            var str = "";



            //TODO START HERE:

            // Make a foreach loop to iterate through your character array

            foreach (var character in arr)
            {
                try
                {
                    str = character.ToString();
                    var number = int.Parse(str);
                    numbers.Add(number);
                }
                catch (Exception ex)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine($"ERROR: unable to Parse '{character}'");
                }

            }
            // Now create a try catch
            Console.WriteLine("Welcome to the Word Letter Game!");


            Console.Write("Enter a letter: ");
            var guess = Console.ReadLine()[0];


            var found = false;
            foreach (var character in arr)
            {
                if (guess == character)
                {
                    found = true;
                }
            }

            if (found)
            {
                Console.WriteLine("Congratulations, you guessed correctly!");
            }
            else
            {
                Console.WriteLine("Sorry, that guess is incorrect.");
            }


            // Inside your try block
            // set your string variable to each array element in your char[] to .ToString()
            // Now, using int.Parse, parse your string variable and store in an int variable
            // Then add each int to your list

            // catch your Exception:
            // in the scope of your catch you can use the following, 

            //character will be the name of each item in your collection

            ////Is this needed bellow?

            foreach (var num in numbers)
            {
                Console.WriteLine(num);
            }
        }

    }
}
