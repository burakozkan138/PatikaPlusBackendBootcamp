using System;

namespace IMDBDemo;

public class Movie
{
  public string Name { get; set; }
  public double Rating { get; set; }

  public Movie(string name, double rating)
  {
    Name = name;
    Rating = rating;
  }

  public override string ToString()
  {
    return $"Name: {Name}, Rating: {Rating}";
  }
}
