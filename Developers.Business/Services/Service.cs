using Developers.DataAccess.UnitOfWork;

namespace Developers.Business.Services
{
    public class BaseService : IService
    {
        protected IUnitOfWork unitOfWork;

        public BaseService() { }        
    }
}