namespace HackYourFuture.DotnetMasterclass.Exercises
{
    internal class Exercise8
    {
        // Write a method to calculate the sum of the individual digits of a given number. Do this recursively until you have a single digit number. You will need a separate method with the logic.
        // 12345 => 15 => 6
        internal static void AddDigitsForAGivenNumber()
        {
            Console.WriteLine("Please enter an integer number: ");
            //var num = Console.ReadLine();

            //var length = num.Length;
            //var sum = 0;

            //for (var i = 0; i < length; i++)
            //{
            //    sum += num[i];
            //    //Console.WriteLine(num[i]);
            //}

            //Console.WriteLine(sum.GetType());
            //Console.WriteLine(sum);

            var num = int.Parse(Console.ReadLine());
            var sum = num;
            var length = num.ToString().Length;
            //Console.WriteLine("length: " + length);

            while (sum > 9)
            {
                num = sum;
                length = num.ToString().Length;
                sum = 0;
                for (int i = 0; i < length; i++)
                {
                    sum += num % 10;
                    num = num / 10;
                    Console.WriteLine("num after " + i + ". iteration: " + num);
                }
                Console.WriteLine(sum);
            }
        }
    }
}