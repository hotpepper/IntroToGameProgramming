using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DieExample
{
    /// <summary>
    /// Demonstrates implementation of a Die class
    /// </summary>
    class Program
    {
        /// <summary>
        /// Tests the Die class
        /// </summary>
        /// <param name="args">command-line args</param>
        static void Main(string[] args)
        {
            //test standard die
            Die standardDie = new Die();
            Console.WriteLine("standard die\n");
            Console.WriteLine("number of sides: " + standardDie.NumSides);
            Console.WriteLine("top side: " + standardDie.TopSide);
            Console.WriteLine("\nRolling...");
            standardDie.Roll();
            Console.WriteLine("top side: " + standardDie.TopSide);
            Console.WriteLine("\nRolling...");
            standardDie.Roll();
            Console.WriteLine("top side: " + standardDie.TopSide);
            Console.WriteLine("\nRolling...");
            standardDie.Roll();
            Console.WriteLine("top side: " + standardDie.TopSide);

            Console.WriteLine();
            //test d20
            Die d20 = new Die(20);
            Console.WriteLine("d20 die\n");
            Console.WriteLine("number of sides: " + d20.NumSides);
            Console.WriteLine("top side: " + d20.TopSide);
            Console.WriteLine("\nRolling...");
            d20.Roll();
            Console.WriteLine("top side: " + d20.TopSide);


        }
    }
}
