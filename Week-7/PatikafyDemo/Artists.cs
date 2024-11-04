using System;

namespace PatikafyDemo;

public class Artists
{
  public string FullName { get; set; }
  public string Genre { get; set; }
  public int Year { get; set; }
  public int Sales { get; set; }

  public Artists(string name, string surname, string genre, int year, int sales)
  {
    FullName = $"{name} {surname}";
    Genre = genre;
    Year = year;
    Sales = sales;
  }

  public override string ToString()
  {
    return $"{FullName} - {Genre} - {Year} - {Sales}";
  }
}
