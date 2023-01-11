using MovieProject.Entity.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace MovieProject.Business.Services.Abstract
{
    public interface IMovieRepository : IGenericRepository<Movie>
    {
    }
}
