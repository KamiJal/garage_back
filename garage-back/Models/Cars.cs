using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace garage_back.Models
{
    public class Cars
    {
        [JsonPropertyName("location")]
        public string Location { get; set; }

        [JsonPropertyName("vehicles")]
        public List<Vehicle> Vehicles { get; set; }
    }
}
