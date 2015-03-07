using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication1
{
    /// <summary>
    /// lab 3 - convert farenheight to celsus
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            //create variables for celsus and farenheight
            float orgFahrenheit = 32;
            float calcCelsius = 0;
            float calcFahrenheit = 32;

            // get user input in F

            Console.Write("Enter temperature (Fahrenheit): ");
            orgFahrenheit = float.Parse(Console.ReadLine()); 

            // calculate the C temp
            calcCelsius = ((orgFahrenheit-32)/9)*5;

            // calculate the F temo
            calcFahrenheit = ((calcCelsius * 9) / 5) + 32;

            //write out the answers
            Console.WriteLine( orgFahrenheit + " degrees Fahrenheit is "+ calcCelsius +" Celsius");
            Console.WriteLine(calcCelsius+" degrees Celsius is "+calcFahrenheit+" degrees Fahrenheit");

        }
    }
}
