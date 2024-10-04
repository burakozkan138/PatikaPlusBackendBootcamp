/* Kullanıcının girdiği bir limit değerine kadar 0'dan bir sayaç çalıştırıp artırarak, ekrana " Ben bir Patika'lıyım " yazdırınız.

( Sayacınız 0'dan başlayarak 1'er 1'er artacak, koşulunuz ( Sayac <= Limit ) )

Örnek inputlar : 10 ve -5

Uygulama testi sonrası while ve do-while arasındaki farkı yorum satırı olarak kodunuzun altına ekleyiniz. */

Console.Write("Lütfen bir sayı giriniz: ");
int limit = Convert.ToInt32(Console.ReadLine());
int counter = 0;

while (counter < limit)
{
  Console.WriteLine("Ben bir Patika'lıyım");
  counter++;
}

Console.WriteLine("----------------------------------------------------------");
counter = 0;
do
{
  Console.WriteLine("Ben bir Patika'lıyım");
  counter++;
} while (counter < limit);

Console.WriteLine("\nÇıkmak için herhangi bir tuşa basınız...");
Console.ReadKey();

// While ve Do-While arasındaki farklar:
// While döngüsünde koşul sağlandığı sürece döngü çalışır. Do-While döngüsünde ise koşul sağlanmasa bile döngü en az bir kez çalışır.
// Bu örnekte limit değeri -5 girildiğinde, while döngüsü hiç çalışmazken, do-while döngüsü bir kez çalışır.
// Bu durum, do-while döngüsünün, döngü koşulunun en az bir kez sağlanmasını istediğimiz durumlarda kullanılmasını sağlar.
