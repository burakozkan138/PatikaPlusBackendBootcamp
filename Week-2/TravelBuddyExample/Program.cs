string? location = "";
int personCount = 0;
int transportationType = 0; // 1: Kara yolu, 2: Hava yolu

while (location == "")
{
  Console.WriteLine("Lokasyon seçenekleri:");
  Console.WriteLine("1 - Bodrum (Paket başlangıç fiyatı 4000 TL)");
  Console.WriteLine("2 - Marmaris (Paket başlangıç fiyatı 3000 TL)");
  Console.WriteLine("3 - Çeşme (Paket başlangıç fiyatı 5000 TL)");
  Console.Write("Lütfen gitmek istediğiniz lokasyonu seçiniz: ");
  location = Console.ReadLine();

  switch (location?.ToLower())
  {
    case "1":
    case "bodrum":
      location = "Bodrum";
      break;
    case "2":
    case "marmaris":
      location = "Marmaris";
      break;
    case "3":
    case "çeşme":
      location = "Çeşme";
      break;
    default:
      Console.WriteLine("Hatalı bir lokasyon girdiniz. Lütfen tekrar deneyiniz.");
      location = "";
      break;
  }
}

while (personCount == 0)
{
  Console.WriteLine("Kaç kişi için tatil planlamak istiyorsunuz?");
  Console.Write("Kişi sayısı: ");
  personCount = Convert.ToInt32(Console.ReadLine());
}

Console.WriteLine("----------------------------------------------------------\n");

Console.WriteLine($"{location} lokasyonunda tatil yaparken yapabileceğiniz aktiviteler:");
switch (location)
{
  case "Bodrum":
    Console.WriteLine("1 - Bodrum Kalesi'ni ziyaret edebilirsiniz.");
    Console.WriteLine("2 - Bodrum Sualtı Arkeoloji Müzesi'ni ziyaret edebilirsiniz.");
    Console.WriteLine("3 - Bodrum Kalesi'nde güneşin batışını izleyebilirsiniz.");
    break;
  case "Marmaris":
    Console.WriteLine("1 - Marmaris Kalesi'ni ziyaret edebilirsiniz.");
    Console.WriteLine("2 - Marmaris Marina'da yürüyüş yapabilirsiniz.");
    Console.WriteLine("3 - Marmaris Kalesi'nde güneşin batışını izleyebilirsiniz.");
    break;
  case "Çeşme":
    Console.WriteLine("1 - Çeşme Kalesi'ni ziyaret edebilirsiniz.");
    Console.WriteLine("2 - Çeşme Marina'da yürüyüş yapabilirsiniz.");
    Console.WriteLine("3 - Çeşme Kalesi'nde güneşin batışını izleyebilirsiniz.");
    break;
}
Console.Write("\nDevam etmek için bir tuşa basınız...");
Console.ReadKey();
Console.WriteLine("----------------------------------------------------------\n");

while (transportationType == 0)
{
  Console.WriteLine("Ulaşım aracı seçenekleri:");
  Console.WriteLine("1 - Kara yolu ( Kişi başı ulaşım tutarı gidiş-dönüş 1500 TL )");
  Console.WriteLine("2 - Hava yolu ( Kişi başı ulaşım tutarı gidiş-dönüş 4000 TL)");
  Console.Write("Nasıl gitmek istersiniz: ");
  transportationType = Convert.ToInt32(Console.ReadLine());

  if (transportationType != 1 && transportationType != 2)
  {
    Console.WriteLine("Hatalı bir ulaşım aracı seçtiniz. Lütfen tekrar deneyiniz.");
    transportationType = 0;
  }
}

Console.WriteLine("----------------------------------------------------------\n");

int totalCost = 0;

switch (location)
{
  case "Bodrum":
    totalCost = 4000;
    break;
  case "Marmaris":
    totalCost = 3000;
    break;
  case "Çeşme":
    totalCost = 5000;
    break;
}

totalCost += personCount * (transportationType == 1 ? 1500 : 4000);

Console.WriteLine($"Toplam tutar: {totalCost} TL");