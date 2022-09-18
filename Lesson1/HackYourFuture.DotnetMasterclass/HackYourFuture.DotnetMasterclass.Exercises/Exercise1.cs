using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HackYourFuture.DotnetMasterclass.Exercises
{
    public class Exercise1
    {
        // Write a method that asks the user to input 2 numbers and to return the biggest one
        public static int PrintTheLargestNumber()
        {
            Console.WriteLine("Please enter a number");

            // Check if the firstInput is an integer and if not stop the program
            string firstInput = Console.ReadLine();           
            bool isAnumber = int.TryParse(firstInput, out int firstNumber);

            if (! isAnumber)
            {
                Console.WriteLine("You didn't enter a number");
                return 0;
            }
            // Check if the secondInput is an integer and if not stop the program
            Console.WriteLine("Please enter a second number");
            string secondInput = Console.ReadLine();
            
            bool isAnumber2 = int.TryParse(secondInput, out int secondNumber);

            if (!isAnumber2)
            {
                Console.WriteLine("You didn't enter a number");
                return 0;
            }
            // If both are numbers 
            if (firstNumber > secondNumber)
            {
                Console.WriteLine($" the largest number is : {firstNumber}");
                return firstNumber;
            }
            else
            {
                Console.WriteLine($" the largest number is : {secondNumber}");
                return secondNumber;
            }
        }
    }
}


