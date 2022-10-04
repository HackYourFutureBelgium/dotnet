namespace HackYourFuture.DotnetMasterclass.Exercises
{
    internal class Exercise8
    {
        // Write a method to calculate the sum of the individual digits of a given number. Do this recursively until you have a single digit number. You will need a separate method with the logic.
        // 12345 => 15 => 6
        internal static void AddDigitsForAGivenNumber()
        {
            Console.WriteLine("this program calculates the sum of a number's digits to a single digit");
            Console.WriteLine("please type a valid, positive whole number");

            var numberText = Console.ReadLine();

            int number;
            while(numberText.Length<2 || !int.TryParse(numberText, out number))
            {
                Console.WriteLine("please type a valid, positive whole number");
                numberText = Console.ReadLine();
            }

            var numberString = numberText;

            Console.WriteLine($"your original number is {numberText}");
            Console.WriteLine("calculating sum of digits...");
            while (numberString.Length >=2)
            {
                int sum = 0;
                for(int i = 0; i < numberString.Length; i++)
                {
                    int digit = int.Parse(numberString[i].ToString());
                    sum = sum + digit;
                }
                numberString = sum.ToString();
            };

            /*
            int number = 0;

            while(number <= 0)
            {
                Console.WriteLine("please type a valid, positive whole number");
                var numberText = Console.ReadLine();
                int.TryParse(numberText, out number);
            }
            */

            Console.WriteLine($"the digit sum of your number is: {numberString}");

            Console.ReadLine();
        }
    }
}