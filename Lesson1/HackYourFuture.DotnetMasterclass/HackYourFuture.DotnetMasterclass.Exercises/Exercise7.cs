namespace HackYourFuture.DotnetMasterclass.Exercises
{
    public class Exercise7
    {
        // Write a method that returns the sum of two numbers divided by 3. Create a separate method with the math logic.
        public static void AddTwoNumbersAndDivideBy3()
        {
            Console.WriteLine("Please enter a number: ");
            var num1 = int.Parse(Console.ReadLine());
            var num2 = int.Parse(Console.ReadLine());
            var sum = num1 + num2;
            Console.WriteLine("Sum/3: " + ((float)sum / 3));
        }
    }
}