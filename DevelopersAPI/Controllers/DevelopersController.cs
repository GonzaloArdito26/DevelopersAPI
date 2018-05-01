using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using Developers.Business.Services.Developers;
using Developers.Model.Models.Developers;
using Microsoft.AspNetCore.Mvc;

namespace DevelopersAPI.Controllers
{
    [Route("api/[controller]")]
    public class DevelopersController : Controller
    {
        private readonly IMapper _mapper;
        private readonly IDevelopersService _developersService;

        public DevelopersController(IMapper mapper, IDevelopersService developersService)
        {
            _developersService = developersService;
            _mapper = mapper;
        }

        // GET api/developers
        [HttpGet]
        [Route("")]
        public async Task<IEnumerable<Developer>> GetAllDevelopersAsync()
        {
            var developers = await _developersService.ReadAllAsync();

            return _mapper.Map<IEnumerable<Developers.DataModel.Models.Developer>, IEnumerable<Developer>>(developers).ToList();
        }
    }
}
