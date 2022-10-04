using Flurl.Http;

namespace HackYourFuture.DotnetMasterclass.Lesson3.NuGetPackages
{
    internal class Program
    {
        static async Task Main(string[] args)
        {
            var ditto = await "https://pokeapi.co/api/v2/pokemon/ditto".GetJsonAsync<Pokemon>();
            Console.WriteLine($"Ditto weighs {ditto.weight} kg");
            var exerceise1 = new Exercise1();
            exerceise1.PrintTimestampsInHumanReadableFormat();
            Console.ReadLine();
            
        }
    }
}