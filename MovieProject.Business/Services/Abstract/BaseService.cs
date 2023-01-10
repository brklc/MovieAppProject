using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieProject.Business.Services.Abstract
{
    public abstract class BaseService
    {
        #region Private Fields

        protected readonly IUnitOfWork _unitOfWork;
        protected readonly IMapper _mapper;
        #endregion Private Fields

        #region Public Constructors
        public BaseService(IServiceProvider serviceProvider)
        {
            _unitOfWork = (IUnitOfWork)serviceProvider.GetService(typeof(IUnitOfWork));
            _mapper = (IMapper)serviceProvider.GetService(typeof(IMapper));
        }
        #endregion Public Constructors
    }
}
