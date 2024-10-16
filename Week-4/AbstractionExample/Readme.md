## TEST
**Test için aşağıdaki kod bloğunu kopyalamanız yeterli**
- sizin için classları tek bir namespace üzerinde topladım böylece tek tek uraşmanıza gerek kalmayacak 😎😎🤣🤣

```
namespace Test
{
  public class Program
  {
    public static void Main()
    {
      Console.Clear();

      ProjectDirector projectDirector = new ProjectDirector("Ali", "Yılmaz");
      projectDirector.ShowInfo();
      projectDirector.Work();
      Console.WriteLine("***************************************************");

      SoftwareDeveloper softwareDeveloper = new SoftwareDeveloper("Burak", "Özkan");
      softwareDeveloper.ShowInfo();
      softwareDeveloper.Work();

      Console.WriteLine("\nPress any key to close...");
      Console.ReadKey();
    }
  }

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
}
```