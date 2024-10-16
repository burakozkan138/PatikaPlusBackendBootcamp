using FinishExample;
int choice;
do
{
  Console.Clear(); // Clear the console screen for better readability.
  Console.WriteLine("Welcome to the product creation system."); // Welcome message.
  Console.WriteLine("1- Create a phone by pressing 1."); // Menu options.
  Console.WriteLine("2- Create a computer by pressing 2.");
  Console.Write("Your choice: ");
  choice = int.TryParse(Console.ReadLine(), out choice) ? choice : 0; // Get the user's choice and convert it to an integer value or set it to 0 if it's not a valid integer.

  switch (choice)
  {
    case 1:
      CreatePhone(); // Call the CreatePhone method to create a phone object.
      break;
    case 2:
      CreateComputer(); // Call the CreateComputer method to create a computer object.
      break;
    default:
      Console.WriteLine("Invalid choice. Please try again."); // Display an error message for invalid choices.
      break;
  }
  Console.WriteLine("Press any key to continue.");
  Console.ReadKey();

  Console.WriteLine("Do you want to continue? (Yes/No)");
  Console.Write("Answer: ");
  string answer = Console.ReadLine() ?? string.Empty;
  if (answer.ToLower() == "no")
  {
    Console.WriteLine("Goodbye!");
    break;
  }
} while (choice != 3);

void CreateComputer()
{
  Console.Write("Enter the serial number of the computer: ");
  string serialNumber = Console.ReadLine() ?? string.Empty;
  Console.Write("Enter the name of the computer: ");
  string name = Console.ReadLine() ?? string.Empty;
  Console.Write("Enter the description of the computer: ");
  string description = Console.ReadLine() ?? string.Empty;
  Console.Write("Enter the operating system of the computer: ");
  string operatingSystem = Console.ReadLine() ?? string.Empty;
  Console.Write("Enter the number of USB ports of the computer: ");
  int usbCount;
  int.TryParse(Console.ReadLine(), out usbCount);

  Computer computer = new Computer(serialNumber, name, description, operatingSystem, usbCount);
  computer.PrintInfo();
  computer.GetProductName();
}

void CreatePhone()
{
  Console.Write("Enter the serial number of the phone: ");
  string serialNumber = Console.ReadLine() ?? string.Empty;
  Console.Write("Enter the name of the phone: ");
  string name = Console.ReadLine() ?? string.Empty;
  Console.Write("Enter the description of the phone: ");
  string description = Console.ReadLine() ?? string.Empty;
  Console.Write("Enter the operating system of the phone: ");
  string operatingSystem = Console.ReadLine() ?? string.Empty;

  Phone phone = new Phone(serialNumber, name, description, operatingSystem);
  phone.PrintInfo();
  phone.GetProductName();
}