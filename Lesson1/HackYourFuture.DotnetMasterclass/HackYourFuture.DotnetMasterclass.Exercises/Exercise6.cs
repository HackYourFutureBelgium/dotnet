namespace HackYourFuture.DotnetMasterclass.Exercises
{
    public class Exercise6
    {
        // Write a method that takes the radius of a circle as input and calculate the perimeter and area of the circle
        // https://www.w3resource.com/w3r_images/charp-area-of-a-circle-exercise-1.png
        // Circumference => 2πr
        // Area => πr²
        public static void CaclulateThePerimeterOfACircleBasedOnTheRadius()
        {
            Console.WriteLine("this program calculates the perimiter and are of a circle according to its radius");
            int radius = 0;

            while(radius <= 0)
            {
                Console.WriteLine("please enter a valid radius for your circle in cm");
                var radiusText = Console.ReadLine();
                int.TryParse(radiusText, out radius);
            }

            Console.WriteLine($"your circle's radius is {radius}cm");
            Console.WriteLine("calculating circumference...");
            double circumference = radius * 2 * Math.PI;

            Console.WriteLine($"your circle's circumference is {circumference}cm");
            Console.WriteLine("calculating area...");

            double area = Math.Pow(radius, 2) * Math.PI;
            Console.WriteLine($"your circle's circumference is {area}cm²");

            Console.ReadLine();
            //throw new NotImplementedException();
        }
    }
}