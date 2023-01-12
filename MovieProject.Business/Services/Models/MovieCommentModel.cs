using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieProject.Business.Services.Models
{
    public class MovieCommentModel
    {
        public string UserName { get; set; }
        public string Note { get; set; }
        public int MovieId { get; set; }
    }
}
