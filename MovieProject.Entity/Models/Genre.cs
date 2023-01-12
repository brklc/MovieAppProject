using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieProject.Entity.Models
{
    public class Genre : BaseClass
    {
        public string Name { get; set; }

        public int MovieId { get; set; }
        public Movie Movie { get; set; }
    }
}
