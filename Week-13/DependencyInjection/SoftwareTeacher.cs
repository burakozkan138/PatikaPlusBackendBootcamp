using System;

namespace DependencyInjection;

public class SoftwareTeacher : Teacher
{
  public string Language { get; set; }
  public SoftwareTeacher(string firstName, string lastName, string language) : base(firstName, lastName)
  {
    Language = language;
  }

  public override string GetInfo()
  {
    return $"{base.GetInfo()} - {Language}";
  }
}
