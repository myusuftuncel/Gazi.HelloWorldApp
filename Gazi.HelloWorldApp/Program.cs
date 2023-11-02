namespace Gazi.HelloWorldApp
{
    internal class Program
    {
        //static int oyuncusayi = 50;
        static void Main(string[] args)
        {
            #region Değer Tanımlamaları
            // Değer Tipi(Value Type) - STACK
            //int sayi = 50;
            //byte number = 50;
            //Console.WriteLine(sayi);
            //Console.WriteLine(number);

            //byte a;
            //double d;
            //a = 30;
            //d = 40;
            //Console.WriteLine(a);
            //Console.WriteLine(d);


            //// Referans Tipi(Referance Type) -
            //string isim = "Ahmet";
            //Console.WriteLine(isim);

            //byte a = 30, b = 40;
            //Console.WriteLine(a + b);

            //const int number = 50;
            //Console.WriteLine(number);
            //number = 100;
            //Console.WriteLine(number);

            //değişkenler boş olmaz

            //byte yas;
            //Console.WriteLine(yas); 
            //var sayi = 50.10f;
            #endregion

            #region String Biçimlendrime
            //string isim = "Ahmet", soyad = "Mehmet";
            //Console.WriteLine("Merhaba " + isim +" "+ soyad);

            //Console.WriteLine("Merhaba {0} {1}", isim, soyad);

            //Console.WriteLine($"Merhaba {isim} {soyad}"); 
            #endregion

            //Console.WriteLine("İsminizi Giriniz");
            //string? isim = Console.ReadLine();

            //Console.WriteLine("Soyadınızı Giriniz");
            //string? soyad = Console.ReadLine();

            //Console.WriteLine("Yaşınızı Giriniz");
            //byte yas = byte.Parse(Console.ReadLine());

            //Console.WriteLine($"Merhaba {isim} {soyad} Yaşınız {yas}");

            //Console.ReadKey();


            #region Notlar
            //TÜR DÖNÜŞÜMLERİ (Type Casting)
            //byte sayı = 20;
            //int number = sayı; //İmplicit Type Casting
            //Küçük türden büyük türe yapılan dönüşümler otomatik olarak gerçekleştirilir.


            //checked
            //{
            //    int sayi = 256;
            //    byte number = (byte)sayi; //Explicit Type Casting
            //    Console.WriteLine(number);  
            //}

            //RİSK! 
            //Büyük türden küçük türe yapılan dönüşümlerde veri kaybı ihtimali vardır.


            ////String->Değer tipine
            //string sayi = "20";
            ////byte number = Convert.ToByte(sayi);
            //byte number = byte.Parse(sayi);

            #endregion


            //OPERATÖRLER

            // sayıyı al numbera ata 1 arttır
            //a=4   b=a++   a=5 b=4
            //a=4   b=a--   a=3 b=4
            //a=4   b=++a   a=5 b=5 
            //a=4   b=--a   a=3 b=3

            // 1 || 1 = 1 
            // 1 || 0 = 1
            // 0 || 1 = 1
            // 0 || 0 = 0

            // 1 && 1 = 1
            // 1 && 0 = 0
            // 0 && 1 = 0
            // 0 && 0 = 0

            //double maas = 5000;
            //maas = maas + 1000;
            //Console.WriteLine(maas);

            //string sonuc = 10 > 5 ? "Birinci sayı büyüktür" : "İkinci sayı büyüktür veya eşittir";
            //Console.WriteLine(sonuc); 


            //Console.WriteLine("Birinci sayıyı giriniz");
            //byte num1 = byte.Parse(Console.ReadLine());
            //Console.WriteLine("İkinci sayıyı giriniz");
            //byte num2 = byte.Parse(Console.ReadLine());
            //string sonuc = num1 > num2 ? "Birinci sayı büyüktür" : "İkinci sayı büyüktür veya eşittir";
            //Console.WriteLine(sonuc);
        }
    }
}

//Namespace: İçinde classları bulunduran yapılardır.
//{}: Blok Yapısı(Scope).
//Class: İçinde metodları bulunduran yapılardır.
//Metod: İş yapan kod bloklarıdır.
//Main Metodu: Console uygulamalırının giriş uygulamasıdır.
//Syntax: Kod yazım kuralları.
//Derleme: C#->Build->MS-IL(exe)->Runtime->Makina Dili(0-1)
//İntelliSense: Kod Yazım yardımcısı.
//İntelliCode: Yapay zeka kod yardımcısı (Tab kullanarak)
//Solution: İçerisinde bir ya da birden fazla proje bulunduran yapılar. Projelerin disk üzerinde kayıtlı olduğu yer bilgisini tutar.
// . yı iki şeyin arasına koymak şunun içindeki şu demek
//Veri türünden sonra ? koyarsan sarı uyarı gözardı edilir

//KISAYOLLAR
//Ctrl+B: Derleme kısayolu.
//Ctrl+K+D: Scope hiyerarşisi düzeltme.
//Ctrl+K+C: Seçilen kısmı yorum satırına dönüştürür.
//Ctrl+K+U: Seçilen yorum satırını eski haline dönüştürür.
//Ctrl+F: Find(Arama)
//Ctrl+K+S: Region
// / *,*/: arasındaki her şey yorum astırına dönüşür.

//.NET: Mikrosoft tarafından geliştirilen bir yazılım geliştirme platformudur(Freamwork).
//1- Programlama Dilleri: C#-VB-F#
//2- Editörler: Visual Studio-Visual Studio Code
//3- Kütüphaneler: Namespace
//4- Runtime

//.NET ile yapılabilecekler
//1- Destop Applications: (Console,Windows Forms App...)
//2- Web Applications
//3- Mobile Applications: (Android-İOS) Xamarin Applications
//4- Game Development: Unity
//5- IoT: Internet of Things (Akıllı cihazlar)
//6- AI: Yapay Zeka

//Tip Güvenliği (Type Safety): Atanmak istenen değer ile değerin atanacağı değişkenin veri tipi aynı anda uyumlu olmalıdır. Ancak atamanın yapılmasında teknik olarak sorun yoksa, tür dönüşümü yçntemleri ile sorun çözülebilir.