## TEST
**Test etmek için aşağıdaki kodu kopyalayabilirsin.**
- dosyaların içinden kopyalamaya uğraşmamanız sağlamak için aşağıda sizin için ben oluşturdum 😁

```
namespace Test
{
  public class Program
  {
    public static void Main()
    {
      Console.Clear();

      Triangle triangle = new Triangle(10, 10);
      Console.WriteLine($"Area of Triangle: {triangle.Area()}");
      Console.WriteLine("******************************************");
      Square square = new Square(10, 10);
      Console.WriteLine($"Area of Square: {square.Area()}");
      Console.WriteLine("******************************************");
      Rectangle rectangle = new Rectangle(10, 20);
      Console.WriteLine($"Area of Rectangle: {rectangle.Area()}");
      Console.WriteLine("******************************************");

      Console.WriteLine("Press any key to exit...");
      Console.ReadKey();
    }
  }
  
  public abstract class Shape
{
  public double Width { get; set; }
  public double Height { get; set; }

  public Shape(double width, double height)
  {
    Width = width;
    Height = height;
  }

  public abstract double Area(); // abstract keyword is used to make the method abstract
}

public class Triangle : Shape
{
  public Triangle(double width, double height) : base(width, height) // base keyword is used to call the constructor of the base class
  {
  }

  public override double Area() // override keyword is used to override the base class method
  {
    return 0.5 * Width * Height;
  }
}

public class Square : Shape
{
  public Square(double width, double height) : base(width, height)
  {
  }

  public override double Area() // override keyword is used to override the base class method
  {
    return Width * Width;
  }
}

public class Rectangle : Shape
{
  public Rectangle(double width, double height) : base(width, height)
  {
  }

  public override double Area() // override keyword is used to override the base class method
  {
    return Width * Height;
  }
}
}
```