namespace HackYourFuture.DotnetMasterclass.Exercises
{
    public class Exercise3
    {
        // Write a method to create a new string from a given string where the first and last characters will change their positions
        // E.g.: programming => grogramminp
        public static void ReverseFirstAndLastLettersInWord()
        {
            Console.WriteLine("Enter a string please");
            var str = Console.ReadLine();
            var first = str[0];
            var last = str[str.Length-1];
            string newstr = last + str.Substring(1, str.Length - 2) + first;
            Console.WriteLine(newstr);
        }
    }
}