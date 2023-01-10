using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieProject.Business.Services.Models
{
    public class ProductionCountryModel
    {
        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("iso_3166_1")]
        public string Iso_3166_1 { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }
    }
}
