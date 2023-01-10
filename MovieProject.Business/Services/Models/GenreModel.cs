using Newtonsoft.Json;

namespace MovieProject.Business.Services.Models
{
    public class GenreModel
    {
        [JsonProperty("id")]
        public int Id { get; set; }
        [JsonProperty("name")]
        public string Name { get; set; }
    }
}
