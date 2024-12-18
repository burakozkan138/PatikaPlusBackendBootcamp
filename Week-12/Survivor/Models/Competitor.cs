using System;

namespace Survivor.Models;

public class Competitor : BaseEntity
{
  public string Name { get; set; }
  public string Surname { get; set; }
  public int CategoryId { get; set; }
  public Category Category { get; set; }
}
