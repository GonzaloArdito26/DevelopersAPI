using System.Collections.Generic;

namespace Developers.DataAccess.Repositories
{
    public interface IRepository<T> where T : class
    {
        IEnumerable<T> ReadAll();
    }
}