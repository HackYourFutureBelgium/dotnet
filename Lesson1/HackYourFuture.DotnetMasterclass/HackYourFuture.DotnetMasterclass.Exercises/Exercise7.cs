namespace HackYourFuture.DotnetMasterclass.Exercises
{
    public class Exercise7
    {
        // Write a method that returns the sum of two numbers divided by 3. Create a separate method with the math logic.
        public static void AddTwoNumbersAndDivideBy3()
        {
            Console.WriteLine("this program calculates the sum of two numbers divided by two");

            double firstNumber = AskUserForNumber();
            Console.WriteLine($"your first number is {firstNumber}");
            double secondNumber = AskUserForNumber();
            Console.WriteLine($"your first number is {secondNumber}");
            Console.WriteLine("calculating sum divided by three...");
 
            Console.WriteLine($"your result is {(firstNumber + secondNumber)/3}");
            Console.ReadLine();
            //throw new NotImplementedException();
        }

        public static double AskUserForNumber()
        {
            Console.WriteLine("please type a valid number");
            var numberText = Console.ReadLine();
            int number;
            while(!int.TryParse(numberText, out number)){
                Console.WriteLine("invalid number, please try again");
                numberText = Console.ReadLine();
            }
            return number;
        }
    }
}