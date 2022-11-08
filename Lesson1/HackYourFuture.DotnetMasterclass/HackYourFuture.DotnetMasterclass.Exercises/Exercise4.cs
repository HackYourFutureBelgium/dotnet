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
            Console.WriteLine("Please enter a string to check \n");
            string str = Console.ReadLine();
            List<char> list = new List<char>();
            for (int i = 0; i < str.Length - 1; i++)
            {
                if (str[i] == str[i + 1])
                {
                    list.Add(str[i]);
                }
            }
            if (list.Count > 0)
            {
                Console.WriteLine("!!! Found consecutive letters ");
                Console.WriteLine("{0}", string.Join(", ", list));
            }
            else
            {
                Console.WriteLine("No consecutive letters found");
            }
            

        }
    }
}