using System.Collections.Generic;
using System.Threading.Tasks;
using AutoMapper;
using Docility.API.Data;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace Docility.API.Controllers
{
    [Authorize]
    [Route("api/[controller]")]
    [ApiController]
    public class BugController : ControllerBase
    {
        private readonly IDocilityRepository _repo;
        private readonly IMapper _mapper;

        public BugController(IDocilityRepository repo, IMapper mapper)
        {
            _mapper = mapper;
            _repo = repo;

        }

          [HttpGet]
        public async Task<IActionResult> GetBugs()
        {
            var bugs = await _repo.GetBugs();
            return Ok(bugs);
        }
        [HttpGet("{id}")]
        public async Task<IActionResult> GetModule(int id)
        {
            var bug = await _repo.GetModule(id);
            return Ok(bug);
        }

    }
}