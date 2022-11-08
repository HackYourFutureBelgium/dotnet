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
            Console.WriteLine("Input two numbers please:");
            var firstNum = int.Parse(Console.ReadLine());
            var secondNum = int.Parse(Console.ReadLine());

            if (firstNum > secondNum)
            {
                Console.WriteLine(firstNum);
                return firstNum;
            }
            else
            {
                Console.WriteLine(secondNum);
                return secondNum;
            }
        }
    }
}
