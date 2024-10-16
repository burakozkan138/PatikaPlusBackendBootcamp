namespace PolymorphismExample;

public class Shape
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