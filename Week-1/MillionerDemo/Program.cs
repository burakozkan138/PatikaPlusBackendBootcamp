int totalCorrectAnswers = 0;

Console.Clear();
Console.WriteLine("Kim Milyoner Olmak İster Yarışması Başlıyor!");
Console.WriteLine("1 -> Kızınca tüküren hayvan hangisidir ?");
Console.WriteLine("a) Lama b) Deve");
Console.Write("Cevabınız: ");
string? answer = Console.ReadLine()?.ToLower();
if (answer == "a")
{
  Console.WriteLine("Tebrikler! Doğru cevap verdiniz.");
  totalCorrectAnswers++;
}
else
{
  Console.WriteLine("Üzgünüm, yanlış cevap verdiniz.");
}

Console.WriteLine("\n2 -> Dünya'ya en yakın gezegen hangisidir ?");
Console.WriteLine("a) Venüs b) Mars");
Console.Write("Cevabınız: ");
answer = Console.ReadLine()?.ToLower();
if (answer == "a")
{
  totalCorrectAnswers++;
  if (totalCorrectAnswers == 2)
  {
    Console.WriteLine("\nTebrikler! 1 Milyon TL'lik büyük ödülü kazandınız.");
    Console.WriteLine("\nÇıkmak için bir tuşa basınız.");
    Console.ReadLine();
    return;
  }
}
else
{
  Console.WriteLine("\nÜzgünüm, yanlış cevap verdiniz.");
}



Console.WriteLine("3 -> 5 * 2 + 8 / 2 - 2 işleminin sonucu kaçtır ?");
Console.WriteLine("a) 7 b) 12");
Console.Write("Cevabınız: ");
answer = Console.ReadLine()?.ToLower();
if (answer == "b")
{
  totalCorrectAnswers++;
  if (totalCorrectAnswers == 2)
  {
    Console.WriteLine("\nTebrikler! 1 Milyon TL'lik büyük ödülü kazandınız.");
    Console.WriteLine("\nÇıkmak için bir tuşa basınız.");
    Console.ReadLine();
    return;
  }
}
else
{
  Console.WriteLine("\nÜzgünüm, yanlış cevap verdiniz.");
}

Console.WriteLine("\nÜzgünüm, 1 Milyon TL'lik büyük ödülü kazanamadınız.");
Console.WriteLine("\nÇıkmak için bir tuşa basınız.");
Console.ReadLine();
