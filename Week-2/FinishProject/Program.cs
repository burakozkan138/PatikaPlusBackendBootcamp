/* 1 - Aşağıdaki çıktıyı yazan bir program.

Merhaba
Nasılsın ?
İyiyim
Sen nasılsın  */

using Microsoft.VisualBasic.FileIO;

Console.WriteLine("Merhaba\nNasılsın ?\nİyiyim\nSen nasılsın");
Console.WriteLine("--------------------------------------------------------------------");
//2 - Bir adet metinsel , bir adet tam sayı verisi tutmak için 2 adet değişken tanımlayınız. Bunların değerlerini atayıp , ekrana yazdırınız.
string text = "Hello World, I am a string";
int number = 666;

Console.WriteLine($"Text: {text}\nNumber: {number}");
Console.WriteLine("--------------------------------------------------------------------");

//3 - Rastgele bir sayı üretip , ekrana yazdırınız.

int randomNumber = new Random().Next(1, 1000);
Console.WriteLine($"Random Number: {randomNumber}");
Console.WriteLine("--------------------------------------------------------------------");

//4 - Rastgele bir sayı üretip , bunun 3'e bölümünden kalanı ekrana yazdırınız.
int randomNumber2 = new Random().Next(1, 1000);
Console.WriteLine($"{randomNumber2} % 3 = {randomNumber2 % 3}");
Console.WriteLine("--------------------------------------------------------------------");

//5 - Kullanıcıya yaşını sorup , 18'den büyükse "+" küçükse "-" yazdıran bir uygulama.
Console.Write("Enter your age: ");
int age = int.TryParse(Console.ReadLine(), out age) ? age : 0;
Console.WriteLine(age > 18 ? "+" : "-");
Console.WriteLine("--------------------------------------------------------------------");

//6 - Ekrana 10 defa " Sen Vodafone gibi anı yaşarken , ben Turkcell gibi seni her yerde çekemem." yazan bir uygulama.

for (int i = 0; i < 10; i++)
{
  Console.WriteLine("Sen Vodafone gibi anı yaşarken , ben Turkcell gibi seni her yerde çekemem.");
}
Console.WriteLine("--------------------------------------------------------------------");

//7 - Kullanıcıdan 2 adet metinsel değer alıp "Gülse Birsel" , "Demet Evgar" , bunların yerlerini değiştiriniz.

Console.Write("Enter first Text: ");
string? firstText = Console.ReadLine();
Console.Write("Enter second Text: ");
string? secondText = Console.ReadLine();

/* string temp = firstText;
firstText = secondText;
secondText = temp;
temp = null; //remove temp from memory */
(secondText, firstText) = (firstText, secondText); // copilot

Console.WriteLine($"First Text: {firstText}\nSecond Text: {secondText}");
Console.WriteLine("--------------------------------------------------------------------");

//8 - Değer döndürmeyen ismi BenDegerDondurmem olan bir metot tanımlayınız. Ekrana "Ben değer döndürmem , benim bir karşılığım yok , beni değişkene atamaya çalışma" yazsın.
void BenDegerDondurmem()
{
  Console.WriteLine("Ben değer döndürmem , benim bir karşılığım yok , beni değişkene atamaya çalışma");
}
BenDegerDondurmem();
Console.WriteLine("--------------------------------------------------------------------");

//9 - İki sayıyı alıp bunların toplam değerini geriye döndüren bir metot yazınız.
Console.Write("Enter first Number: ");
int fisrtNumber = int.TryParse(Console.ReadLine(), out fisrtNumber) ? fisrtNumber : 0;
Console.Write("Enter second Number: ");
int secondNumber = int.TryParse(Console.ReadLine(), out secondNumber) ? secondNumber : 0;

int Sum(int number1, int number2)
{
  return number1 + number2;
}
Console.WriteLine($"Sum: {Sum(fisrtNumber, secondNumber)}");
Console.WriteLine("--------------------------------------------------------------------");

//10 - Kullanıcıdan true ya da false değeri alıp string bir değer dönen bir metot tanımlayınız.
Console.Write("Enter a bool value: ");
bool value = bool.TryParse(Console.ReadLine(), out value) ? value : false;
string GetValue(bool value)
{
  return value.ToString();
}

Console.WriteLine($"Value: {GetValue(value)}");
Console.WriteLine("--------------------------------------------------------------------");

