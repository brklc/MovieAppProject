using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieProject.Entity.Models
{
    public class SpokenLanguage : BaseClass
    {
        public string English_name { get; set; }
        public string Iso_639_1 { get; set; }
        public string Name { get; set; }

        public int MovieId { get; set; }
        public Movie Movie { get; set; }
    }
}
