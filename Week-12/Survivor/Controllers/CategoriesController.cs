using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Survivor.Database;
using Survivor.Dtos.Categories;
using Survivor.Models;

namespace Survivor.Controllers;

[Route("api/[controller]")]
[ApiController]
public class CategoryController : ControllerBase
{
    private readonly SurvivorDbContext _context;

    public CategoryController(SurvivorDbContext context)
    {
        _context = context;
    }

    [HttpGet]
    public async Task<ActionResult<List<Category>>> GetAllCategories()
    {
        return await _context.Categories.Where(c => !c.IsDeleted).ToListAsync();
    }

    [HttpGet("{id}")]
    public async Task<ActionResult<Category>> GetCategory([FromRoute] int id)
    {
        Category? category = await _context.Categories.Where(c => !c.IsDeleted).FirstOrDefaultAsync(c => c.Id == id);

        if (category == null)
        {
            return NotFound();
        }

        return category;
    }

    [HttpPost]
    public async Task<ActionResult<Category>> CreateCategory([FromBody] CreateCategoryDto newCategory)
    {
        if (!ModelState.IsValid)
        {
            return BadRequest(ModelState);
        }

        Category category = new()
        {
            Name = newCategory.Name
        };

        await _context.Categories.AddAsync(category);
        await _context.SaveChangesAsync();

        return CreatedAtAction(nameof(GetCategory), new { id = category.Id }, category);
    }

    [HttpPut("{id}")]
    public async Task<IActionResult> UpdateCategory([FromRoute] int id, [FromBody] UpdateCategoryDto updatedCategory)
    {
        if (!ModelState.IsValid)
        {
            return BadRequest(ModelState);
        }

        Category? category = await _context.Categories.Where(c => !c.IsDeleted).FirstOrDefaultAsync(c => c.Id == id);

        if (category == null)
        {
            return NotFound();
        }

        category.Name = updatedCategory.Name ?? category.Name;

        await _context.SaveChangesAsync();

        return NoContent();
    }

    [HttpDelete("{id}")]
    public async Task<IActionResult> DeleteCategory([FromRoute] int id)
    {
        Category? category = await _context.Categories.Where(c => !c.IsDeleted).FirstOrDefaultAsync(c => c.Id == id);

        if (category == null)
        {
            return NotFound();
        }

        category.IsDeleted = true;
        await _context.SaveChangesAsync();

        return NoContent();
    }
}