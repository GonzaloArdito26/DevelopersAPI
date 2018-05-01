using Microsoft.Extensions.Configuration;
using RestSharp;
using System;

namespace Developers.API2.Proxies
{
    public class Proxy
    {
        protected IConfiguration configuration;
        protected IRestClient client = null;

        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="restClient"></param>
        public Proxy(IRestClient restClient)
        {
            string uri = configuration["applicationUrl"];

            restClient.BaseUrl = new Uri(uri);

            client = restClient;
        }
    }
}