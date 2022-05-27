using System.Text.Json.Serialization;

namespace PokemonMVC.Models
{
    public class PokemonViewModel
    {
        [JsonPropertyName("name")]
        public string Name {get; set;}

        [JsonPropertyName("id")]
        public int PokedexNumber {get; set;}

        [JsonPropertyName("height")]
        public int Height {get; set;}

        [JsonPropertyName("weight")]
        public int Weight {get; set;}
    }
}