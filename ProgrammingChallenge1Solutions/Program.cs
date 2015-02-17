using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgrammingChallenge1Solutions
{
    /// <summary>
    /// Examples of the different solutions to Challenge 1
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            //Example 1
            string[] name = { "K", "e", "v", "i", "n" };

            Console.WriteLine("Example 1");

            for (int counter = 0; counter <= 4; counter++)
            {
                Console.WriteLine(name[counter]);
            }
            for (int counter = name.Length - 1; counter >= 0; counter--)
            {
                Console.WriteLine(name[counter]);
            }

            Console.WriteLine("\n");

            //Example two
            Console.WriteLine("Example 2");
            Console.WriteLine("K");
            Console.WriteLine("e");
            Console.WriteLine("v");
            Console.WriteLine("i");
            Console.WriteLine("n");
            Console.WriteLine("n");
            Console.WriteLine("i");
            Console.WriteLine("v");
            Console.WriteLine("e");
            Console.WriteLine("K");

            Console.WriteLine("\n");

            //Example 3
            string[] nameForwards = { "K", "e", "v", "i", "n" };
            string[] nameBackwards = { "n", "i", "v", "e", "K" };

            Console.WriteLine("Example 3");
            for (int counter = 0; counter <= nameForwards.Length - 1; counter++)
                Console.WriteLine(nameForwards[counter]);
            for (int counter = name.Length - 1; counter >= 0; counter--)
                Console.WriteLine(nameBackwards[counter]);

            Console.WriteLine("\n");

            //Example 4
            string[] nameRight = { "K", "e", "v", "i", "n" };
            string[] nameWrong = { "n", "i", "v", "e", "K" };

            Console.WriteLine("Example 4");
            foreach (string letter in nameRight)
                Console.WriteLine(letter);
            foreach (string letter in nameWrong)
                Console.WriteLine(letter);

            Console.WriteLine("\n");

            //Example 5
            Console.WriteLine("Example 5");
            string myName = "Kevin";
            for (int counter = 0; counter <= myName.Length - 1; counter++)
                Console.WriteLine(myName[counter]);
            for (int counter = myName.Length - 1; counter >= 0; counter--)
                Console.WriteLine(myName[counter]);

            Console.WriteLine("\nForeach demo with Char");
            foreach (char letter in myName)
                Console.WriteLine(letter);



            //Wait for user input
            Console.ReadKey();
        }
    }
}
