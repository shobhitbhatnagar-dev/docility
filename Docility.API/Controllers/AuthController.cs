using System;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;
using Docility.API.Data;
using Docility.API.Dtos;
using Docility.API.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.IdentityModel.Tokens;

namespace Docility.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AuthController : ControllerBase
    {
        private readonly iAuthRepository _repo;
        private readonly IConfiguration _config;
        public AuthController(iAuthRepository repo, IConfiguration config)
        {
            _config = config;
            _repo = repo;

        }

        [HttpPost("register")]
        public async Task<IActionResult> Register(UserforRegisterDto userforRegisterDto)
        {
            //validation request

            userforRegisterDto.Username = userforRegisterDto.Username.ToLower();

            if (await _repo.UserExsists(userforRegisterDto.Username))
                return BadRequest("User Already Exsists");

            var UsertoCreate = new User
            {
                Username = userforRegisterDto.Username,
                EmailId = userforRegisterDto.Email
            };

            var CreatedUser = await _repo.Register(UsertoCreate, userforRegisterDto.Password, userforRegisterDto.Role);
            return StatusCode(201);
        }

        //Login Methord for genrating tokens
        [HttpPost("login")]
        public async Task<ActionResult> Login(UserforLoginDto userForLoginDto)
        {
            var userFormRepo = await _repo.Login(userForLoginDto.Username.ToLower(), userForLoginDto.Password);

            if (userFormRepo == null)
                return Unauthorized("Incorrect Username & Password");

            var claims = new[]
            {
                new Claim(ClaimTypes.NameIdentifier, userFormRepo.Id.ToString()),
                new Claim(ClaimTypes.Name, userFormRepo.Username),
                new Claim(ClaimTypes.Role, userFormRepo.role)
            };

            var key = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(_config.GetSection("AppSettings:Token").Value));

            var creds = new SigningCredentials(key, SecurityAlgorithms.HmacSha512Signature);

            var tokenDescriptor = new SecurityTokenDescriptor
            {
                Subject = new ClaimsIdentity(claims),
                Expires = DateTime.Now.AddDays(1),
                SigningCredentials = creds
            };

            var tokenHandler = new JwtSecurityTokenHandler();

            var token = tokenHandler.CreateToken(tokenDescriptor);

            return Ok(new
            {
                token = tokenHandler.WriteToken(token)
            });
        }

    }
}