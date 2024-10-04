/* 1->Konsol ekranına 10 kere "Kendime inanıyorum, ben bu yazılım işini hallederim!" yazdırınız.

2 -> 1 ile 20 arasındaki sayıları konsol ekranına yazdırınız.

3 -> 1 ile 20 arasındaki çift sayıları konsol ekranına yazdırınız.

4 -> 50 ile 150 arasındaki sayıların toplamını ekrana yazdırınız.

5 -> 1 ile 120 arasındaki tek ve çift sayıların toplamlarını ayrı ayrı ekrana yazdırınız. */

for (int i = 0; i < 10; i++)
{
  Console.WriteLine("Kendime inanıyorum, ben bu yazılım işini hallederim!");
}

Console.WriteLine("************************************************");

for (int i = 1; i <= 20; i++)
{
  Console.WriteLine(i);
}

Console.WriteLine("************************************************");

for (int i = 1; i <= 20; i++)
{
  if (i % 2 == 0)
  {
    Console.WriteLine(i);
  }
}

Console.WriteLine("************************************************");

int sum = 0; // toplamı tutacak değişken
for (int i = 50; i <= 150; i++)
{
  sum += i;
}

Console.WriteLine($"50 ile 150 arasındaki sayıların toplamı: {sum}");
Console.WriteLine("************************************************");

int sumOdd = 0; // tek sayıların toplamını tutacak değişken
int sumEven = 0; // çift sayıların toplamını tutacak değişken

for (int i = 1; i <= 120; i++)
{
  if (i % 2 == 0)
  {
    sumOdd += i;
  }
  else
  {
    sumEven += i;
  }
}

Console.WriteLine($"Tek sayıların toplamı: {sumOdd}");
Console.WriteLine($"Çift sayıların toplamı: {sumEven}");

Console.Write("\nÇıkmak için bir tuşa basınız...");
Console.ReadLine();