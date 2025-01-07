using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;
using JwtExample.Database;
using JwtExample.Dtos;
using JwtExample.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.IdentityModel.Tokens;

namespace JwtExample.Controllers;

[Route("api/[controller]")]
[ApiController]
public class AuthController : ControllerBase
{
    private readonly ApplicationDbContext _context;
    private readonly IConfiguration _configuration;

    public AuthController(ApplicationDbContext context, IConfiguration configuration)
    {
        _context = context;
        _configuration = configuration;
    }

    [HttpGet("home")]
    [Authorize]
    public IActionResult Home()
    {
        return Ok("Welcome To Home Page");
    }

    [HttpPost("register")]
    public IActionResult Register([FromBody] RegisterDto newUser)
    {
        if (!ModelState.IsValid)
        {
            return BadRequest();
        }

        User user = new User
        {
            Email = newUser.Email,
            Password = BCrypt.Net.BCrypt.HashPassword(newUser.Password)
        };

        _context.Users.Add(user);
        _context.SaveChanges();

        return Created();
    }

    [HttpPost("login")]
    public IActionResult Login([FromBody] LoginDto login)
    {
        if (!ModelState.IsValid)
        {
            return BadRequest();
        }

        User? user = _context.Users.FirstOrDefault(u => u.Email == login.Email);
        if (user is null)
            return BadRequest("parola vaya email hatali");


        bool isValidPassword = BCrypt.Net.BCrypt.Verify(login.Password, user.Password);
        if (!isValidPassword)
        {
            return Unauthorized();
        }

        string token = GenerateToken(user.Id, user.Email);

        return Ok(token);
    }


    private string GenerateToken(int id, string email)
    {
        Claim[] claims = new[]{
            new Claim(ClaimTypes.Name,id.ToString()),
            new Claim(ClaimTypes.Email,email)
        };

        var secretkey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(_configuration["Jwt:Secret"]));
        var creds = new SigningCredentials(secretkey, SecurityAlgorithms.HmacSha256);

        var token = new JwtSecurityToken(
                    issuer: _configuration["Jwt:Issuer"],
                    audience: _configuration["Jwt:Audience"],
                    claims: claims,
                    expires: DateTime.Now.AddHours(1),
                    signingCredentials: creds);

        return new JwtSecurityTokenHandler().WriteToken(token);
    }
}
