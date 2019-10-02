using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using Docility.API.Data;
using Docility.API.Dtos;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Docility.API.Controllers
{
    [Authorize]
    [Route("api/[controller]")]
    [ApiController]
    public class ProjectController : ControllerBase
    {

        private readonly IDocilityRepository _repo;
        private readonly IMapper _mapper;

        public ProjectController(IDocilityRepository repo, IMapper mapper)
        {
            _mapper = mapper;
            _repo = repo;

        }

        // GET api/projects
        [HttpGet]
        public async Task<IActionResult> GetProjects()
        {
            var Projects = await _repo.GetProjects();
            return Ok(Projects);
        }

        // GET api/projects/id
        [HttpGet("{id}")]
        public async Task<IActionResult> GetProject(int id)
        {
            var Project = await _repo.GetProject(id);
            return Ok(Project);

        }
    }
}