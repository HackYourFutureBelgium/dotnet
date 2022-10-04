using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HackYourFuture.DotnetMasterclass.Lesson3.AsyncAwait
{
    // Build your own Pokédex based on this API https://pokeapi.co/
    // A program that asks the user for a name of a pokémon
    // Display the properties of that pokémon in the Console


    public class Exercise1
    {
        public async Task<string> GetYourPokemon(string pokemonToFetch)
        {
         
            //var fetchPokemon = await Task.WhenAll(GetYourPokemon(pokemonTofetch));
            //Console.WriteLine(fetchPokemon);
  
            var httpClient = new HttpClient();
            var result = await httpClient.GetAsync($"https://pokeapi.co/api/v2/pokemon/{pokemonToFetch}");
            return await result.Content.ReadAsStringAsync();
        }
    }
}
