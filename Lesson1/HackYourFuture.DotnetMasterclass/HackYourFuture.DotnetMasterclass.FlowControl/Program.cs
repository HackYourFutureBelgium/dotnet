using System;

namespace HackYourFuture.DotnetMasterclass.FlowControl
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var value = 8;

            if (value == 8)
            {
                Console.WriteLine("value equals 8");
            }
            else if (value == 16)
            {
                Console.WriteLine("value equals 8");
            }
            else if (value == 32)
            {
                Console.WriteLine("value equals 8");
            }
            else
            {
                Console.WriteLine("value did not equal any value");
            }

            if (value != 4)
            {
                Console.WriteLine("value does not equal 4");
            }

            if (value > 4)
            {
                Console.WriteLine("value is larger than 4");
            }

            if (value >= 4)
            {
                Console.WriteLine("value is larger or equal to 4");
            }

            if (value < 4)
            {
                Console.WriteLine("value is smaller than 4");
            }

            if (value <= 4)
            {
                Console.WriteLine("value is smaller or equal to 4");
            }
            Console.ReadLine();



            var dayOfWeek = DateTime.Now.DayOfWeek;

            switch (dayOfWeek)
            {
                case DayOfWeek.Monday:
                    Console.WriteLine("It's Monday today");
                    break;

                case DayOfWeek.Tuesday:
                    Console.WriteLine("It's Tuesday today");
                    break;

                case DayOfWeek.Sunday:
                    Console.WriteLine("It's Sunday today");
                    break;

                default:
                    Console.WriteLine("Day not listed");
                    break;
            }
            Console.ReadLine();






            var index = 0;
            while (true)
            {
                index++;
                if (index == 10)
                    break;
            }

            index = 0;
            while (index < 8)
            {
                index += 2;
            }

            index = 0;
            while (index < 10)
            {
                if (index % 2 == 0)
                {
                    continue;
                }
                Console.WriteLine($"index={index}");
                Console.ReadLine();
            }








            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine(i);
                Console.ReadLine();
            }


            string[] planets = { "Mercury", "Venus", "Earth", "Mars", "Jupiter", "Saturn", "Uranus", "Neptune" };

            for (int i = 0; i < planets.Length; i++)
            {
                Console.WriteLine(planets[i]);
                Console.ReadLine();
            }
            
            foreach (string planet in planets)
            {
                Console.WriteLine(planet);
                Console.ReadLine();
            }









        }
    }
}