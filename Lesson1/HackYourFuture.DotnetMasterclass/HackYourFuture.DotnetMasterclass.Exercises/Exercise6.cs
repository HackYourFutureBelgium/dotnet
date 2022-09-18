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
            Console.WriteLine("Please enter a circle raduis as an integer");
            string userInput = Console.ReadLine();         

            bool isInteger = int.TryParse(userInput, out int radius);

            if ( ! isInteger)
            {
                Console.WriteLine("You didn't enter an integer");
                return;
            }

            const float PI = 3.141592653F;

            double perimeter = 2 * PI * radius;
            double area = PI * Math.Pow(radius, 2);

            Console.WriteLine($"a circle with raduis {radius} it's  perimeter : {perimeter}cm  and it's area : {area} cm2");

        }
    }
}