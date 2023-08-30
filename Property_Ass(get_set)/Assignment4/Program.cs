using System;

namespace Assignment4
{
    // Temperature Converter with Properties

    internal class TemperatureConverter
    {
        private double celsius;
        private double fahrenheit;

        public double Celsius
        {
            get { return celsius; }
            set
            {
                celsius = value;
                fahrenheit = CelsiusToFahrenheit(value);
            }
        }

        public double Fahrenheit
        {
            get { return fahrenheit; }
            set
            {
                fahrenheit = value;
                celsius = FahrenheitToCelsius(value);
            }
        }

        public TemperatureConverter(double celsius)
        {
            Celsius = celsius;
        }

        public static double CelsiusToFahrenheit(double celsius)
        {
            return (celsius * 9 / 5) + 32;
        }

        public static double FahrenheitToCelsius(double fahrenheit)
        {
            return (fahrenheit - 32) * 5 / 9;
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            TemperatureConverter converter = new TemperatureConverter(25);

            Console.WriteLine($"Celsius: {converter.Celsius} Fahrenheit: {converter.Fahrenheit}");

            converter.Fahrenheit =46;
            Console.WriteLine($"Celsius: {converter.Celsius}, Fahrenheit: {converter.Fahrenheit}");

            converter.Celsius = 4;
            Console.WriteLine($"Celsius: {converter.Celsius}, Fahrenheit: {converter.Fahrenheit}");
            Console.ReadKey();
        }
    }
}
