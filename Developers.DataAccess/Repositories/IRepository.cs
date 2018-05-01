using System.Collections.Generic;
using System.Threading.Tasks;

namespace Developers.DataAccess.Repositories
{
    public interface IRepository<T> where T : class
    {
        IEnumerable<T> ReadAll();
        Task<IEnumerable<T>> ReadAllAsync();
    }
}