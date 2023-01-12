using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieProject.Business.Services.Models
{
    public class ProductionCompanyModel
    {
    
        [JsonProperty("logo_path")]
        public string Logo_path { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("origin_country")]
        public string Origin_country { get; set; }
    }
}
