using System;

namespace OptionalParamsAndNamedArguments
{
    class Program
    {
        static void CheckTemperature(double temp, double tooHigh = 99.5, double tooLow = 96.5)
        {
            if (temp < tooHigh && temp > tooLow) Console.WriteLine("{0} degrees F - feeling good!", temp);
            else Console.WriteLine("Oh no, {0} degrees F -- better go see a doctor!", temp);
        }

        static void Main(string[] args)
        {
            // Specified default values are fine for an average person
            CheckTemperature(101.5);

            // Temperatures for a dog should be between 100.5 and 102.5 Farenheit
            CheckTemperature(101.3, 102.5, 100.5);

            // Temperatures for Bob are always a little low, so tooLow is set to 99.5
            CheckTemperature(96.2, tooLow: 99.5);

        }

    }
}
