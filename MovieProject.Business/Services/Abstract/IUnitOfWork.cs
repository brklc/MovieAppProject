using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieProject.Business.Services.Abstract
{
    public interface IUnitOfWork
    {
        IMovieRepository Movies { get; }
        Task CompleteAsync();
    }
}
