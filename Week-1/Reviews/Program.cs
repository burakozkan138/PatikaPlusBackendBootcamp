// Practice - Who Wants to be a Millionaire?
Console.WriteLine("Bir bilgi yarışması yapıyoruz!");

string Question1 = "Kızınca tüküren hayvan hangisidir ?";
string Question2 = "Dünya'ya en yakın gezegen hangisidir ?";
string Question3 = "5 * 2 + 8 / 2 - 2 işleminin sonucu kaçtır ?";

string Result1;
string Result2;
string Result3;

int Score = 0;

//Question-1
Console.WriteLine(Question1);
Console.WriteLine("a) Lama b) Deve");
Result1 = Console.ReadLine();
if (Result1.ToLower() == "a")
{
  Console.WriteLine("Cevabınız doğru");
  Score += 10;
}
else
{
  Console.WriteLine("Cevabınız yanlış");
}
//*******************************************

//Question-2
Console.WriteLine(Question2);
Console.WriteLine("a) Venüs b) Mars");
Result2 = Console.ReadLine();
if (Result2.ToLower() == "a")
{
  Console.WriteLine("Cevabınız doğru");
  Score += 10;
}
else
{
  Console.WriteLine("Cevabınız yanlış");
}
Console.WriteLine(Score);
//*********************************************

//Question-3
if (Score == 20)
{
  Console.WriteLine(Question3);
  Console.WriteLine("a) 7 b) 12 ");
  Result2 = Console.ReadLine();
  if (Result2.ToLower() == "b")
  {
    Console.WriteLine("Cevabınız doğru");
    Score += 10;
    Console.WriteLine("Büyük ödülü kazandınız. Tebrikler.");
    Console.WriteLine($"Toplam puanınız: {Score}");

  }
  else
  {
    Console.WriteLine("Cevabınız yanlış");
  }
}
else
{
  Console.WriteLine("Büyük ödülü kazanamadın. Tekrar denemek ister misin? ");
  Console.WriteLine($"Toplam puanınız: {Score}");

}

