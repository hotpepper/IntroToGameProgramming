using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace floatingPointNumbers
{
    /// <summary>
    ///  demonstrates floating point numbers
    /// </summary>
    class Program
    {
        /// <summary>
        /// demonstrates floating point numbers
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            // declares variables
            int score = 1356;
            int totalSecondsPlayed = 10000;

            //claculate and display results
            float pointsPerSecond = (float)score / totalSecondsPlayed;
            Console.WriteLine("Points per second: " + pointsPerSecond);

            Console.WriteLine("");
        }
    }
}
