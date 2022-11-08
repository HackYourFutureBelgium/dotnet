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
            Console.WriteLine("Please enter the radius: ");
            var radius = Console.ReadLine();
            var pi = ((float)22 / 7);
            var perimeter = int.Parse(radius) * 2 * pi;
            var area = pi * (int.Parse(radius)) * (int.Parse(radius));
            Console.WriteLine("Perimeter: " + perimeter);
            Console.WriteLine("Area: " + area);
        }
    }
}