using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieProject.Entity.Models
{
    public class BelongsToCollection : BaseClass
    {
        public string Name { get; set; }
        public string Poster_path { get; set; }
        public string Backdrop_path { get; set; }

        public int MovieId { get; set; }
        public virtual Movie Movie { get; set; }

    }
}
