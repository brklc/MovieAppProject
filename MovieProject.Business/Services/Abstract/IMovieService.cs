using MovieProject.Business.Services.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieProject.Business.Services.Abstract
{
    public interface IMovieService
    {
        public Task Post(MovieModel model);
    }
}
