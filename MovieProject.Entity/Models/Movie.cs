using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieProject.Entity.Models
{
    public class Movie : BaseClass
    {
        public bool Adult { get; set; }
        public string Backdrop_path { get; set; }
        public int Budget { get; set; }
        public string Homepage { get; set; }
        public string Imdb_id { get; set; }
        public string Original_language { get; set; }
        public string Original_title { get; set; }
        public string Overview { get; set; }
        public double Popularity { get; set; }
        public string Poster_path { get; set; }
        public string Release_date { get; set; }
        public int Revenue { get; set; }
        public int Runtime { get; set; }
        public string Status { get; set; }
        public string Tagline { get; set; }
        public string Title { get; set; }
        public bool Video { get; set; }
        public double Vote_average { get; set; }
        public int Vote_count { get; set; }
        public virtual BelongsToCollection? Belongs_to_collection { get; set; }
        public virtual MovieScore? MovieScore { get; set; }
        public virtual ICollection<SpokenLanguage> Spoken_languages { get; set; }
        public virtual ICollection<ProductionCompany> Production_companies { get; set; }
        public virtual ICollection<ProductionCountry> Production_countries { get; set; }
        public virtual ICollection<MovieComment> MovieComments { get; set; }

        public ICollection<Genre> Genres { get; set; }
    }
}
