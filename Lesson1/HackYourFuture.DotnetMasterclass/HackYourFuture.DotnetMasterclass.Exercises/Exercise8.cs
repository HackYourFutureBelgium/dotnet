namespace HackYourFuture.DotnetMasterclass.Exercises
{
    internal class Exercise8
    {
        // Write a method to calculate the sum of the individual digits of a given number.
        // Do this recursively until you have a single digit number. You will need a separate method with the logic.
        // 12345 => 15 => 6
        internal static void AddDigitsForAGivenNumber()
        {
            Console.WriteLine("Please enter an integer ");

            string userInput = Console.ReadLine();

            if( userInput == "" || userInput == null )
            {
                Console.WriteLine("You enterd nothing ");
                return;
            }

            bool isInteger = int.TryParse(userInput, out int number);
            if ( ! isInteger )
            {
                Console.WriteLine("You didn't enter an integer");
            }

            int result = AddNumberDigits(number);

            Console.WriteLine($"for a number {number} the sum of all digits recursively is {result}");
            
        }

        static int AddNumberDigits(int num)
        {
            if ( num == 0) return 0;
            else
            {
                int sum = num % 10 + AddNumberDigits(num / 10);

                if(sum < 10)
                {
                    return sum;
                }
                else
                {
                    int newSum = sum % 10 + AddNumberDigits(sum / 10);
                    return newSum;
                }
            }
        }
    }
}