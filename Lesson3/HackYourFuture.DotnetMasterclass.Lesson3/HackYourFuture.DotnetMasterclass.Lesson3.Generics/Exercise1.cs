using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HackYourFuture.DotnetMasterclass.Lesson3.Generics
{
    // Create a class that can print the concatenated ToString() value of two generic variables
    public class Exercise1<Tfirst, Tsecond>
    {
        public void Print(Tfirst first, Tsecond second)
        {
            Console.WriteLine($"{first} {second}");
        }
    }
}
