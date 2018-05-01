using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Developers.API2.Proxies.Developers;
using Developers.Model.Models.Developers;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;

namespace Developers.API2.Controllers
{
    [Route("api/[controller]")]
    public class DevelopersController : Controller
    {        
        private readonly IDevelopersProxy _developersProxy;

        public DevelopersController(IDevelopersProxy developersProxy)
        {            
            _developersProxy = developersProxy;
        }

        // GET api/Developers/TopLevel
        [HttpGet]
        [Route("TopLevel")]
        public async Task<IEnumerable<Developer>> GetTopLevelDevelopersAsync()
        {
            var result = await _developersProxy.GetTopLevelDevelopers();

            return result.Data.Where(d => d.Skills.Any(s => s.Level >= 8)).Select(d => new Developer
            {
                FirstName = d.FirstName,
                LastName = d.LastName,
                Age = d.Age,
                Skills = d.Skills.Where(sk => d.Skills.Where(skill => skill.Level >= 8).Select(skill => skill.Type).Contains(sk.Type))
            })
            .ToList();
        }
    }
}