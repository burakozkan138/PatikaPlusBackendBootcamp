Console.Write("Lütfen bir sayı giriniz: ");
int number = Convert.ToInt32(Console.ReadLine());

if (number == 10)
{
  Console.WriteLine("Girilen sayı 10'a eşittir.");
}
else if (number < 10)
{
  Console.WriteLine("Girilen sayı 10'dan küçüktür.");
}
else
{
  Console.WriteLine("Girilen sayı 10'dan büyüktür.");
}

if (number % 2 == 0)
{
  Console.WriteLine("Girilen sayı çifttir.");
}
else
{
  Console.WriteLine("Girilen sayı tektir.");
}