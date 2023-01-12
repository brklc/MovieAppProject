using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MovieProject.Business.Services.Abstract;
using MovieProject.Business.Services.Models;
using MovieProject.Entity.Models;

namespace MovieProject.Controllers
{
    [Authorize]
    [Route("api/[controller]")]
    [ApiController]
    public class MoviesController : ControllerBase
    {
        private readonly IMovieService _movieService;
        public MoviesController(IMovieService movieService)
        {
            _movieService = movieService;
        }

        [HttpPost("AddMovieComment")]
        public Task AddMovieComment([FromBody] MovieCommentModel model)
        {
            return _movieService.AddCommentForMovie(model);
        }

        [HttpPost("AddMovieScore")]
        public Task AddMovieScore([FromBody] MovieScoreModel model)
        {
            return _movieService.AddScoreForMovie(model);
        }

        [HttpGet("GetMovieById/{movieId}")]
        public Task<GetMoviesByIdModel> GetMovieById(int movieId)
        {
            return _movieService.GetMovieById(movieId);
        }

        [HttpGet("GetAllMovies")]
        public Task<List<MovieModel>> GetAllMovies()
        {
            return _movieService.GetAllMovies();
        }
    }
}
