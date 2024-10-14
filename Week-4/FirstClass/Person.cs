using System;

namespace FirstClass;

public class Person
{
  // person fields
  private string _name; // private name field
  private string _surname; // private surname field
  private int _age; // private age field


  public string Name
  {
    get => _name;
    set => _name = (value.Length > 2 && value.Length < 50) ? value : ""; // if value is between 2 and 50, set it to _name but if not, set it to ""
  }

  public string Surname
  {
    get => _surname;
    set => _surname = (value.Length > 2 && value.Length < 50) ? value : ""; // if value is between 2 and 50, set it to _sruname but if not, set it to ""
  }

  public int Age
  {
    get => _age;
    set => _age = value > 0 && value < 150 ? value : 0; // if value is between 0 and 150, set it to _age but if not, set it to 0
  }

  public void PrintPerson()
  {
    Console.WriteLine($"Name: {Name}\nSurname: {Surname}\nAge: {Age}"); // print person's information
  }
}
