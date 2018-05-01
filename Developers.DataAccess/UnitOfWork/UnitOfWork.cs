using Developers.DataAccess.Repositories.Developers;
using System;
using System.Threading.Tasks;

namespace Developers.DataAccess.UnitOfWork
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly IDevelopersRepository _developersRepository;

        public IDevelopersRepository DevelopersRepository
        {
            get
            {
                return _developersRepository;
            }
        }

        public UnitOfWork(IDevelopersRepository developersRepo)
        {
            _developersRepository = developersRepo;
        }

        public void Complete()
        {
            // In case later a different way of storing the data is implemented
        }

        public async void CompleteAsync()
        {
            await Task.Run(() => Complete());
        }
    }
}