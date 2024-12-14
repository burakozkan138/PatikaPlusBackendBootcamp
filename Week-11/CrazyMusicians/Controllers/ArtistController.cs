using CrazyMusicians.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CrazyMusicians.Controllers;

[Route("api/[controller]")]
[ApiController]
public class ArtistController : ControllerBase
{
    public static List<Artist> Artists = new(){
        new Artist(1, "Ahmet Çalgı", "Ünlü Çalgı Çalar", "Her zaman yanlış nota çalar, ama çok eğlenceli"),
        new Artist(2, "Zeynep Melodi", "Popüler Melodi Yazarı", "Şarkıları yanlış anlaşılır ama çok popüler"),
        new Artist(3, "Cemil Akor", "Çılgın Akorist", "Akorları sık değiştirir, ama şaşırtıcı derecede yetenekli"),
        new Artist(4, "Fatma Nota", "Sürpriz Nota Üreticisi", "Nota üretirken sürekli sürprizler hazırlar"),
        new Artist(5, "Hasan Ritim", "Ritim Canavarı", "Her ritmi kendi tarzında yapar, hiç uymaz ama komiktir"),
        new Artist(6, "Elif Armoni", "Armoni Ustası", "Armonilerini bazen yanlış çalar, ama çok yaratıcıdır"),
        new Artist(7, "Ali Perde", "Perde Uygulayıcı", "Her perdeyi farklı şekilde çalar, her zaman sürprizlidir"),
        new Artist(8, "Ayşe Rezonans", "Rezonans Uzmanı", "Rezonans konusunda uzman, ama bazen çok gürültü çıkarır"),
        new Artist(9, "Murat Ton", "Tonlama Meraklısı", "Tonlamalarındaki farklılıklar bazen komik, ama oldukça ilginç"),
        new Artist(10, "Selin Akor", "Akor Sihirbazı", "Akorları değiştirdiğinde bazen sihirli bir hava yaratır")
    };

    [HttpGet]
    public ActionResult<List<Artist>> Get()
    {
        return Ok(Artists);
    }

    [HttpGet("{id:int:min(1)}")]
    public ActionResult<Artist> Get([FromRoute] int id)
    {
        var artist = Artists.FirstOrDefault(a => a.Id == id);
        if (artist == null)
        {
            return NotFound();
        }
        return Ok(artist);
    }

    [HttpPost]
    public ActionResult<Artist> Post([FromBody] Artist artist)
    {
        if (!ModelState.IsValid)
        {
            return BadRequest(ModelState);
        }

        artist.Id = Artists.Max(a => a.Id) + 1;
        Artists.Add(artist);

        return CreatedAtAction(nameof(Get), new { id = artist.Id });
    }

    [HttpPut("{id:int:min(1)}")]
    public ActionResult<Artist> Put([FromRoute] int id, [FromBody] Artist artist)
    {
        if (!ModelState.IsValid)
        {
            return BadRequest(ModelState);
        }

        Artist? existingArtist = Artists.FirstOrDefault(a => a.Id == id);
        if (existingArtist == null)
        {
            return NotFound();
        }

        existingArtist.FullName = artist.FullName;
        existingArtist.Job = artist.Job;
        existingArtist.FunFeature = artist.FunFeature;

        return AcceptedAtAction(nameof(Get), new { id = existingArtist.Id });
    }

    [HttpDelete("{id:int:min(1)}")]
    public IActionResult Delete([FromRoute] int id)
    {
        Artist? artist = Artists.FirstOrDefault(a => a.Id == id);
        if (artist == null)
        {
            return NotFound();
        }

        Artists.Remove(artist);

        return Ok($"Artist with id {id} is deleted");
    }

    // GET /api/artist/search?q=melodi
    [HttpGet("search")]
    public ActionResult<List<Artist>> SearchByName([FromQuery] string q)
    {
        if (string.IsNullOrWhiteSpace(q))
        {
            return BadRequest("Search query is required");
        }

        var artists = Artists.Where(a => a.FullName.Contains(q, StringComparison.OrdinalIgnoreCase)).ToList();
        return Ok(artists);
    }

    [HttpPatch("{id:int:min(1)}")]
    public ActionResult<Artist> ChangeName([FromRoute] int id, [FromBody] string name)
    {
        if (string.IsNullOrWhiteSpace(name))
        {
            return BadRequest("Name is required");
        }

        Artist? artist = Artists.FirstOrDefault(a => a.Id == id);
        if (artist == null)
        {
            return NotFound();
        }

        artist.FullName = name;

        return AcceptedAtAction(nameof(Get), new { id = artist.Id }, artist);
    }
}
