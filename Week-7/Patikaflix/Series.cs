using System;

namespace Patikaflix;

public class Series
{
  public string Name { get; set; }
  public int StartYear { get; set; }
  public string Genre { get; set; }
  public int ReleaseYear { get; set; }
  public string Director { get; set; }
  public string Platform { get; set; }

  public Series(string name, int startYear, string genre, int releaseYear, string director, string platform)
  {
    Name = name;
    StartYear = startYear;
    Genre = genre;
    ReleaseYear = releaseYear;
    Director = director;
    Platform = platform;
  }

  public override string ToString()
  {
    return $"Name: {Name} - Start Year: {StartYear} - Genre: {Genre} - Release Year: {ReleaseYear} - Director: {Director} - Platform: {Platform}";
  }
}
