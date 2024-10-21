namespace WeekFinish;

public static class RentaCar
{
  public static string Name { get; set; } = "Patika Car Rental";
  public static List<Car> Cars { get; set; } = new();

  public static void AddCar(Car car)
  {
    Cars.Add(car);
  }

  public static void ListCars()
  {
    foreach (var car in Cars)
    {
      Console.WriteLine(car); // ToString() method will be called automatically
    }
  }

  public static void PrintWelcome()
  {
    Console.WriteLine($"Welcome to {Name} car rental service!");
  }

  public static void PrintGoodbye()
  {
    Console.WriteLine($"Thank you for using {Name} car rental service!");
  }

  public static void PrintMenu()
  {
    Console.WriteLine("1- List Cars");
    Console.WriteLine("2- Add Car");
    Console.WriteLine("3- Exit");

    Console.Write("Select an option: ");
    string option = Console.ReadLine();
    SelectChoice(option);
  }

  private static void SelectChoice(string option)
  {
    switch (option)
    {
      case "1":
        ListCars();
        break;
      case "2":
        AddCar(CreateCar());
        break;
      case "3":
        PrintGoodbye();
        break;
      default:
        Console.WriteLine("Invalid option. Please try again.");
        PrintMenu();
        break;
    }

    CheckCountine();
  }

  private static void CheckCountine()
  {
    Console.Write("Do you want to countine? (Y/N): ");
    string answer = Console.ReadLine();
    if (answer.ToLower() == "y")
    {
      PrintMenu();
    }
    else if (answer.ToLower() == "n")
    {
      PrintGoodbye();
    }
    else
    {
      Console.WriteLine("Invalid answer. Please try again.");
      CheckCountine();
    }
  }

  public static Car CreateCar()
  {
    Console.Write("Enter Serial Number: ");
    string serialNumber = Console.ReadLine();
    Console.Write("Enter Brand: ");
    string brand = Console.ReadLine();
    Console.Write("Enter Model: ");
    string model = Console.ReadLine();
    Console.Write("Enter Color: ");
    string color = Console.ReadLine();

  tryAgain:
    int doorCount;
    try
    {
      Console.Write("Enter Door Count: ");
      doorCount = Convert.ToInt32(Console.ReadLine());
    }
    catch (Exception)
    {
      Console.WriteLine("Please enter a valid number for door count.");
      goto tryAgain;
    }

    return new Car(serialNumber, brand, model, color, doorCount);
  }
}
