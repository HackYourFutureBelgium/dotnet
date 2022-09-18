namespace HackYourFuture.DotnetMasterclass.Exercises
{
    public class Exercise7
    {
        // Write a method that returns the sum of two numbers divided by 3. Create a separate method with the math logic.
        public static double AddTwoNumbersAndDivideBy3()
        {
            Console.WriteLine("Please eneter a number : ");
            string userInputOne = Console.ReadLine();

            if(userInputOne == "" || userInputOne == null)
            {
                Console.WriteLine("You entered nothing ");
                return 0.0;
            }
           
            bool isDouble = double.TryParse(userInputOne, out double firstNumber);
            if( ! isDouble)
            {
                Console.WriteLine("Please enter a number : ");
                return 0.0;
            }

            Console.WriteLine("Please eneter a number : ");
            string userInputTwo = Console.ReadLine();

            if (userInputTwo == "" || userInputTwo == null)
            {
                Console.WriteLine("You entered nothing ");
                return 0.0;
            }
                        
            bool isDoubleAlso = double.TryParse(userInputTwo, out double secondNumber);

            if (! isDoubleAlso)
            {
                Console.WriteLine("Please enter a second number : ");
                return 0.0;
            }

            double result = AddTwoNumbersAndDiviedTheSumByThree(firstNumber, secondNumber);

            Console.WriteLine($"The sum of {firstNumber} and {secondNumber} divided by 3 is {result}");

            return result;

        }

        public static double AddTwoNumbersAndDiviedTheSumByThree( double num1, double num2)
        {
            double  sum = num1 + num2;
            double result = sum / 3;

            return result;

        }
    }
}