using Newtonsoft.Json;

namespace MovieProject.Business.Services.Models
{
    public class GenreModel
    {
      
        [JsonProperty("name")]
        public string Name { get; set; }
    }
}
