using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieProject.Entity.Models
{
    public class ProductionCompany : BaseClass
    {
        public string Logo_path { get; set; }
        public string Name { get; set; }
        public string Origin_country { get; set; }

        public int MovieId { get; set; }
        public Movie Movie { get; set; }
    }
}
