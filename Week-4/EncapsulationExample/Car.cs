using System;

namespace EncapsulationExample;
/* Bu örnekte sizlerden bir Araba sınıfı oluşturmanız isteniyor.

Araba sınıfının özellikleri -> Marka, Model, Renk, Kapı Sayısı

Özelliklerimizden (Property) Kapı sayısı için kapsülleme işlemi yapmak istiyoruz.

Eğer bir Araba nesnesi oluşturulduğunda Kapı Sayısı için 2 veya 4 dışında bir değer atanmak isterse konsol ekranında bir uyarı mesajı yayınlayalım ve Kapı Sayısı değerini -1 olarak atayalım.
 */
public class Car
{
  private string _brand; // Car class fields
  private string _model;
  private string _color;
  private int _doorCount;

  public string Brand { get => _brand; set => _brand = value; } // Car class properties
  public string Model { get => _model; set => _model = value; }
  public string Color { get => _color; set => _color = value; }
  public int DoorCount
  {
    get => _doorCount;
    set => _doorCount = value == 2 || value == 4 ? value : -1;
  }

  public Car()
  { }
  public Car(string brand, string model, string color, int doorCount) // Car class constructor
  {
    Brand = brand;
    Model = model;
    Color = color;
    DoorCount = doorCount;
  }

  public void ShowInfo()
  {
    Console.WriteLine($"Brand: {Brand}, Model: {Model}, Color: {Color}, Door Count: {DoorCount}");
  }
}
