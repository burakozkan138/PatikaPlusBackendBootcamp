using System;

namespace AbstractionExample;

public abstract class Employee
{
  public string Name { get; set; }
  public string SurName { get; set; }

  public Employee(string name, string surName)
  {
    Name = name;
    SurName = surName;
  }

  public abstract void Work();

  public void ShowInfo()
  {
    Console.WriteLine($"Name: {Name} Surname: {SurName}");
  }
}
