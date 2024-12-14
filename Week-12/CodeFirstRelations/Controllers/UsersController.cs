using CodeFirstRelations.Database;
using CodeFirstRelations.Dtos;
using CodeFirstRelations.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace CodeFirstRelations.Controllers;

[Route("api/[controller]")]
[ApiController]
public class UsersController : ControllerBase
{
    private readonly PatikaSecondDbContext _context;
    public UsersController(PatikaSecondDbContext context)
    {
        _context = context;
    }

    [HttpGet]
    public ActionResult<List<User>> Get()
    {
        return Ok(_context.Users.ToList());
    }

    [HttpPost]
    public ActionResult<User> Post(CreateUserDto user)
    {
        User newUser = new User
        {
            Username = user.Username,
            Email = user.Email
        };
        _context.Users.Add(newUser);
        _context.SaveChanges();

        return Created();
    }
}
