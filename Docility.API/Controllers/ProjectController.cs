using System.Linq;
using System.Threading.Tasks;
using Docility.API.Data;
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

        public ProjectController(IDocilityRepository repo)
        {
            _repo = repo;

        }

        // GET api/projects
        [AllowAnonymous]
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