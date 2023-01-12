using System.ComponentModel.DataAnnotations;

namespace MovieProject.Entity.Models
{
    public class MovieComment: BaseClass
    {
        public string Note  { get; set; }

        public string UserName { get; set; }
        public int MovieId { get; set; }
        public Movie Movie { get; set; }
    }
}
