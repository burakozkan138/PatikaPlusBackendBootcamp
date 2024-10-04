/* 1 -> Konsol ekranına 10 kere "Kendime inanıyorum, ben bu yazılım işini hallederim!" yazdırınız.

2 -> 1 ile 20 arasındaki sayıları konsol ekranına yazdırınız.

3 -> 1 ile 20 arasındaki çift sayıları konsol ekranına yazdırınız.

4 -> 50 ile 150 arasındaki sayıların toplamını ekrana yazdırınız.

5 -> 1 ile 120 arasındaki tek ve çift sayıların toplamlarını ayrı ayrı ekrana yazdırınız. */
Console.Clear(); // Konsol ekranını temizler.

int i = 0; // i değişkeni 0'dan başlayacak ve 10'a kadar artacak.
while (i < 10)
{
  Console.WriteLine("Kendime inanıyorum, ben bu yazılım işini hallederim!");
  i++;
}
Console.WriteLine("----------------------------------------------------------");

int j = 1; // j değişkeni 1'dsen başlayacak ve 20'ye kadar artacak.
while (j <= 20)
{
  Console.WriteLine(j);
  j++;
}
Console.WriteLine("----------------------------------------------------------");

int k = 1; // k değişkeni 1'den başlayacak ve 20'ye kadar artacak.
while (k <= 20)
{
  if (k % 2 == 0)
  {
    Console.WriteLine(k);
  }
  k++;
}
Console.WriteLine("----------------------------------------------------------");

int total = 0;
int l = 50; // l değişkeni 50'den başlayacak ve 150'ye kadar artacak.
while (l <= 150)
{
  total += l;
  l++;
}
Console.WriteLine("50 ile 150 arasındaki sayıların toplamı: " + total);
Console.WriteLine("----------------------------------------------------------");

int oddTotal = 0;
int evenTotal = 0;
int m = 1; // m değişkeni 1'den başlayacak ve 120'ye kadar artacak.
while (m <= 120)
{
  if (m % 2 == 0)
  {
    evenTotal += m;
  }
  else
  {
    oddTotal += m;
  }
  m++;
}
Console.WriteLine("1 ile 120 arasındaki çift sayıların toplamı: " + evenTotal);
Console.WriteLine("1 ile 120 arasındaki tek sayıların toplamı: " + oddTotal);

Console.Write("\nÇıkmak için herhangi bir tuşa basınız...");
Console.ReadKey(); // Konsol ekranının kapanmaması için kullanılır.


