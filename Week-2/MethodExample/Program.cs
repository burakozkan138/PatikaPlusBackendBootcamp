void PrintLyrics() // Geriye Değer Döndürmeyen Bir void metot Çıktı olarak şarkı sözlerini yazdırır.
{
  Console.WriteLine("Demir dağın altında Güzel börü postuyla\nÇıktı güzel sesli Kandı gencin biri Girdi koynuna\nTün bitmeye Kar düşmeye Uslu uslu kollarında\nGün geldi Kız gitti Uyudu oğlan\nDemir dağın altında Güzel börü postuyla\nİrle'nin piçleri Kan içer durmadan Kan ister susmadan\nSaldı yedi eniği Kırsın geçirsin âdemi Ala doysun kardeşi\nArzın içinde salmış kökleri Sessizce dinler kavga sesini Kişte'nin doymaz özü İrle'nin marifeti\nDemir dağın altında Güzel börü postuyla\nİrle'nin enikleri Kan içer, kan ister susmadan Kan içer, kan ister durmadan\nNe büyük bir savaş ne kıyâmet Susmadı âdem doymadı âdem İrle girmiş kanına Tamu olmuş ruhuna\nSusmaz bu mankurtlar Durmaz bu savaş");
}

int GenerateRandomNumber() // Geriye rastgele ürettigi sayının 2'ye bölümünden kalanı döndüren bir metot.
{
  Random random = new Random();

  int number = random.Next();

  return number % 2;
}

int Multiply(int number1, int number2) // verilen iki sayının çarpımını döndüren bir metot.
{
  return number1 * number2;
}

void PrintWelcomeMessage(string name, string surname) // Parametre olarak isim ve soyisim bilgilerini alıp " Hoş Geldiniz {isim} {soyisim} " şeklinde ekrana bassın.
{
  Console.WriteLine($"Hoş Geldiniz {name} {surname}");
}


PrintLyrics(); // Şarkı sözlerini yazdırır.
Console.WriteLine("----------------------------------------------------------");
int number = GenerateRandomNumber(); // Rastgele üretilen sayının 2'ye bölümünden kalanı döndürür.
Console.WriteLine($"Rastgele üretilen sayının 2'ye bölümünden kalan: {number}");
Console.WriteLine("----------------------------------------------------------");
number = Multiply(5, 10); // 5 ve 10 sayılarının çarpımını döndürür.
Console.WriteLine($"5 * 10 = {number}");
Console.WriteLine("----------------------------------------------------------");
PrintWelcomeMessage("Burak", "Özkan"); // "Hoş Geldiniz yazdırır.