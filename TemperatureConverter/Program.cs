using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TemperatureConverter
{
   public static class TemperatureConverter 
    {
        public static double CelsiusToFahrenheit(string tempCelsius)
        {
            // convert argument to double for calculations
            Double.TryParse(tempCelsius, out double celsius);

            // calculate Celsius to Farenheit
            double fahrenheit = (celsius * 9 / 5) + 32;
           
            return fahrenheit;
        }

        public static double FarenheitToCelsius(string tempFahrenheit)
        {
            // convert argument to double for calculations
            Double.TryParse(tempFahrenheit, out double fahrenheit);

            // calculate Fahrenheit to Celsius
            double celsius = (fahrenheit - 32) * 5 / 9;

            return celsius;
        }
    }

    class TestTemperatureConverter
    {
        static void Main()
        {
            Console.WriteLine("Welcome to the Temperature Converter App!");
            Console.WriteLine("Enter 1 to convert Fahrenheit to Celsuis.");
            Console.WriteLine("Enter 2 to convert Celsius to Fahreneheit.");

            string input = Console.ReadLine();
            double F, C = 0;

            switch (input)
            {
                case "1":
                    Console.WriteLine("Please enter the Fahrenheit Temperature");
                    C = TemperatureConverter.FarenheitToCelsius(Console.ReadLine());
                    Console.WriteLine("Temperature in Celsius: {0}", Math.Floor(C));
                    break;
                case "2":
                    Console.WriteLine("Please enter the Celsius Temperature");
                    F = TemperatureConverter.CelsiusToFahrenheit(Console.ReadLine());
                    Console.WriteLine("Temperature in Fahrenheit: {0}", Math.Floor(F));
                    break;
                default:
                    Console.WriteLine("Please enter 1 or 2 to begin the program.");
                    if (Console.ReadLine() == "1")
                        goto case "1";
                    else if (Console.ReadLine() == "2")
                        goto case "2";
                    break;
            }                                     
        }
    }
}
