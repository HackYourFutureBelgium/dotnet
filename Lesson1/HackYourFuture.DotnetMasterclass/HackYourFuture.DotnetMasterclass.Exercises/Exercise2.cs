using System.ComponentModel;

namespace HackYourFuture.DotnetMasterclass.Exercises
{
    public class Exercise2
    {
        // Write a method to convert from user inputted celsius degrees to Fahrenheit

        public static void ConvertCelsiusToFahrenheit()
        {
            Console.WriteLine("this program converts degrees in celsius into farenheit");
            Console.WriteLine("first of all, please type your local temperature in numbers");
            var celsiusDegreesText = Console.ReadLine();

            int celsiusDegrees;
            while (!int.TryParse(celsiusDegreesText, out celsiusDegrees))
            {
                Console.WriteLine("please enter a valid temperature");
                celsiusDegreesText = Console.ReadLine();
            }

            Console.WriteLine($"your local temperature is {celsiusDegreesText}°Celsius");

            var farenheitDegrees = celsiusDegrees * 1.8 + 32;

            Console.WriteLine("converting...");

            Console.WriteLine($"your local temperature is {farenheitDegrees}°Farenheit");
            Console.ReadLine();

            //conversion formula; f = c*1.8+32
            //throw new NotImplementedException();
        }
    }
}