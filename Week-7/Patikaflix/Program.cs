using Patikaflix;

Console.Clear();

List<Series> seriesList = new List<Series>
{
    new Series("Avrupa Yakası", 2004, "Komedi", 2004, "Yüksel Aksu", "Kanal D"),
    new Series("Yalan Dünya", 2012, "Komedi", 2012, "Gülseren Buda Başkaya", "Fox TV"),
    new Series("Jet Sosyete", 2018, "Komedi", 2018, "Gülseren Buda Başkaya", "TV8"),
    new Series("Dadı", 2006, "Komedi", 2006, "Yusuf Pirhasan", "Kanal D"),
    new Series("Belalı Baldız", 2007, "Komedi", 2007, "Yüksel Aksu", "Kanal D"),
    new Series("Arka Sokaklar", 2004, "Polisiye, Dram", 2004, "Orhan Oğuz", "Kanal D"),
    new Series("Aşk-ı Memnu", 2008, "Dram, Romantik", 2008, "Hilal Saral", "Kanal D"),
    new Series("Muhteşem Yüzyıl", 2011, "Tarihi, Dram", 2011, "Mercan Çilingiroğlu", "Star TV"),
    new Series("Yaprak Dökümü", 2006, "Dram", 2006, "Serdar Akar", "Kanal D")
};

Console.WriteLine("Welcome to Patikaflix!");
while (true)
{
  Console.Write("Name: ");
  string name = Console.ReadLine();
  Console.Write("Start Year: ");
  int startYear = int.Parse(Console.ReadLine());
  Console.Write("Genre: ");
  string genre = Console.ReadLine();
  Console.Write("Release Year: ");
  int releaseYear = int.Parse(Console.ReadLine());
  Console.Write("Director: ");
  string director = Console.ReadLine();
  Console.Write("Platform: ");
  string platform = Console.ReadLine();

  seriesList.Add(new Series(name, startYear, genre, releaseYear, director, platform));

  Console.Write("Do you want to add another series? (Y/N): ");
  if (Console.ReadLine().ToLower() == "n")
  {
    break;
  }
}

Console.Clear();

List<ComedySeries> comedySeries = seriesList.Where(s => s.Genre.Contains("Comedy") || s.Genre.Contains("Komedi")).Select(s => new ComedySeries(s.Name, s.Director)).ToList();
Console.WriteLine("Comedy Series:");
foreach (ComedySeries comedy in comedySeries)
{
  Console.WriteLine(comedy);
}
Console.WriteLine("<------------------------------------------------------------------------------------->");
/*  Bu yeni listenin bütün elemanlarını bütün özellikleriyle ekrana yazdırınız. Yazımın öncelikle dizi isimleri sonra da yönetmen isimleri baz alınarak sıralanmasına özen gösteriniz */

Console.WriteLine("All Series:");
seriesList.OrderBy(s => s.Name).ThenBy(s => s.Director).ToList().ForEach(s => Console.WriteLine(s));