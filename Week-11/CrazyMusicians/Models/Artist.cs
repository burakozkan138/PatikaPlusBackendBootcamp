using System;
using System.ComponentModel.DataAnnotations;

namespace CrazyMusicians.Models;

public class Artist
{
  public int Id { get; set; }
  [Required(ErrorMessage = "Full name is required")]
  public string FullName { get; set; } = "No name";
  [Required(ErrorMessage = "Job is required")]
  public string Job { get; set; } = "No job";
  [Required(ErrorMessage = "Fun feature is required")]
  public string FunFeature { get; set; } = "No fun feature";

  public Artist(int id, string fullName, string job, string funFeature)
  {
    Id = id;
    FullName = fullName;
    Job = job;
    FunFeature = funFeature;
  }
}
