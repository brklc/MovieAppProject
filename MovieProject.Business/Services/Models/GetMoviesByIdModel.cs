using MovieProject.Business.Models;

namespace MovieProject.Business.Services.Models
{
    public class GetMoviesByIdModel
    {
        public MovieAModel Movie { get; set; }
        public int? MovieScore { get; set; }
        public List<MovieCommentModel>? MovieComments { get; set; }
    }
}
