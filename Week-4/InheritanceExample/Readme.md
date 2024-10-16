## Test
 **Test Etmek İçin Alttaki Kodu Kopyala Bilirsiniz.**  
 
```
namespace TEST
{
    public class Program
    {
        public static void Main()
        {

            Console.Clear();

            Teacher teacher = new Teacher("Yiğit", "Hacıefendioğlu");
            teacher.Print();

            Console.WriteLine("**********");

            Student student = new Student("Burak", "Özkan");
            student.Print();

            Console.WriteLine("Please press any key to exit...");
            Console.ReadKey();
        }
    }

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
}

```