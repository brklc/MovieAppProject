using AutoMapper;
using Microsoft.EntityFrameworkCore;
using MovieProject.Business.Models;
using MovieProject.Business.Services.Abstract;
using MovieProject.Business.Services.Models;
using MovieProject.Entity.Context;
using MovieProject.Entity.Models;

namespace MovieProject.Business.Services.Concrate
{
    public class MovieService : IMovieService
    {
        //private readonly IUnitOfWork _unitOfWork;
        private readonly MovieProjectContext _context;
        private readonly IMapper _mapper;
        public MovieService(MovieProjectContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        public Task<bool> Post(MovieModel model)
        {
            try
            {
                var movie = _context.Movies.Where(m => m.Id == model.Id).FirstOrDefault();

                if(movie == null)
                {
                    var movieAMap = _mapper.Map<MovieModel, MovieAModel>(model);

                    var mov = _mapper.Map<MovieAModel, Movie>(movieAMap);

                    _context.Movies.Add(mov);

                    foreach (var item in model.Genres)
                    {

                        var gen = _mapper.Map<GenreModel, Genre>(item);
                        gen.MovieId = mov.Id;
                        _context.Genres.Add(gen);
                    }

                    foreach (var item in model.Spoken_languages)
                    {
                        var spok = _mapper.Map<SpokenLanguageModel, SpokenLanguage>(item);
                        spok.MovieId = mov.Id;
                        _context.SpokenLanguages.Add(spok);
                    }

                    foreach (var item in model.Production_companies)
                    {
                        var pc = _mapper.Map<ProductionCompanyModel, ProductionCompany>(item);
                        pc.MovieId = mov.Id;
                        _context.ProductionCompanies.Add(pc);
                    }

                    foreach (var item in model.Production_countries)
                    {
                        var pc = _mapper.Map<ProductionCountryModel, ProductionCountry>(item);
                        pc.MovieId = mov.Id;
                        _context.ProductionCountries.Add(pc);
                    }

                    _context.SaveChanges();
                    return Task.FromResult(true);
                }

                return Task.FromResult(true);

            }
            catch (Exception ex)
            {
                return Task.FromResult(false);
            }


        }

        public Task<bool> AddScoreForMovie(MovieScoreModel model)
        {
            _context.MovieScores.Add(new MovieScore()
            {
                MovieId = model.MovieId,
                UserName ="burak.kilic",
                Score = model.Score,
            });

            _context.SaveChanges();

            return Task.FromResult(true);
        }

        public Task<bool> AddCommentForMovie(MovieScoreModel model)
        {
            _context.MovieScores.Add(new MovieScore()
            {
                MovieId = model.MovieId,
                UserName = "burak.kilic",
                Score = model.Score,
            });

            _context.SaveChanges();

            return Task.FromResult(true);
        }

        public Task<bool> AddCommentForMovie(MovieCommentModel model)
        {
            _context.MovieComments.Add(new MovieComment()
            {
                MovieId = model.MovieId,
                UserName = "burak.kilic",
                Note = model.Note,
            });

            _context.SaveChanges();

            return Task.FromResult(true);
        }

        public Task<GetMoviesByIdModel> GetMovieById(int MovieId)
        {
          var movie =   _context.Movies.Include(m => m.MovieScore).Include(m => m.MovieComments).Where(m => m.Id == MovieId).FirstOrDefault();
            var mov = _mapper.Map<Movie, MovieAModel>(movie);

            var res = new GetMoviesByIdModel()
            {
                Movie = mov,
                MovieScore =  movie?.MovieScore?.Score,
                MovieComments = movie?.MovieComments?.Select(s => new MovieCommentModel()
                {
                    UserName = s.UserName,
                    Note = s.Note,
                    MovieId= s.MovieId,
                }).ToList()

            };

            return Task.FromResult(res);
        }

        public Task<List<MovieModel>> GetAllMovies()
        {
            var movie = _context.Movies.Include(m => m.Production_companies).Include(m => m.Production_countries).Include(m => m.Genres).Include(m => m.Spoken_languages).ToList();

            var map = _mapper.Map<List<MovieModel>>(movie);
            return Task.FromResult(map);
        }
    }
}
