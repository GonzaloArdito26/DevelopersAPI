using Developers.DataAccess.UnitOfWork;

namespace Developers.Business.Services
{
    public class BaseService : IBaseService
    {
        // TODO: Should have a logger

        protected IUnitOfWork unitOfWork;

        public BaseService() { }        
    }
}