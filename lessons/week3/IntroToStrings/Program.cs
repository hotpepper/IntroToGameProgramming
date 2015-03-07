using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace IntroToStrings
{
    /// <summary>
    /// Demonstrates string basics
    /// </summary>
    class Program
    {
        /// <summary>
        /// Demonstrates string basics
        /// </summary>
        /// <param name="args">command-line args</param>
        static void Main(string[] args)
        {
            //promt for and read in gamer tag
            Console.Write("Enter gamer tag: ");
            string gamertag = Console.ReadLine();

            //promt for and read in level 
            Console.Write("Enter level: ");
            int level = int.Parse(Console.ReadLine());

            //extract the 1st character of gamertag
            char firstGamertagCharacter = gamertag[0];

            // print out values 
            Console.WriteLine();
            Console.WriteLine("Gamertag: " + gamertag);
            Console.WriteLine("Level: " + level);
            Console.WriteLine("First gamertag Character: " + firstGamertagCharacter);

            Console.WriteLine();
        }
    }
}
