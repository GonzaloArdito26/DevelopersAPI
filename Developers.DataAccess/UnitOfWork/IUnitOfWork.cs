using Developers.DataAccess.Repositories.Developers;

namespace Developers.DataAccess.UnitOfWork
{
    public interface IUnitOfWork
    {
        IDevelopersRepository DevelopersRepository { get; }

        void Complete();
        void CompleteAsync();
    }
}