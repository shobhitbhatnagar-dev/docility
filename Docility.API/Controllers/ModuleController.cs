using System.Collections.Generic;
using System.Threading.Tasks;
using AutoMapper;
using Docility.API.Data;
using Docility.API.Dtos;
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
        private readonly IMapper _mapper;

        public ModuleController(IDocilityRepository repo, IMapper mapper)
        {
            _mapper = mapper;
            _repo = repo;

        }

        [HttpGet]
        public async Task<IActionResult> GetModules(int projectId)
        {
            var modules = await _repo.GetModules();
            var modulesToReturn = _mapper.Map<IEnumerable<ModuleDetailsDto>>(modules);
            return Ok(modulesToReturn);
        }
        [HttpGet("{id}")]
        public async Task<IActionResult> GetModule(int id)
        {
            var modules = await _repo.GetModule(id);
            var modulesToReturn = _mapper.Map<IEnumerable<ModuleDetailsDto>>(modules);
            return Ok(modulesToReturn);
        }

        [HttpGet("byproject/{id}")]
        public async Task<IActionResult> GetModulesByProject(int id)
        {
            var modules = await _repo.GetModulesByProject(id);
            var modulesToReturn = _mapper.Map<IEnumerable<ModuleByProjectDto>>(modules);
            return Ok(modulesToReturn);
        }
    }
}