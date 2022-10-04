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
            Console.WriteLine("this program checks if a word has consecutive letters");
            Console.WriteLine("to begin, please enter a word that is at least two letters long");

            var wordToCheck = Console.ReadLine();

            while (wordToCheck.Length < 2)
            {
                Console.WriteLine("please enter a valid word that is at least two letters long");
                wordToCheck = Console.ReadLine();
            }

            Console.WriteLine($"the word you entered is; {wordToCheck}. your word is {wordToCheck.Length} letters long");
            Console.WriteLine("checking for consecutive letters...");

            var repeatingLetters = "";

            for (int i = 1; i < wordToCheck.Length; i++)
            {
                if (wordToCheck[i - 1] == wordToCheck[i])
                {
                    if (!repeatingLetters.Contains(wordToCheck[i]))
                    {
                        repeatingLetters = repeatingLetters + $"{wordToCheck[i]}";
                    }
                }
            }


            var toWrite = "!!! Found consecutive letters ";

            if (repeatingLetters.Length == 1)
            {
                Console.WriteLine($"!!! Found consecutive letter '{repeatingLetters}'");
                Console.ReadLine();
            }
            else
            {
                for (int i = 0; i < repeatingLetters.Length-1; i++)
                {
                    toWrite = toWrite + $"'{repeatingLetters[i]}' ";
                }
                toWrite = toWrite + $"and '{repeatingLetters[repeatingLetters.Length-1]}'";
                Console.WriteLine(toWrite);
                Console.ReadLine();
            }



            /*
            var repeatingLetters = new List<char>();

            for(int i = 1; i < wordToCheck.Length; i++)
            {
                if (wordToCheck[i-1] == wordToCheck[i])
                {
                    if (!repeatingLetters.Contains(wordToCheck[i]))
                    {
                        repeatingLetters.Add(wordToCheck[i]);
                    }
                }
            }

            foreach (var character in repeatingLetters)
            {
                Console.WriteLine(character);
            }
            Console.WriteLine(repeatingLetters);
            */


            //throw new NotImplementedException();
        }
    }
}