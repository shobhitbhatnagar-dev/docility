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
        private readonly DataContext _context;

        public ProjectController(DataContext context)
        {
            _context = context;
        }
    
         // GET api/projects
        [AllowAnonymous]
        [HttpGet]
        public async Task<IActionResult> GetProjects()
        {
            var Projects = await _context.Projects.ToListAsync();

            return Ok(Projects);
        }

         // GET api/projects/id
        [AllowAnonymous]
        [HttpGet("{id}")]
        public async Task<IActionResult> GetProject(int id)
        {
            var Project = await _context.Projects.FirstOrDefaultAsync(x => x.Id == id);

            return Ok(Project);

        }
    }
}