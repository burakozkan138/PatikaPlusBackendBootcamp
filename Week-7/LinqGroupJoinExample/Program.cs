public class Program
{
  public static void Main()
  {
    Console.Clear();

    List<Student> students = new List<Student>() {
      new Student { Id = 1, Name = "Ali", ClassId = 1 },
      new Student { Id = 3, Name = "Ayşe", ClassId = 2 },
      new Student { Id = 3, Name = "Mehmet", ClassId = 1 },
      new Student { Id = 4, Name = "Fatma", ClassId = 3 },
      new Student { Id =5, Name = "Ahmet", ClassId = 2 }
    };

    List<Class> classes = new List<Class>() {
      new Class { Id = 1, Name = "Matematik" },
      new Class { Id = 2, Name = "Türkçe" },
      new Class { Id = 3, Name = "Kimya" }
    };

    var query = classes.GroupJoin(students, c => c.Id, s => s.ClassId, (c, s) => new
    {
      ClassName = c.Name,
      Students = s.Select(x => x.Name)
    });

    foreach (var @class in query)
    {
      Console.WriteLine($"Class: {@class.ClassName}");
      foreach (var student in @class.Students)
      {
        Console.WriteLine($"  Student: {student}");
      }
    }

    Console.WriteLine("Press any key to exit...");
    Console.ReadLine();
  }
}
public class Student
{
  public int Id { get; set; }
  public string Name { get; set; }
  public int ClassId { get; set; }
}

public class Class
{
  public int Id { get; set; }
  public string Name { get; set; }
}
