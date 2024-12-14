using CodeFirstRelations.Database;
using CodeFirstRelations.Dtos;
using CodeFirstRelations.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CodeFirstRelations.Controllers;

[Route("api/[controller]")]
[ApiController]
public class PostsController : ControllerBase
{
    private readonly PatikaSecondDbContext _context;
    public PostsController(PatikaSecondDbContext context)
    {
        _context = context;
    }

    [HttpGet]
    public ActionResult<List<Post>> Get()
    {
        return Ok(_context.Posts.ToList());
    }

    [HttpPost]
    public ActionResult<Post> Post(CreatePostDto post)
    {
        Post newPost = new Post
        {
            Title = post.Title,
            Content = post.Content,
            UserId = post.UserId
        };
        _context.Posts.Add(newPost);
        _context.SaveChanges();

        return Created();
    }
}
