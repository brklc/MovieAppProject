using Microsoft.Extensions.Logging;
using MovieProject.Business.Services.Abstract;
using MovieProject.Entity.Context;

namespace MovieProject.Business.Services.Concrate
{
    public class UnitOfWork : IUnitOfWork, IDisposable
    {
        private readonly MovieProjectContext _context;
        private readonly ILogger _logger;

        public IMovieRepository Movies { get; private set; }

        public UnitOfWork(MovieProjectContext context, ILoggerFactory loggerFactory)
        {
            _context = context;
            _logger = loggerFactory.CreateLogger("logs");

            Movies = new MovieRepository(context, _logger);
        }

        public async Task CompleteAsync()
        {
            await _context.SaveChangesAsync();
        }

        public void Dispose()
        {
            _context.Dispose();
        }
    }
}
