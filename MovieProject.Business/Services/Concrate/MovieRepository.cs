using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using MovieProject.Business.Services.Abstract;
using MovieProject.Entity.Context;
using MovieProject.Entity.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieProject.Business.Services.Concrate
{
    public class MovieRepository : GenericRepository<Movie>, IMovieRepository
    {
        public MovieRepository(MovieProjectContext context, ILogger logger) : base(context, logger) { }

        public override async Task<IEnumerable<Movie>> All()
        {
            try
            {
                return await dbSet.ToListAsync();
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "{Repo} All function error", typeof(MovieRepository));
                return new List<Movie>();
            }
        }
    }
}
