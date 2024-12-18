using System;
using System.ComponentModel.DataAnnotations;

namespace Survivor.Dtos.Categories;

public class CreateCategoryDto
{
  [Required(ErrorMessage = "Name is required")]
  [MinLength(3, ErrorMessage = "Name can't be shorter than 3 characters")]
  [MaxLength(50, ErrorMessage = "Name can't be longer than 50 characters")]
  public string Name { get; set; }
}
