using Developers.DataModel.Models;
using Microsoft.AspNetCore.Hosting;

namespace Developers.DataAccess.Repositories.Developers
{
    public class DevelopersRepository : Repository<Developer>, IDevelopersRepository
    {
        public DevelopersRepository(IHostingEnvironment hostingEnvironment) : base(hostingEnvironment) { }
    }
}