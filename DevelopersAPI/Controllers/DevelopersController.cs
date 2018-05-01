using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace DevelopersAPI.Controllers
{
    [Route("api/[controller]")]
    public class DevelopersController : Controller
    {
        // GET api/developers
        [HttpGet]
        [Route("")]
        public async Task<IEnumerable<string>> GetAllDevelopers()
        {
            return await Task.Run(() => new string[] { "Dev1", "Dev2" });
        }
    }
}
