namespace HackYourFuture.DotnetMasterclass.Exercises
{
    public class Exercise5
    {
        // Write a method that takes a number as input and then displays a triangle with the broadest side equal to that width
        // 55555
        // 5555
        // 555
        // 55
        // 5
        public static void PrintNumberInTraingle()
        {
            Console.WriteLine("Please eneter a integer : ");

            string userInput = Console.ReadLine();
            
            bool isInteger = int.TryParse(userInput, out int enteredNumber);
            if ( ! isInteger || userInput == null)
            {
                Console.WriteLine("You didn't entered an integer");
                return;
            }

            if (enteredNumber == 0)
            {
                Console.WriteLine("Please enter a number greater than zero");
                return ;
            }

           for ( int i = enteredNumber;  i > 0 ; i--)
           {
                string str = string.Concat(Enumerable.Repeat(userInput, i));
                Console.WriteLine(str);
           }
        }
    }
}