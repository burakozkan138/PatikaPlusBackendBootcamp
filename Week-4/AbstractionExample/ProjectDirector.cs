using System;

namespace AbstractionExample;

public class ProjectDirector : Employee
{
  public ProjectDirector(string name, string surName) : base(name, surName)
  {
  }

  public override void Work()
  {
    Console.WriteLine("Proje yöneticisi olarak çalışıyorum.");
  }
}
