using System;
using System.Security.Cryptography;

namespace InheritanceExample;

public class Teacher : BasePerson
{
  public string Salary { get; set; }

  public Teacher(string name, string surname) : base(name, surname)
  {
    Salary = new Random().Next(17000, 45000).ToString();
  }

  public override void Print() // overriding the base class print method
  {
    Console.WriteLine($"Name: {Name}, Surname: {Surname}, Salary: {Salary} TL");
  }
}
