using System;

namespace DependencyInjection;

public class Classrom
{
  public ITeacher Teacher { get; set; }

  public Classrom(ITeacher teacher)
  {
    Teacher = teacher;
  }

  public void GetTeacherInfo()
  {
    Console.WriteLine(Teacher.GetInfo());
  }
}
