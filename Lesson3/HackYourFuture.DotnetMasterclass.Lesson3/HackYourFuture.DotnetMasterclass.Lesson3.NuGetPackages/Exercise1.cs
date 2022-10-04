using System;
using Humanizer;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace HackYourFuture.DotnetMasterclass.Lesson3.NuGetPackages
{
    // Install the package "Humanizer" to make the following print statements human readable
    // By installing the package you can now use several overload methods to make the data more readable
    // Check the pacakge's documentation to find out how
    public class Exercise1

    {

        public void PrintTimestampsInHumanReadableFormat()
        {

            var french = new CultureInfo("fr");

            // Print the timestamp as weeks
            var firstTimespan = TimeSpan.FromSeconds(1123453978).Humanize();
            Console.WriteLine(firstTimespan);

            // Print this time in French words
            var time = TimeSpan.FromDays(7).Humanize(culture: french);
            Console.WriteLine(time);

            // Print the number in Romand numerals
            var number = 4.ToRoman();
            Console.WriteLine(number);
        }
    }
}
