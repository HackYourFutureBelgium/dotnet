using System.ComponentModel;

namespace HackYourFuture.DotnetMasterclass.Exercises
{
    public class Exercise2
    {
        // Write a method to convert from user inputted celsius degrees to Fahrenheit

        public static void ConvertCelsiusToFahrenheit()
        {
            Console.WriteLine("Please input Celcius:");
            var celcius = int.Parse(Console.ReadLine());
            var fahren = celcius * 1.8 + 32;
            Console.WriteLine("Fahreneit is: " + fahren + "F");
        }
    }
}