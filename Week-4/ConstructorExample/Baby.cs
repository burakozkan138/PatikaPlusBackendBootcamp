using System;

namespace ConstructorExample;

public class Baby
{
  private string _name;
  private string _surname;
  private DateTime _dateOfBirth;

  public Baby() // Default constructor
  {
    Console.WriteLine("Ignaaaaaaaaaa..."); // This is a constructor
  }

  public Baby(string name, string surname) : this() // this() calls the default constructor
  {
    _name = name;
    _surname = surname;
    _dateOfBirth = DateTime.Now;
  }

  public string Name
  {
    get => _name;
    set => _name = value;
  }

  public string Surname
  {
    get => _surname;
    set => _surname = value;
  }

  public DateTime DateOfBirth
  {
    get => _dateOfBirth;
    set => _dateOfBirth = value <= DateTime.Now ? value : DateTime.Now; // If the date of birth is in the future, set it to today
  }
}
