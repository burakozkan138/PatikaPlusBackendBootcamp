using System;

namespace Patikaflix;

public class ComedySeries
{
  public string Name { get; set; }
  public string Genre { get; set; }
  public string Director { get; set; }

  public ComedySeries(string name, string director)
  {
    Name = name;
    Genre = "Comedy";
    Director = director;
  }

  public override string ToString()
  {
    return $"Name: {Name} - Genre: {Genre} - Director: {Director}";
  }
}
