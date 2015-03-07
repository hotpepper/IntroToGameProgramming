using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication1
{
    /// <summary>
    /// lab 2
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            //mainmethod
            int age = 31;

            //write out age

            Console.WriteLine("My age is :" + age);

            //constant max score
            const int MAX_SCORE = 100;
            int score = 47;
            float percent = ((float)score/MAX_SCORE)*100;
            Console.WriteLine("Percent score: "+ percent +"%");

        }
    }
}
