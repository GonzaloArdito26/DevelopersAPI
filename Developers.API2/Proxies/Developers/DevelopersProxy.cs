using Developers.Model.Models.Developers;
using Microsoft.Extensions.Configuration;
using RestSharp;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Developers.API2.Proxies.Developers
{
    public class DevelopersProxy : Proxy, IDevelopersProxy
    {        

        public DevelopersProxy(IConfiguration config, IRestClient restClient) : base(restClient)
        {
            configuration = config;
        }

        public async Task<IRestResponse<List<Developer>>> GetTopLevelDevelopers()
        {
            var request = new RestRequest("api/Developers/TopLevel");

            var response = await Task.Run(() => client.Execute<List<Developer>>(request));

            return response;
        }
    }
}