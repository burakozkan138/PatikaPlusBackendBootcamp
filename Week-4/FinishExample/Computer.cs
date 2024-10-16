using System;

namespace FinishExample;

public class Computer : BaseMachine
{
  private int _usbPorts;
  public Computer(string serialNumber, string name, string description, string operatingSystem, int usbCount) : base(serialNumber, name, description, operatingSystem)
  {
    UsbPorts = usbCount;
  }
  public int UsbPorts
  {
    get => _usbPorts;
    set
    {
      if (value != 2 && value != 4)
      {
        Console.WriteLine("Invalid USB port count. Please enter 2 or 4.");
        _usbPorts = -1;
      }
      else
      {
        _usbPorts = value;
      }
    }
  }

  public override void PrintInfo()
  {
    Console.WriteLine($"Computer Name: {Name} - Description: {Description} - Operating System: {OperatingSystem} - Serial Number: {SerialNumber} - Creation Date: {CreationDate} - USB Ports: {UsbPorts}");
  }

  public override string GetProductName()
  {
    return $"Your Computer Name: {Name}";
  }
}