//11 - 3 Kişinin yaşlarını alıp en yaşlı olanının yaş bilgisini dönen bir metot yazınız.
Console.Write("Enter first Age: ");
int firstAge = int.TryParse(Console.ReadLine(), out firstAge) ? firstAge : 0;
Console.Write("Enter second Age: ");
int secondAge = int.TryParse(Console.ReadLine(), out secondAge) ? secondAge : 0;
Console.Write("Enter third Age: ");
int thirdAge = int.TryParse(Console.ReadLine(), out thirdAge) ? thirdAge : 0;

int GetOldest(int age1, int age2, int age3)
{
  return Math.Max(age1, Math.Max(age2, age3));
}

Console.WriteLine($"Oldest: {GetOldest(firstAge, secondAge, thirdAge)}");
Console.WriteLine("--------------------------------------------------------------------");
//12 - Kullanıcıdan sınırsız sayıda sayı alıp , bunlardan en büyüğünü ekrana yazdıran ve aynı zamanda geriye dönen bir metot yazınız.
int GetMaxNumber()
{
  int maxNumber = 0;
  int userNumber;
  while (true)
  {
    Console.Write("Enter a number if u want exit give 0: ");
    userNumber = Convert.ToInt32(Console.ReadLine()) is int number ? number : 0;
    if (userNumber == 0)
    {
      break;
    }
    maxNumber = Math.Max(maxNumber, userNumber);
  }

  return maxNumber;
}

Console.WriteLine($"Max Number: {GetMaxNumber()}");
Console.WriteLine("--------------------------------------------------------------------");

//13- Bir metot yardımıyla kullanıcıdan alınan 2 ismin yerlerini değiştiren uygulamayı yazınız.
(string, string) ChangePlaces(string firstText, string secondText)
{
  return (secondText, firstText);
}

Console.Write("Enter first Text: ");
string? firstText2 = Console.ReadLine() ?? string.Empty;
Console.Write("Enter second Text: ");
string? secondText2 = Console.ReadLine() ?? string.Empty;

(string firstText3, string secondText3) = ChangePlaces(firstText2, secondText2);
Console.WriteLine($"First Text: {firstText3}\nSecond Text: {secondText3}");
Console.WriteLine("--------------------------------------------------------------------");

//14 - Kullanıcıdan alınan sayının tek mi yoksa çift mi olduğu bilgisini (true/false) dönen bir metot.
bool IsEven(int number)
{
  return number % 2 == 0;
}

Console.Write("Enter a number: ");
int userNumber = int.TryParse(Console.ReadLine(), out userNumber) ? userNumber : 0;
Console.WriteLine($"Is Even: {IsEven(userNumber)}");
Console.WriteLine("--------------------------------------------------------------------");
//15 - Kullanıcıdan alınan hız ve zaman bilgileriyle , gidilen yolu hesaplayan bir metot yazınız.
int CalculateDistance(int speed, int time)
{
  // speed km/h
  // time hour
  return speed * time;
}

Console.Write("Enter Speed Km/h: ");
int speed = int.TryParse(Console.ReadLine(), out speed) ? speed : 0;
Console.Write("Enter Time (hour): ");
int time = int.TryParse(Console.ReadLine(), out time) ? time : 0;

Console.WriteLine($"Distance : {CalculateDistance(speed, time)}");
Console.WriteLine("--------------------------------------------------------------------");

//16 - Yarıçap bilgisi verilen bir dairenin alanını hesaplayan bir metot yazınız.
double CalculateCircleArea(double radius)
{
  return Math.PI * Math.Pow(radius, 2);
}

Console.Write("Enter Radius: ");
double radius = double.TryParse(Console.ReadLine(), out radius) ? radius : 0;
Console.WriteLine($"Circle Area: {CalculateCircleArea(radius)}");
Console.WriteLine("--------------------------------------------------------------------");

//17 - "Zaman bir GeRi SayIm" cümlesini alıp , hepsi büyük harf ve hepsi küçük harfle yazdırınız.
string text2 = "Zaman bir GeRi SayIm";
Console.WriteLine($"Upper: {text2.ToUpper()}\nLower: {text2.ToLower()}");
Console.WriteLine("--------------------------------------------------------------------");

//18 - "    Selamlar   " metnini bir değişkene atayıp , başındaki ve sonundaki boşlukları siliniz. Kalıcı olarak.
string text3 = "    Selamlar   ";
text3 = text3.Trim();

Console.WriteLine($"Text: {text3}");
Console.WriteLine("--------------------------------------------------------------------");

Console.Write("Press any key to exit...");
Console.ReadKey();