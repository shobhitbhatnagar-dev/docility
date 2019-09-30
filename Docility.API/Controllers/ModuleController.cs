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
    public class ModuleController : ControllerBase
    {
        private readonly IDocilityRepository _repo;

        public ModuleController(IDocilityRepository repo)
        {
            _repo = repo;

        }

        [HttpGet]
        public async Task<IActionResult> GetModules(int projectId)
        {
            var modules = await _repo.GetModules();
            return Ok(modules);
        }
        [HttpGet("{id}")]
        public async Task<IActionResult> GetModule(int id)
        {
            var module = await _repo.GetModule(id);
            return Ok(module);
        }

        [HttpGet("byproject/{id}")]
        public async Task<IActionResult> GetModulesByProject(int id)
        {
            var module = await _repo.GetModulesByProject(id);
            return Ok(module);
        }
    }
}