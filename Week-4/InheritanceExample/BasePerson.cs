using System;

namespace InheritanceExample;

public class BasePerson // Base class for Teacher and Student classes
{

  public string Name { get; set; } // base class properties
  public string Surname { get; set; }

  public BasePerson(string name, string surname) // base class constructor
  {
    Name = name;
    Surname = surname;
  }

  public virtual void Print() // base class print method marked as virtual to be overridden by derived classes
  {
    Console.WriteLine($"Name: {Name}, Surname: {Surname}");
  }
}
