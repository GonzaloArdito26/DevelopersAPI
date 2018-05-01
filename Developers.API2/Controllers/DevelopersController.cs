using System.Collections.Generic;
using System.Threading.Tasks;
using Developers.Model.Models.Developers;
using Microsoft.AspNetCore.Mvc;

namespace Developers.API2.Controllers
{
    [Route("api/[controller]")]
    public class DevelopersController : Controller
    {
        // GET api/Developers/TopLevel
        [HttpGet]
        [Route("TopLevel")]
        public async Task<IEnumerable<Developer>> GetTopLevelDevelopersAsync()
        {
            return await Task.Run(() => new List<Developer>() );
        }
    }
}
