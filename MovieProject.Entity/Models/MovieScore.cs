using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieProject.Entity.Models
{
    public class MovieScore:BaseClass
    {
        [Range(1, 10)]
        public int Score { get; set; }
        public string UserName { get; set; }
        public int MovieId { get; set; }
        public Movie Movie { get; set; }
    }
}
