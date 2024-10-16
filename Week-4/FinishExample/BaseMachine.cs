namespace FinishExample;
public abstract class BaseMachine
{
  public DateTime CreationDate { get; set; } // base class properties
  public string SerialNumber { get; set; }
  public string Name { get; set; }
  public string Description { get; set; }
  public string OperatingSystem { get; set; }

  public BaseMachine(string serialNumber, string name, string description, string operatingSystem) // base class constructor
  {
    CreationDate = DateTime.Now;
    SerialNumber = serialNumber;
    Name = name;
    Description = description;
    OperatingSystem = operatingSystem;
  }

  public virtual void PrintInfo() // base class print method
  {
    Console.WriteLine($"Name: {Name} - Description: {Description} - Operating System: {OperatingSystem} - Serial Number: {SerialNumber} - Creation Date: {CreationDate}");
  }

  public abstract string GetProductName();
}
