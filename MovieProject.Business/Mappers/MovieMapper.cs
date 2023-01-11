using AutoMapper;
using MovieProject.Business.Services.Models;
using MovieProject.Entity.Models;

namespace MovieProject.Business.Mappers
{
    public class MovieMapper : Profile
    {
        public MovieMapper()
        {
            CreateMap<Movie, MovieModel>();
       
            //.ForMember(dest => dest.Id, t => t.MapFrom(z => z.Id))
            //.ForMember(dest => dest.Tagline, t => t.MapFrom(z => z.Tagline))
            //.ForMember(dest => dest.Revenue, t => t.MapFrom(z => z.Revenue))
            //.ForMember(dest => dest.Overview, t => t.MapFrom(z => z.Overview))
            //.ForMember(dest => dest.Video, t => t.MapFrom(z => z.Video))
            //.ForMember(dest => dest.Adult, t => t.MapFrom(z => z.Adult))
            //.ForMember(dest => dest.Backdrop_path, t => t.MapFrom(z => z.Backdrop_path))
            //.ForMember(dest => dest.Budget, t => t.MapFrom(z => z.Budget))
            //.ForMember(dest => dest.Homepage, t => t.MapFrom(z => z.Homepage))
            //.ForMember(dest => dest.Imdb_id, t => t.MapFrom(z => z.Imdb_id))
            //.ForMember(dest => dest.Original_language, t => t.MapFrom(z => z.Original_language))
            //.ForMember(dest => dest.Original_title, t => t.MapFrom(z => z.Original_title))
            //.ForMember(dest => dest.Popularity, t => t.MapFrom(z => z.Popularity))
            //.ForMember(dest => dest.Poster_path, t => t.MapFrom(z => z.Poster_path))
            //.ForMember(dest => dest.Release_date, t => t.MapFrom(z => z.Release_date))
            //.ForMember(dest => dest.Runtime, t => t.MapFrom(z => z.Runtime))
            //.ForMember(dest => dest.Status, t => t.MapFrom(z => z.Status))
            //.ForMember(dest => dest.Vote_count, t => t.MapFrom(z => z.Vote_count))
            //.ForMember(dest => dest.Vote_average, t => t.MapFrom(z => z.Vote_average))
            // .ForAllOtherMembers(x => x.Ignore());


            CreateMap<MovieModel, Movie>();

            CreateMap<BelongsToCollection, BelongsToCollectionModel>();
            CreateMap<BelongsToCollectionModel, BelongsToCollection>();

            CreateMap<Genre, GenreModel>();
            CreateMap<GenreModel, Genre>();

            CreateMap<Movie, MovieModel>();
            CreateMap<MovieModel, Movie>();

            CreateMap<ProductionCompany, ProductionCompanyModel>();
            CreateMap<ProductionCompanyModel, ProductionCompany>();

            CreateMap<ProductionCountry, ProductionCountryModel>();
            CreateMap<ProductionCountryModel, ProductionCountry>();

            CreateMap<SpokenLanguage, SpokenLanguageModel>();
            CreateMap<SpokenLanguageModel, SpokenLanguage>();
            //   .ForMember(dest => dest.Id, t => t.MapFrom(z => z.Id))
            //.ForMember(dest => dest.Tagline, t => t.MapFrom(z => z.Tagline))
            //.ForMember(dest => dest.Revenue, t => t.MapFrom(z => z.Revenue))
            //.ForMember(dest => dest.Overview, t => t.MapFrom(z => z.Overview))
            //.ForMember(dest => dest.Video, t => t.MapFrom(z => z.Video))
            //.ForMember(dest => dest.Adult, t => t.MapFrom(z => z.Adult))
            //.ForMember(dest => dest.Backdrop_path, t => t.MapFrom(z => z.Backdrop_path))
            //.ForMember(dest => dest.Budget, t => t.MapFrom(z => z.Budget))
            //.ForMember(dest => dest.Homepage, t => t.MapFrom(z => z.Homepage))
            //.ForMember(dest => dest.Imdb_id, t => t.MapFrom(z => z.Imdb_id))
            //.ForMember(dest => dest.Original_language, t => t.MapFrom(z => z.Original_language))
            //.ForMember(dest => dest.Original_title, t => t.MapFrom(z => z.Original_title))
            //.ForMember(dest => dest.Popularity, t => t.MapFrom(z => z.Popularity))
            //.ForMember(dest => dest.Poster_path, t => t.MapFrom(z => z.Poster_path))
            //.ForMember(dest => dest.Release_date, t => t.MapFrom(z => z.Release_date))
            //.ForMember(dest => dest.Runtime, t => t.MapFrom(z => z.Runtime))
            //.ForMember(dest => dest.Status, t => t.MapFrom(z => z.Status))
            //.ForMember(dest => dest.Vote_count, t => t.MapFrom(z => z.Vote_count))
            //.ForMember(dest => dest.Vote_average, t => t.MapFrom(z => z.Vote_average))
            //    .ForAllOtherMembers(x => x.Ignore());
        }

    }
}
