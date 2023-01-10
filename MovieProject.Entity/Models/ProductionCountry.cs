using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieProject.Entity.Models
{
    public class ProductionCountry : BaseClass
    {
        public string Iso_3166_1 { get; set; }
        public string Name { get; set; }

        public int MovieId { get; set; }
        public Movie Movie { get; set; }
    }
}
