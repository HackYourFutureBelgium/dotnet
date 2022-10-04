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
            Console.WriteLine("this program checks which of two numbers is the larger");
            Console.WriteLine("to begin, please type a number and press enter");
            var firstNumberText = Console.ReadLine();

            int firstNumber;
            while (!int.TryParse(firstNumberText, out firstNumber))
            {
                Console.WriteLine("Please enter a valid number");
                firstNumberText = Console.ReadLine();
            };
            Console.WriteLine($"your first number is; {firstNumberText}");


            Console.WriteLine("please type a second number and press enter");
            var secondNumberText = Console.ReadLine();

            int secondNumber;
            while (secondNumberText == firstNumberText || !int.TryParse(secondNumberText, out secondNumber))
            {
                Console.WriteLine("please enter a different valid number");
                secondNumberText = Console.ReadLine();
            };

            Console.WriteLine($"your second number is; {secondNumberText}");

            var largernumber = firstNumber > secondNumber ? firstNumber : secondNumber;
            Console.WriteLine($"the larger number is {largernumber}");
            Console.ReadLine();
            return largernumber;

            //var largerNumber = PrintTheLargestNumber(int.Parse(firstNumber), int.Parse(secondNumber));
            //Console.WriteLine($"AddTwoNumbers {AddTwoNumbers(int.Parse(firstNumber), int.Parse(secondNumber))}");
            //Console.WriteLine($"{CompareTwoNumbers(int.Parse(firstNumber), int.Parse(secondNumber))}");

            // if (firstNumber == secondNumber)
            // {
            //    Console.WriteLine("both numbers are the same, please try again");
            // }else 
            // {

            //}
            throw new NotImplementedException();
        }
        /*
        public static int CompareTwoNumbers(int firstNumber, int secondNumber)
        {
            if(firstNumber > secondNumber)
            {
                return firstNumber;
            }else if(firstNumber == secondNumber)
            {
                Console.WriteLine("both numbers are the same, please try again");
                return 0;

            }
            else
            {
                return secondNumber;
            };
        */
    }
}
