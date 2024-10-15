using EncapsulationExample;

Console.Clear();

Car car = new Car("Ford", "Focus", "Red", 4);
car.ShowInfo();

Car car1 = new Car();
car1.Brand = "Toyota";
car1.Model = "Corolla";
car1.Color = "Blue";
car1.DoorCount = 2;
car1.ShowInfo();

Car car2 = new Car("Renault", "Megane", "Black", 5); // Door count is invalid, so it will be set to -1
car2.ShowInfo();


Console.WriteLine("\nPress any key to close...");
Console.ReadKey();