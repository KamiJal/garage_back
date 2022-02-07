using System.Text.Json.Serialization;

namespace garage_back.Models
{
    public class Location
    {
        [JsonPropertyName("lat")]
        public string Latitude { get; set; }

        [JsonPropertyName("long")]
        public string Longtitude { get; set; }
    }
}
