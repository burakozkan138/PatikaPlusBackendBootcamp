Console.Clear();
Console.WriteLine("Rüya manavında fiyatlar çok uygun!\n");
Console.Write("Lütfen almak istediğiniz meyveyi giriniz: ");
string? fruit = Console.ReadLine()?.ToLower();

if (fruit == null)
{
  Console.WriteLine("Lütfen bir meyve giriniz.");
  return;
}

/* if (fruit == "elma")
{
  Console.WriteLine("Elma fiyatı: 2 TL");
}
else if (fruit == "armut")
{
  Console.WriteLine("Armut fiyatı: 3 TL");
}
else if (fruit == "çilek")
{
  Console.WriteLine("Çilek fiyatı: 2 TL");
}
else if (fruit == "muz")
{
  Console.WriteLine("Muz fiyatı: 3 TL");
}
else
{
  Console.WriteLine($"{fruit} fiyatı: 4 TL");
} */

//Switch Case ile çözüm
// Switch case yapısı, if else yapısına göre daha hızlı çalışır. Bu yüzden switch case yapısı tercih edilir.
// ayrıca gelecek değerlerin ne olduğunuda kesin olarak biliyoruz bu yüzden switch case yapısı daha uygun olacaktır.
switch (fruit)
{
  case "elma":
    Console.WriteLine("Elma fiyatı: 2 TL");
    break;
  case "armut":
    Console.WriteLine("Armut fiyatı: 3 TL");
    break;
  case "çilek":
    Console.WriteLine("Çilek fiyatı: 2 TL");
    break;
  case "muz":
    Console.WriteLine("Muz fiyatı: 3 TL");
    break;
  default:
    Console.WriteLine($"{fruit} fiyatı: 4 TL");
    break;
}

Console.WriteLine("\nÇıkmak için bir tuşa basınız.");
Console.ReadLine();