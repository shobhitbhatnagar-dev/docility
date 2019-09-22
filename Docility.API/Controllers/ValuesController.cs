using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Docility.API.Data;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Docility.API.Controllers
{

    [Route("api/[controller]")]
    [ApiController]
    public class ValuesController : ControllerBase
    {
        private readonly DataContext _context;

        public ValuesController(DataContext context)
        {
            _context = context;
        }
        [AllowAnonymous]
        // GET api/values
        [HttpGet]
        public async Task<IActionResult> GetValues()
        {
            var values = await _context.Values.ToListAsync();
            return Ok(values);
        }

        // GET api/values/5
        [HttpGet("{type}")]
        public async Task<IActionResult> GetValue(int type)
        {
           var values = await _context.Values.Where(x => x.Type == type ).ToListAsync();

           return Ok(values);
        }
    }
}
