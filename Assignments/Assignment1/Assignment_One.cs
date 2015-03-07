using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication1
{
    /// <summary>
    /// assignment 1
    /// </summary>
    class Program
    {
        /// <summary>
        /// assignment 1
        /// </summary>
        /// <param name="args">command-line args</param>
        static void Main(string[] args)
        {
            //welcome message

            Console.WriteLine("Welcome, this program will calculate your average gold-collecting performance.");


            //get user input for their progress 
            Console.WriteLine();
            Console.Write("Input the amount of gold you have collected: ");

            //read in user input and assign the user input to appropriate var type
            int goldCollected = int.Parse(Console.ReadLine());

            // Prompt the user for the total number of hours they've played the game
            Console.WriteLine();
            Console.Write("Input the number of hours you have played: ");

            //Read in the total number of hours played and put the value into a variable of the appropriate type. 
            float hoursPlayed= float.Parse(Console.ReadLine());

            
            //Convert the hours to minutes and put the result into a variable of the appropriate type
                // define constant value for hrs to min
                const int MIN_IN_HOUR = 60;

                //calculate minutes played
                float minutesPlayed = hoursPlayed * MIN_IN_HOUR;
            

            //Calculate the gold per minute statistic and put the result into a variable of the appropriate type
            float goldPerMin = goldCollected / minutesPlayed;
            
            //Print out the gold, hours played, and gold per minute statistics 
            Console.WriteLine();
            Console.WriteLine("Gold collected: " + goldCollected);
            Console.WriteLine("Hours played: " + hoursPlayed);
            Console.WriteLine("Gold per minute of play: " + goldPerMin);
            Console.WriteLine();
            
        }
    }
}
