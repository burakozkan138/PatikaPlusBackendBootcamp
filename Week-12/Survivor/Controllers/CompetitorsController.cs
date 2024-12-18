using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Survivor.Database;
using Survivor.Dtos.Competitors;
using Survivor.Models;

namespace Survivor.Controllers;

[Route("api/[controller]")]
[ApiController]
public class CompetitorController : ControllerBase
{
    private readonly SurvivorDbContext _context;

    public CompetitorController(SurvivorDbContext context)
    {
        _context = context;
    }

    [HttpGet]
    public async Task<ActionResult<List<Competitor>>> GetAllCompetitors()
    {
        return await _context.Competitors.Where(c => !c.IsDeleted).ToListAsync();
    }

    [HttpGet("{id}")]
    public async Task<ActionResult<Competitor>> GetCompetitor([FromRoute] int id)
    {
        Competitor? competitor = await _context.Competitors.Where(c => !c.IsDeleted).FirstOrDefaultAsync(c => c.Id == id);

        if (competitor == null)
        {
            return NotFound();
        }

        return competitor;
    }

    [HttpGet("categories/{CategoryId}")]
    public async Task<ActionResult<List<Competitor>>> GetCompetitorsByCategory([FromRoute] int CategoryId)
    {
        return await _context.Competitors.Where(c => (c.CategoryId == CategoryId && !c.IsDeleted)).ToListAsync();
    }

    [HttpPost]
    public async Task<ActionResult<Competitor>> CreateCompetitor([FromBody] CreateCompetitorDto newCompetitor)
    {
        if (!ModelState.IsValid)
        {
            return BadRequest(ModelState);
        }

        Competitor competitor = new()
        {
            Name = newCompetitor.Name,
            Surname = newCompetitor.Surname,
            CategoryId = newCompetitor.CategoryId
        };

        await _context.Competitors.AddAsync(competitor);
        await _context.SaveChangesAsync();

        return CreatedAtAction(nameof(GetCompetitor), new { id = competitor.Id }, competitor);
    }

    [HttpPut("{id}")]
    public async Task<IActionResult> UpdateCompetitor([FromRoute] int id, [FromBody] UpdateCompetitorDto updatedCompetitor)
    {
        if (!ModelState.IsValid)
        {
            return BadRequest(ModelState);
        }

        Competitor? competitor = await _context.Competitors.Where(c => !c.IsDeleted).FirstOrDefaultAsync(c => c.Id == id);

        if (competitor == null)
        {
            return NotFound();
        }

        competitor.Name = updatedCompetitor.Name ?? competitor.Name;
        competitor.Surname = updatedCompetitor.Surname ?? competitor.Surname;
        competitor.CategoryId = updatedCompetitor.CategoryId ?? competitor.CategoryId;

        await _context.SaveChangesAsync();

        return NoContent();
    }

    [HttpDelete("{id}")]
    public async Task<IActionResult> DeleteCompetitor([FromRoute] int id)
    {
        Competitor? competitor = await _context.Competitors.Where(c => !c.IsDeleted).FirstOrDefaultAsync(c => c.Id == id);

        if (competitor == null)
        {
            return NotFound();
        }

        competitor.IsDeleted = true;
        await _context.SaveChangesAsync();

        return NoContent();
    }
}