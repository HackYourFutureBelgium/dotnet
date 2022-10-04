using System;

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
            Console.WriteLine("this program turns a number into a triangle");
            int number = 0;
            while (number == 0 || number <0)
            {
                Console.WriteLine("Enter a number different from 0: ");
                var numberText = Console.ReadLine();

                int.TryParse(numberText, out number);
            }

            Console.WriteLine($"your number is {number}");
            Console.WriteLine("drawing triangle...");

            for (int i = number; i>0; i--)
            {
                for (int c = i; c>0; c--)
                {
                    Console.Write(number);
                }
                Console.WriteLine();
            }

            Console.ReadLine();


            /*
            var numberText = Console.ReadLine();

            int number;

            while (int.Parse(numberText)==null || int.Parse(numberText) < 0)
                {
                    Console.WriteLine("please enter a valid positive number");
                    numberText = Console.ReadLine();
                }

           
            while(!int.TryParse(numberText, out number))
            {
                Console.WriteLine("please enter a valid positive number");
                numberText = Console.ReadLine();
            }
            */

            //throw new NotImplementedException();
        }
    }
}