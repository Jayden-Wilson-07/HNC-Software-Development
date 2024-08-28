/*
 * Lesson 3 Class
 * Jayden Wilson
 * 28 Aug 2024
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lessons
{
    public static class Lesson3
    {
        /// <summary>
        /// Allows user to enter their name
        /// and display name to console
        /// </summary>
        public static void Task1()
        {
            //Asks and gets name from user
            Console.Write("What is your name? ");
            string name = Console.ReadLine();

            //Outputs users name
            Console.WriteLine(name);
        }

        /// <summary>
        /// Allows user to enter their first 
        /// and last name and combines and displays 
        /// as one string of text
        /// </summary>
        public static void Task2()
        {
            //Asks and gets first name from user
            Console.Write("What is your first name? ");
            string firstName = Console.ReadLine();

            //Asks and gets last name from user
            Console.Write("What is your last name? ");
            string lastName = Console.ReadLine();

            //Outputs users full name to Console
            Console.WriteLine($"Hello {firstName} {lastName}");
        }

        /// <summary>
        /// Allows user to enter their first 
        /// and last name and combines and displays 
        /// as one string of text
        /// </summary>
        public static void Task3()
        {
            string message = "Hello World";

            //Checks to see if the word "World" exists in the message
            Console.WriteLine(message.Contains("World"));

            //Gets first index of 'o'
            Console.WriteLine(message.IndexOf('o'));

            //Outputs the length of the message
            Console.WriteLine(message.Length);

            //Replaces the word "Hello" with "Hi"
            Console.WriteLine(message.Replace("Hello", "Hi"));

            //Removes whitespace from the start and end of the message
            Console.WriteLine(message.Trim());
        }

        /// <summary>
        /// Allows user to enter values to 
        /// create their own story
        /// </summary>
        public static void Task4()
        {
            //Asks for the first name of user
            Console.Write("What is your first name? ");
            string firstName = Console.ReadLine();

            //Uppercase the first letter and makes the rest lowercase
            firstName = firstName.Substring(0, 1).ToUpper() + firstName.Substring(1).ToLower();



            //Asks for the users favorite colour
            Console.Write("What is your favorite colour? ");
            string favoriteColour = Console.ReadLine();

            //Uppercase the first letter and makes the rest lowercase
            favoriteColour = favoriteColour.Substring(0, 1).ToUpper() + favoriteColour.Substring(1).ToLower();



            //Asks for the users favorite food
            Console.Write("What is your favorite food? ");
            string favoriteFood = Console.ReadLine();

            //lowercase all letters
            favoriteFood = favoriteFood.ToLower();



            //Outputs small story
            Console.WriteLine($"{firstName} ate a {favoriteColour} {favoriteFood}");

        }

        /// <summary>
        /// Allows user to enter their first 
        /// and last name and combines and displays 
        /// as one string of text and correctly changes 
        /// the case of each word
        /// </summary>
        public static void Task5()
        {
            //Asks for the first name of user
            Console.Write("What is your first name? ");
            string firstName = Console.ReadLine();

            //Uppercase the first letter and makes the rest lowercase
            firstName = firstName.Substring(0, 1).ToUpper() + firstName.Substring(1).ToLower();

            //Asks for last name of user
            Console.Write("What is your last name? ");
            string lastName = Console.ReadLine();

            //Uppercase the first letter and makes the rest lowercase
            lastName = lastName.Substring(0, 1).ToUpper() + lastName.Substring(1).ToLower();

            //Outputs the edited strings as one complete string
            Console.WriteLine($"Hello {firstName} {lastName}");
        }

        /// <summary>
        /// Allows user to enter their first 
        /// and last name and combines and displays 
        /// as one string of text and correctly changes 
        /// the case of each word
        /// </summary>
        public static void Task6()
        {
            //variables for amount of parts to the postcode and postcode 
            int postCodeParts = 4;
            string postcode = null;

            //Loop to ask user for the specific part of the postcode
            for (int i = 0; i < postCodeParts; i++)
            {
                //Asks and gets user input 
                Console.Write($"Postcode part {i + 1}? ");
                postcode += Console.ReadLine().ToUpper().ToString();

                //A check so at the second iteration a space is added in the postcode
                if (i == 1)
                {
                    postcode = postcode + " ";
                }
            }

            //outputs postcode to console
            Console.WriteLine(postcode);
        }
    }
}
