using System;

namespace DependencyInjection;

public class Teacher : ITeacher
{
  public string FirstName { get; set; }
  public string LastName { get; set; }

  public Teacher(string firstName, string lastName)
  {
    FirstName = firstName;
    LastName = lastName;
  }

  public virtual string GetInfo()
  {
    return $"{FirstName} {LastName}";
  }
}
