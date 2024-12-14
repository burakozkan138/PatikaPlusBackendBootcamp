using CodeFirstBasic.Database;
using CodeFirstBasic.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CodeFirstBasic.Controllers;

[Route("api/[controller]")]
[ApiController]
public class GamesController : ControllerBase
{
    private readonly PatikaFirstDbContext _context;

    public GamesController(PatikaFirstDbContext context)
    {
        _context = context;
    }

    [HttpGet]
    public ActionResult<List<Game>> GetAllGames()
    {
        return Ok(_context.Games.ToList());
    }

    [HttpGet("{id}")]
    public ActionResult<Game> GetGameById(int id)
    {
        Game? game = _context.Games.Find(id);

        if (game == null)
        {
            return NotFound();
        }

        return Ok(game);
    }

    [HttpPost]
    public ActionResult<Game> CreateGame([FromBody] Game game)
    {
        _context.Games.Add(game);
        _context.SaveChanges();

        return CreatedAtAction(nameof(GetGameById), new { id = game.Id }, game);
    }

    [HttpPut("{id}")]
    public IActionResult UpdateGame(int id, [FromBody] Game game)
    {
        Game? existingGame = _context.Games.Find(id);

        if (existingGame == null)
        {
            return NotFound();
        }

        existingGame.Name = game.Name;
        existingGame.Platform = game.Platform;
        existingGame.Rating = game.Rating;

        _context.SaveChanges();

        return NoContent();
    }

    [HttpDelete("{id}")]
    public IActionResult DeleteGame(int id)
    {
        Game? game = _context.Games.Find(id);

        if (game == null)
        {
            return NotFound();
        }

        _context.Games.Remove(game);
        _context.SaveChanges();

        return NoContent();
    }
}

