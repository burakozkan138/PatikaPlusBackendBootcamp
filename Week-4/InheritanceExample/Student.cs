namespace InheritanceExample;

public class Student : BasePerson
{

  public string NO { get; set; }

  public Student(string name, string surname) : base(name, surname)
  {
    NO = Guid.NewGuid().ToString();
  }
  public override void Print() // overriding the base class print method
  {
    Console.WriteLine($"Name: {Name}, Surname: {Surname}, NO: {NO}");
  }
}
