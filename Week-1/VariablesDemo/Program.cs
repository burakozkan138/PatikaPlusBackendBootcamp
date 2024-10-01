string? tc, name, surname, phone;
// tc and phone number can be null so we use nullable string type

int age;
double firstProductPrice, secondProductPrice, totalPrice;

Console.Clear();
Console.WriteLine("Variables Demo Uygulamasına Hoşgeldiniz");
Console.Write("Lütfen T.C Kimlik Numaranızı Giriniz: ");
tc = Console.ReadLine(); // return string or null
Console.Write("Lütfen Adınızı Giriniz: ");
name = Console.ReadLine();
Console.Write("Lütfen Soyadınızı Giriniz: ");
surname = Console.ReadLine();
Console.Write("Lütfen Telefon Numaranızı Giriniz: ");
phone = Console.ReadLine(); // if you want to store phone number as integer, you can use int.Parse(Console.ReadLine()); instead but not start with 0
Console.Write("Lütfen Yaşınızı Giriniz: ");
age = Convert.ToInt32(Console.ReadLine());
Console.Write("Lütfen İlk Aldığınız Ürünün Fiyatını Giriniz: ");
firstProductPrice = Convert.ToDouble(Console.ReadLine());
Console.Write("Lütfen İkinci Aldığınız Ürünün Fiyatını Giriniz: ");
secondProductPrice = Convert.ToDouble(Console.ReadLine());

totalPrice = firstProductPrice + secondProductPrice;

Console.WriteLine($"\n{tc} Kimlik numaralı, {name} {surname} adlı kişi için kayıt alınmıştır.");
Console.WriteLine($"{phone} Telefon numarasına bildirim mesajı gönderilmiştir.");
Console.WriteLine($"{totalPrice} TL tutarındaki alışverişiniz için teşekkür ederiz kazanılan 10% puan miktarı -> {(int)(totalPrice * 0.1) + (int)(age * 0.1)} TL");

Console.WriteLine("\nProgram Sonlandı. Çıkmak için bir tuşa basınız.");
Console.ReadLine();