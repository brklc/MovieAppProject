using MovieProject.Business.Services.Abstract;
using MovieProject.Entity.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieProject.Business.Services.Concrate
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly MovieProjectContext _movieContext;
        private readonly IServiceProvider _serviceProvider;

        public UnitOfWork(MovieProjectContext context, IServiceProvider serviceProvider)
        {
            _movieContext = context;
            _serviceProvider = serviceProvider;
        }
        public void Dispose()
        {
            _movieContext.Dispose();
        }

        public IRepository<T> GetRepository<T>() where T : class
        {
            return (IRepository<T>)_serviceProvider.GetService(typeof(IRepository<T>));
        }

        public int SaveChanged()
        {
            return _movieContext.SaveChanges();
        }
    }
}
