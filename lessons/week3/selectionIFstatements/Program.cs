using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace IfStatements
{
    /// <summary>
    ///  Demonstrates if statements
    /// </summary>
    class Program
    {
        /// <summary>
        /// Demonstrates various forms of if statement
        /// </summary>
        /// <param name="args">command-line args</param>
        static void Main(string[] args)
        {
            // ask for and get user answer
            Console.Write("Pick up the shinny thing? (y/n): ");
            char answer = Console.ReadLine()[0];

            // print appropriate message
            if (answer == 'y' ||
                answer == 'Y')
            {
                Console.WriteLine("\nyou have the shinny object");
            }
            else if (answer == 'n' ||
                answer == 'N')
            {
                Console.WriteLine("\nyou dont have the shinny object");
            }
            else
            {
                Console.WriteLine("\nyou are a n00b");
            }
            Console.WriteLine("\n"+answer);

        }
    }
}
