using System;

namespace WeekFinish;

public class Car
{
  public DateTime CreatedAt { get; set; }
  public string SerialNumber { get; set; }
  public string Brand { get; set; }
  public string Model { get; set; }
  public string Color { get; set; }
  public int DoorCount { get; set; }

  public Car(string serialNumber, string brand, string model, string color, int doorCount)
  {
    CreatedAt = DateTime.Now;
    SerialNumber = serialNumber;
    Brand = brand;
    Model = model;
    Color = color;
    DoorCount = doorCount;
  }

  public override string ToString() =>
    $"Serial Number: {SerialNumber}, Brand: {Brand}, Model: {Model}, Color: {Color}, Door Count: {DoorCount}, Created At: {CreatedAt}";
}
