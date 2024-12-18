using System;
using System.ComponentModel.DataAnnotations;

namespace Survivor.Dtos.Competitors;

public class CreateCompetitorDto
{
  [Required(ErrorMessage = "Name is required")]
  [StringLength(50, MinimumLength = 3, ErrorMessage = "Name must be between 3 and 50 characters.")]
  public string Name { get; set; }
  [Required(ErrorMessage = "Surname is required")]
  [StringLength(50, MinimumLength = 3, ErrorMessage = "Surname must be between 3 and 50 characters.")]
  public string Surname { get; set; }
  [Required(ErrorMessage = "CategoryId is required")]
  [Range(1, int.MaxValue, ErrorMessage = "CategoryId must be greater than 0")]
  public int CategoryId { get; set; }
}
