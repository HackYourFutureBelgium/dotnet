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
            int number = 0;
            while (number == 0)
            {
                Console.WriteLine("Enter a number different from 0: ");
                var numberText = Console.ReadLine();

                int.TryParse(numberText, out number);
            }

            for (int i = 0; i < number; i++)
            {
                for (int j = 0; j < number - i; j++)
                {
                    Console.Write(number);
                }
                Console.WriteLine();
            }

            Console.ReadLine();
        }
    }
}