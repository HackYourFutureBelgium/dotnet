namespace HackYourFuture.DotnetMasterClass.Methods
{
    internal class Program
    {
        static void Main(string[] args)  // static means there is one instance evernnn of this class
        {
            Console.WriteLine("Hello, World!");

            // Calling methods
            PrintCalculationOutput();
            Console.ReadLine();

            // a number gets returned
            var calculationOutput = GetCalculationOutput();
            Console.WriteLine($"GetCalculationOutput {calculationOutput}");
            Console.ReadLine();

            // pass parameters
            Console.WriteLine("Enter the first number to add");
            var firstNumber = Console.ReadLine();
            Console.WriteLine("Enter the second number to add");
            var secondNumber = Console.ReadLine();
            Console.WriteLine($"AddTwoNumbers {AddTwoNumbers(int.Parse(firstNumber), int.Parse(secondNumber))}");


            // Calling methods in a different class
            var mathService = new MathService();

            var randomNumber = mathService.GetRandomNumber();
            Console.WriteLine($"Random Number: {randomNumber}");

            // Static methods don't require an instance
            var restValue = MathService.CalculateRestValueForFraction(9, 4);
            Console.WriteLine($"Rest value: {restValue}");

            Console.ReadLine();
        }


        // Methods A.K.A. Functions
        // The smallest unit in your code which contains a part of the logic

        // void => doesn't return anything
        public static void PrintCalculationOutput()
        {
            var calculatedValue = 4 + 5;

            Console.WriteLine($"PrintCalculationOutput: {calculatedValue}");
        }

        // int is the return type
        public static int GetCalculationOutput()
        {
            var calculatedValue = 3 + 6;

            return calculatedValue;
        }

        // pass parameters
        public static int AddTwoNumbers(int firstNumber, int secondNumber)
        {
            return firstNumber + secondNumber;
        }
    }

    public class MathService
    {
        public Random _randomNumberGenerator;
        public MathService()
        {
            _randomNumberGenerator = new Random();
        }

        public int GetRandomNumber()
        {
            return _randomNumberGenerator.Next();
        }

        public static int CalculateRestValueForFraction(int numerator, int denominator)
        {
            return numerator % denominator;
        }
    }
}