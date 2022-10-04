namespace HackYourFuture.DotnetMasterclass.Lesson3.AsyncAwait
{
    internal class Program
    {
        static async Task Main(string[] args)
        {
            Console.WriteLine("please tell us what pokemon you want");
            var pokemonToFetch = Console.ReadLine();

            var exercise1 = new Exercise1();
            var result = await exercise1.GetYourPokemon(pokemonToFetch);
            Console.WriteLine(result);
            Console.ReadLine();
        }

        private static async Task<string> GetPokemonDitto()
        {
            var httpClient = new HttpClient();
            var result = await httpClient.GetAsync("https://pokeapi.co/api/v2/pokemon/ditto");

            return await result.Content.ReadAsStringAsync();
        }

        private static async Task<string> GetPokemonCharmander()
        {
            var httpClient = new HttpClient();
            var result = await httpClient.GetAsync("https://pokeapi.co/api/v2/pokemon/charmander");

            return await result.Content.ReadAsStringAsync();
        }
    }
}