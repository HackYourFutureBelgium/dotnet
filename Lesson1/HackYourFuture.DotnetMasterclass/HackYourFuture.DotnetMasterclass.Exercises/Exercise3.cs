namespace HackYourFuture.DotnetMasterclass.Exercises
{
    public class Exercise3
    {
        // Write a method to create a new string from a given string where the first and last characters will change their positions
        // E.g.: programming => grogramminp
        public static void ReverseFirstAndLastLettersInWord()
        {
            Console.WriteLine("this program switches the first and last letters in a word");
            Console.WriteLine("to begin, please type a word that is at least two letters long");
            var originalWord = Console.ReadLine();

            while (originalWord.Length < 2)
            {
                Console.WriteLine("please type a word that is at least two letters long");
                originalWord = Console.ReadLine();
            }

            Console.WriteLine($"your original word is {originalWord}");
            Console.WriteLine("scrambling...");

            var midWord = "";
            for (int i = 1; i < originalWord.Length - 1; i++)
            {
                midWord = midWord + originalWord[i];
            }

            Console.WriteLine(midWord);

            var newWord = originalWord[originalWord.Length - 1] + midWord + originalWord[0];

            Console.WriteLine(newWord);
            Console.ReadLine();

            //throw new NotImplementedException();
        }
    }
}