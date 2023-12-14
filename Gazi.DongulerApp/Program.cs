using System.ComponentModel.Design;

namespace Gazi.DongulerApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Console.Write("İsminizi giriniz:");
            //string isim = Console.ReadLine();
            //Console.WriteLine("Kaç defa tekrarlanmasını istiyorusnuz?");
            //int sayi = int.Parse(Console.ReadLine());
            //for (int i = 0; i < sayi; i++)
            //{
            //    Console.WriteLine($"{i+1}{isim}");
            //}

            //Console.WriteLine("Değer aralıklarını belirleyiniz.");
            //Console.Write("Başlangıç");
            //int deger1 = int.Parse(Console.ReadLine());
            //Console.Write("Bitiş");
            //int deger2 = int.Parse(Console.ReadLine());

            //Console.WriteLine("Çift değerleri mi Tek değerleri mi görmek istersiniz");
            //string tekcift = Console.ReadLine().ToLower();
            //if (deger1 > deger2)
            //{
            //    int temp = deger1;
            //    deger1 = deger2;
            //    deger2 = deger1;
            //}
            //    int sonuc = 0;
            //for (int i = deger1; i <= deger2; i++)
            //{
            //if ( i % 2 == 0 && tekcift== "cift")
            //Console.WriteLine(i);
            //sonuc += i;
            //else if (i % 2 == 0 && tekcift == "tek")
            //    Console.WriteLine(i);
            //sonuc += i;
            //    if (i % 2 == (tekcift=="tek" ? 1 : 0))
            //    {
            //        Console.WriteLine(i);
            //        sonuc += i;
            //    }
            //}
            //Console.WriteLine($"Sayıların toplamı:{sonuc}");
            //}

            //Console.WriteLine("Taban değeri giriniz:");
            //int taban = int.Parse(Console.ReadLine());
            //Console.WriteLine("Üs değeri giriniz:");
            //int us = int.Parse(Console.ReadLine());

            //int sonuc = 1;
            //for (int i = 0; i < us; i++)
            //{
            //    sonuc = sonuc * taban;
            //    Console.WriteLine(sonuc);
            //}

            //Console.WriteLine("Bir sayı giriniz:");
            //int sayi = int.Parse(Console.ReadLine());
            //int sonuc = 1;
            //for (int i = 2; i <= sayi; i++)
            //{
            //    sonuc *= i;
            //    Console.WriteLine(sonuc);
            //}

            //Console.WriteLine("Bir sayı giriniz:");
            //int sayi = int.Parse(Console.ReadLine());
            //int sayac = 0;
            //for (int i = 1; i <= sayi; i++)
            //{
            //    if (sayi%i==0)
            //    {
            //        sayac++;
            //    }
            //}
            //Console.WriteLine(sayac == 2 ? "Asal" : "Asal Değil");

            //Console.WriteLine("Bir sayı giriniz:");
            //int sayi = int.Parse(Console.ReadLine());


            //if (sayi > 2 && sayi % 2 == 0)
            //{
            //    Console.WriteLine("Asal Değil");
            //}
            //else if (sayi<2)
            //{
            //    Console.WriteLine("En küçük asal sayı 2'dir");
            //}
            //else
            //{
            //    int sayac = 0;
            //    for (int i = 2; i <= (sayi / 2); i++)
            //    {
            //        if (sayi % i == 0)
            //        {
            //            sayac++;
            //            break;
            //        }
            //    }
            //    Console.WriteLine(sayac == 0 ? "Asal" : "Asal Değil");
            //}

            //for (; ; )
            //{
            //    Console.WriteLine("Kullanıcı adı giriniz:");
            //    string  user   = Console.ReadLine();
            //    Console.WriteLine("Şifre giriniz:");
            //    string pass = Console.ReadLine();

            //    if (user == "admin" && pass == "123")
            //    {
            //        Console.WriteLine("Giriş başarlılı");
            //        break;
            //    }
            //}

            int max = int.MinValue;
            int toplam = 0;
            for (; ; )
            {
            Console.Write("Bir sayı giriniz: ");
            int sayi = int.Parse(Console.ReadLine());
                toplam += sayi;
            if (sayi > max)
                {
                    max = sayi;
                }
            Console.WriteLine("Devam etmek istiyor musunuz?");
            string yanit =Console.ReadLine().ToLower();
            if (yanit== "h")
            {
                    break;
            }            
            else if (yanit== "e")
                {
                    continue;
                }
            else
                {
                    Console.WriteLine("Hatalı giriş yaptınız!");
                }
            }
            Console.WriteLine($"Girilen en büyük sayı: {max}\nSayıların toplamı:{toplam}");
        }
    }
}