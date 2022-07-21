//Let’s create another console application for more practice.

//This application asks the user to input a string in the first line like “Enter a string here: ”.

//In the Second Line, it should ask for the character to search in the string which you have entered in the first line like “Enter the character to search: ”

//On the third line, it should write the index of the first occurrence of the searched character from the string.

//Now on concatenation...

//It should then ask to enter the first name and once the name is written and the enter button is pressed, it should ask to enter the last name.

//It should then show your full name printed in a single line like in my case the output will be "Denis Panjuta". Output can be different in your case. Try to store the full name in a variable, before displaying it.

using System;

namespace Challenge2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a string here: ");
            string input = Console.ReadLine(); //read the input string first

            Console.Write("Enter a character to search: ");
            char searchInput = Console.ReadLine()[0];//read the 1st instance of the
            //character we'll search in the input

            int searchIndex = input.IndexOf(searchInput);
          
            Console.WriteLine("The index of character {0} in the string is {1}", searchInput, searchIndex);

            Console.Write("Please enter your first name: ");
            string firstName = Console.ReadLine();

            Console.Write("Please enter your last name: ");
            string lastName = Console.ReadLine();

            string fullName = string.Concat(firstName + " " + lastName);
            Console.WriteLine("Your full name is {0}", fullName);

            Console.Read();

        }
    }
}
