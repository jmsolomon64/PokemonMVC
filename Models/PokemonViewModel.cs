using System.Text.Json.Serialization;

namespace PokemonMVC.Models
{
    public class PokemonViewModel
    {
        [JsonPropertyName("name")]
        public string Name {get; set;}

        [JsonPropertyName("id")]
        public string PokedexNumber {get; set;}

        [JsonPropertyName("height")]
        public string Height {get; set;}

        [JsonPropertyName("weight")]
        public string Weight {get; set;}
    }
}