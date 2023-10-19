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
            #endregion

            #region String Biçimlendrime
            //string isim = "Ahmet", soyad = "Mehmet";
            //Console.WriteLine("Merhaba " + isim +" "+ soyad);

            //Console.WriteLine("Merhaba {0} {1}", isim, soyad);

            //Console.WriteLine($"Merhaba {isim} {soyad}"); 
            #endregion

            Console.WriteLine("İsminizi Giriniz");
            string isim = Console.ReadLine();

            Console.WriteLine("Soyadınızı Giriniz");
            string soyad = Console.ReadLine();

            Console.WriteLine($"Merhaba {isim} {soyad}");

            Console.ReadKey();
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
