using MovieProject.Business.Services.Models;

namespace MovieProject.Business.Services.Abstract
{
    public interface IMovieService
    {
        public Task<bool> Post(MovieModel model);
        Task<bool> AddScoreForMovie(MovieScoreModel model);

        Task<bool> AddCommentForMovie(MovieCommentModel model);

        Task<List<MovieModel>> GetAllMovies();

        Task<GetMoviesByIdModel> GetMovieById(int MovieId);
    }
}
