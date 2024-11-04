using PatikafyDemo;

Console.Clear();

List<Artists> artists = new List<Artists>(){
  new Artists("Ajda", "Pekkan", "Pop", 1968, 20000000),
  new Artists("Sezen", "Aksu", "Türk Halk Müziği/Pop", 1971, 10000000),
  new Artists("Funda","Arar","Pop",1999,3000000),
  new Artists("Sertab","Erener","Pop",1994,5000000),
  new Artists("Sıla","Gençoğlu","Pop",2009,3000000),
  new Artists("Serdar","Ortaç","Pop",1992,10000000),
  new Artists("Tarkan","Tevek","Pop",1994,40000000),
  new Artists("Hande","Yener","Pop",1999,7000000),
  new Artists("Hadise","Açıkgöz","Pop",2005,5000000),
  new Artists("Gülben","Ergen","Pop/Türk Halk Müziği",1997,6000000),
  new Artists("Neşet","Ertaş","Türk Halk Müziği/Türk Sanat Müziği",1960,2000000),
};

Console.WriteLine("Name starts with 'S':");
artists.Where(singer => singer.FullName.StartsWith("S")).ToList().ForEach(singer => Console.WriteLine(singer));
Console.WriteLine("<------------------------------------------------------------------->");

Console.WriteLine("Artists with sales over 10 million:");
artists.Where(singer => singer.Sales > 10000000).ToList().ForEach(singer => Console.WriteLine(singer));
Console.WriteLine("<------------------------------------------------------------------->");

Console.WriteLine("Artists who released an album before 2000 and make pop music:");
artists.Where(singer => singer.Year < 2000 && singer.Genre == "Pop")
.OrderBy(singer => singer.FullName)
.GroupBy(singer => singer.Year).ToList().ForEach(group =>
{
  Console.WriteLine(group.Key);
  group.ToList().ForEach(singer => Console.WriteLine(singer));
});
Console.WriteLine("<------------------------------------------------------------------->");

Console.WriteLine("Artist with the most album sales:");
Console.WriteLine(artists.OrderByDescending(x => x.Sales).First());
Console.WriteLine("<------------------------------------------------------------------->");

Console.WriteLine("The newest and oldest artist:");
Console.WriteLine("Newest: " + artists.OrderByDescending(x => x.Year).First());

Console.WriteLine("Oldest: " + artists.OrderBy(x => x.Year).First());
Console.WriteLine("<------------------------------------------------------------------->");

Console.WriteLine("Please press any key to exit...");
Console.ReadLine();