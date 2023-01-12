using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieProject.Business.Services.Models
{
    public class MovieScoreModel
    {
        public string Note { get; set; }

        [Range(1, 10, ErrorMessage = "1-10 arası olabilir")]
        public int Score { get; set; }
        public int MovieId { get; set; }
    }
}
