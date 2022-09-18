using System.ComponentModel;

namespace HackYourFuture.DotnetMasterclass.Exercises
{
    public class Exercise4
    {
        // Write a method to check if a given string contains two similar consecutive letters
        // Banana => No consecutive letters found
        // Apple => !!! Found consecutive letter 'p'
        // Cappuccino => !!! Found consecutive letters 'p' and 'c'
        public static void CheckIfWordHasTwoSimilarConsecutiveLetters()
        {
            Console.WriteLine("Please enter a string : ");

            string userInput = Console.ReadLine();

            if( userInput == "" || userInput == null)
            {
                Console.WriteLine("You didn't enter a string");
                return;
            }

            bool hasNoconsecutiveLetters = true;
            for ( int i = 0; i < userInput.Length - 1; i++)
            {
                if ( userInput[i] == userInput[i + 1] )
                {
                    hasNoconsecutiveLetters = false;
                    Console.WriteLine($" Found consecutive letter '{userInput[i]}'");
                }               
            }

            if ( hasNoconsecutiveLetters )
            {
                Console.WriteLine("No consecutive letters found");
            }
        }
    }
}