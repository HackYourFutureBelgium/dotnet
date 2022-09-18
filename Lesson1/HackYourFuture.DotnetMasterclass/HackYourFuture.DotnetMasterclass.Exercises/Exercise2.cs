using System.ComponentModel;

namespace HackYourFuture.DotnetMasterclass.Exercises
{
    public class Exercise2
    {
        // Write a method to convert from user inputted celsius degrees to Fahrenheit

        public static void ConvertCelsiusToFahrenheit()
        {
            Console.WriteLine(" Please enter the temperature in Celsuis : ");
            string userInput = Console.ReadLine();            

            if(userInput == "" || userInput == null)
            {
                return;
            }

            bool  isDobule  = double.TryParse(userInput, out double celsius );

            if ( !isDobule)
            {
                Console.WriteLine("Please enter  the temperature in Celsuis as a number :  ");
                return;
            }
            else
            {
                double Fahrenheit = ( celsius * 1.8 ) + 32;
                Console.WriteLine($" {userInput} Celsuis is equal to { Fahrenheit } Fahrenheit ");
            }
        }
    }
}