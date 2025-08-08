using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace activity4class_TemperatureConverter
{
    internal class Program
    {
        static void Main(string[] args)
        {

            // Get temperature input in Celsius
            Console.Write("Enter temperature in Celsius: ");
            string input = Console.ReadLine();

            // Validate input
            if (float.TryParse(input, out float celsius))
            {
                if (celsius < -100 || celsius > 100)
                {
                    Console.WriteLine("Error: Temperature must be between -100 and 100 degrees Celsius.");
                    return;
                }
            }
            else
            {
                Console.WriteLine("Error: Please enter a valid number for temperature.");
                return;
            }
            // Convert Celsius to Fahrenheit
            float fahrenheit = (celsius * 9 / 5) + 32;

            // Display the result
            Console.WriteLine($"Temperature in Fahrenheit: {fahrenheit}");



        }
    }
}
