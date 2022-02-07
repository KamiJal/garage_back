using System.Text.Json.Serialization;

namespace garage_back.Models
{
    public class Vehicle
    {
        [JsonPropertyName("_id")]
        public int Id { get; set; }

        [JsonPropertyName("make")]
        public string Make { get; set; }

        [JsonPropertyName("model")]
        public string Model { get; set; }

        [JsonPropertyName("year_model")]
        public int ModelYear { get; set; }

        [JsonPropertyName("price")]
        public double Price { get; set; }

        [JsonPropertyName("licensed")]
        public bool Licensed { get; set; }

        [JsonPropertyName("date_added")]
        public string DateAdded { get; set; }
    }
}
