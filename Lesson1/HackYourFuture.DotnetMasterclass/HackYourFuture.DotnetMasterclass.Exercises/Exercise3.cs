namespace HackYourFuture.DotnetMasterclass.Exercises
{
    public class Exercise3
    {
        // Write a method to create a new string from a given string where the first and last characters
        // will change their positions
        // E.g.: programming => grogramminp
        public static void ReverseFirstAndLastLettersInWord()
        {
            Console.WriteLine("Please enter a word : ");
            string userInput = Console.ReadLine();

            if( userInput == "" || userInput == null)
            {
                Console.WriteLine("You didn't entered a word ");               
                return;
            }

            char [] newLetters = new char  [userInput.Length];        
            
            for (int i = 0;  i <= userInput.Length - 1; i++)
            {
                if( i == userInput.Length - 1)
                {
                    newLetters[0] = userInput[^1];
                }
                else if (i == 0)
                {
                    newLetters[userInput.Length - 1] = userInput[0];
                }
                else
                {
                    newLetters[i] = userInput[i];
                }
            }

            string newWord = string.Join("", newLetters);

            Console.WriteLine($"Your {userInput} has become {newWord}");
        }
    }
}