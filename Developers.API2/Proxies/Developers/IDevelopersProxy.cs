using Developers.Model.Models.Developers;
using RestSharp;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Developers.API2.Proxies.Developers
{
    public interface IDevelopersProxy
    {
        Task<IRestResponse<List<Developer>>> GetTopLevelDevelopers();
    }
}