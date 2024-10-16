using System;

namespace AbstractionExample;

public class SoftwareDeveloper : Employee
{
  public SoftwareDeveloper(string name, string surName) : base(name, surName)
  {
  }

  public override void Work()
  {
    Console.WriteLine("Yazılım geliştirici olarak çalışıyorum.");
  }
}
