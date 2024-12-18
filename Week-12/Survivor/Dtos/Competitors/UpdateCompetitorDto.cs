using System;

namespace Survivor.Dtos.Competitors;
using System.ComponentModel.DataAnnotations;

public class UpdateCompetitorDto
{
  [StringLength(50, MinimumLength = 3, ErrorMessage = "Name must be between 3 and 50 characters.")]
  public string? Name { get; set; }
  [StringLength(50, MinimumLength = 3, ErrorMessage = "Surname must be between 3 and 50 characters.")]
  public string? Surname { get; set; }

  [Range(1, int.MaxValue, ErrorMessage = "CategoryId must be a positive number.")]
  public int? CategoryId { get; set; }
}
