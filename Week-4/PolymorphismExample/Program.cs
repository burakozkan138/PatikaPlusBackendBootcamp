using PolymorphismExample;

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