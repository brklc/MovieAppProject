using MovieProject.Entity.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieProject.Business.Services.Models
{
    public class MovieModel
    {
        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("adult")]
        public bool Adult { get; set; }
        [JsonProperty("backdrop_path")]
        public string Backdrop_path { get; set; }

        [JsonProperty("budget")]
        public int Budget { get; set; }

        [JsonProperty("homepage")]
        public string Homepage { get; set; }

        [JsonProperty("imdb_id")]
        public string Imdb_id { get; set; }

        [JsonProperty("original_language")]
        public string Original_language { get; set; }

        [JsonProperty("original_title")]
        public string Original_title { get; set; }

        [JsonProperty("overview")]
        public string Overview { get; set; }

        [JsonProperty("popularity")]
        public double Popularity { get; set; }

        [JsonProperty("poster_path")]
        public string Poster_path { get; set; }

        [JsonProperty("release_date")]
        public string Release_date { get; set; }

        [JsonProperty("revenue")]
        public int Revenue { get; set; }

        [JsonProperty("runtime")]
        public int Runtime { get; set; }

        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("tagline")]
        public string Tagline { get; set; }

        [JsonProperty("title")]
        public string Title { get; set; }

        [JsonProperty("video")]
        public bool Video { get; set; }

        [JsonProperty("vote_average")]
        public double Vote_average { get; set; }

        [JsonProperty("vote_count")]
        public int Vote_count { get; set; }

        [JsonProperty("belongs_to_collection")]
        public virtual BelongsToCollectionModel Belongs_to_collection { get; set; }

        [JsonProperty("spoken_languages")]
        public virtual ICollection<SpokenLanguageModel> Spoken_languages { get; set; }

        [JsonProperty("production_companies")]
        public virtual ICollection<ProductionCompanyModel> Production_companies { get; set; }

        [JsonProperty("production_countries")]
        public virtual ICollection<ProductionCountryModel> Production_countries { get; set; }

        [JsonProperty("genres")]
        public ICollection<GenreModel> Genres { get; set; }
    }
}
