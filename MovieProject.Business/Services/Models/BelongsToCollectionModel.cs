using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieProject.Business.Services.Models
{
    public class BelongsToCollectionModel
    {
     
        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("poster_path")]
        public string Poster_path { get; set; }

        [JsonProperty("backdrop_path")]
        public string Backdrop_path { get; set; }
    }
}
