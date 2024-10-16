using System;

namespace FinishExample;

public class Phone : BaseMachine
{
  public Phone(string serialNumber, string name, string description, string operatingSystem) : base(serialNumber, name, description, operatingSystem)
  {
  }

  public override string GetProductName()
  {
    return Name;
  }

  public override void PrintInfo()
  {
    Console.WriteLine($"Phone Name: {Name} - Description: {Description} - Operating System: {OperatingSystem} - Serial Number: {SerialNumber} - Creation Date: {CreationDate}");
  }
}
