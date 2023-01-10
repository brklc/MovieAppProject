using MovieProject.Business.Services.Abstract;
using MovieProject.Business.Services.Models;
using MovieProject.Entity.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieProject.Business.Services.Concrate
{
    public class MovieService : BaseService, IMovieService
    {
        public MovieService(IServiceProvider serviceProvider) : base(serviceProvider)
        {
        }

        public Task Post(MovieModel model)
        {
            var movieMap = _mapper.Map<MovieModel, Movie>(model);

            _unitOfWork.GetRepository<Movie>().Add(movieMap);

            _unitOfWork.SaveChanged();

            return Task.CompletedTask;
        }
    }
}
