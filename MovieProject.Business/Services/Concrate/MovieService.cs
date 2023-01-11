using AutoMapper;
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
    public class MovieService : IMovieService
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;
        public MovieService(IUnitOfWork unitOfWork, IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
        }

        public Task Post(MovieModel model)
        {
            var movieMap = _mapper.Map<MovieModel, Movie>(model);

             _unitOfWork.Movies.Add(movieMap);

            _unitOfWork.CompleteAsync();

            return Task.CompletedTask;
        }
    }
}
