using CodeFirstBasic.Database;
using CodeFirstBasic.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CodeFirstBasic.Controllers;

[Route("api/[controller]")]
[ApiController]
public class MoviesController : ControllerBase
{
    private readonly PatikaFirstDbContext _context;

    public MoviesController(PatikaFirstDbContext context)
    {
        _context = context;
    }

    [HttpGet]
    public ActionResult<List<Movie>> GetAllMovies()
    {
        return Ok(_context.Movies.ToList());
    }

    [HttpGet("{id}")]
    public ActionResult<Movie> GetMovieById(int id)
    {
        Movie? movie = _context.Movies.Find(id);

        if (movie == null)
        {
            return NotFound();
        }

        return Ok(movie);
    }

    [HttpPost]
    public ActionResult<Movie> CreateMovie([FromBody] Movie movie)
    {
        _context.Movies.Add(movie);
        _context.SaveChanges();

        return CreatedAtAction(nameof(GetMovieById), new { id = movie.Id }, movie);
    }

    [HttpPut("{id}")]
    public IActionResult UpdateMovie(int id, [FromBody] Movie movie)
    {
        Movie? existingMovie = _context.Movies.Find(id);

        if (existingMovie == null)
        {
            return NotFound();
        }

        existingMovie.Title = movie.Title;
        existingMovie.Genre = movie.Genre;
        existingMovie.ReleaseYear = movie.ReleaseYear;

        _context.Movies.Update(existingMovie);
        _context.SaveChanges();

        return NoContent();
    }


    [HttpDelete("{id}")]
    public IActionResult DeleteMovie(int id)
    {
        Movie? movie = _context.Movies.Find(id);

        if (movie == null)
        {
            return NotFound();
        }

        _context.Movies.Remove(movie);
        _context.SaveChanges();

        return NoContent();
    }
}
