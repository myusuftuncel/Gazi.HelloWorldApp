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

            //int max = int.MinValue;
            //int toplam = 0;
            //for (; ; )
            //{
            //Console.Write("Bir sayı giriniz: ");
            //int sayi = int.Parse(Console.ReadLine());
            //    toplam += sayi;
            //if (sayi > max)
            //    {
            //        max = sayi;
            //    }
            //Console.WriteLine("Devam etmek istiyor musunuz?");
            //string yanit =Console.ReadLine().ToLower();
            //if (yanit== "h")
            //{
            //        break;
            //}            
            //else if (yanit== "e")
            //    {
            //        continue;
            //    }
            //else
            //    {
            //        Console.WriteLine("Hatalı giriş yaptınız!");
            //    }
            //}
            //Console.WriteLine($"Girilen en büyük sayı: {max}\nSayıların toplamı:{toplam}");


            //for (int i = 0; i < 3; i++)
            //{
            //    for (int j = 0; j < 4; j++)
            //    {
            //        Console.Write($"{i},{j}\t");
            //    }
            //    Console.WriteLine();
            //}

            //for (int i = 1; i <= 5; i++)
            //{
            //    for (int j = 0; j < i; j++)
            //    {
            //        Console.Write("*");
            //    }
            //    Console.WriteLine();
            //}
            //Console.WriteLine("Enter row count:");
            //int row = int.Parse(Console.ReadLine());
            //Console.WriteLine("Enter column count:");
            //int column = int.Parse(Console.ReadLine());

            //for (int i = 0; i < row; i++)
            //{
            //    for (int j = 0; j < column; j++)
            //    {
            //        Console.Write((i + j) % 2 == 0 ? "*" : " ");
            //    }
            //    Console.WriteLine();
            //}

            //abcd=4*dcba
            //abcd?

            //bool control = false;
            //var st = new Stopwatch();
            //st.Start();
            //for (int a = 1; a < 10; a++)
            //{
            //    for (int b = 0; b < 10; b++)
            //    {
            //        for (int c = 0; c < 10; c++)
            //        {
            //            for (int d = 0; d < 10; d++)
            //            {
            //                Console.WriteLine($"{a}{b}{c}{d}");
            //                if (1000 * a + 100 * b + 10 * c + d == 4 * (1000 * d + 100 * c + 10 * b + a))
            //                {
            //                    Console.WriteLine($"{a}{b}{c}{d}");
            //                    control = true;
            //                    break;
            //                }
            //            }
            //            if (control)
            //            {
            //                break;
            //            }
            //        }
            //        if (control)
            //        { break; }
            //    }
            //    if (control)
            //    { break; }
            //}
            //st.Stop();
            //Console.WriteLine(st.ElapsedMilliseconds);

            //3-4-5
            //4-3-5
            //5-12-13
            //6-8-10
            //.....

            //for (int i = 1; i < 50; i++)
            //{
            //    for (int j = 1; j < 50; j++)
            //    {
            //        for (int k = 1; k < 50; k++)
            //        {
            //            if (i * i + j * j == k * k)
            //            {
            //                Console.WriteLine($"{i}-{j}-{k}");
            //            }
            //        }
            //    }
            //}

            //Enter starting number:5
            //Enter end number:8
            //5-Is Prime
            //6-Is not prime
            //7-Is Prime
            //8-Is not prime

            //Console.WriteLine("Enter starting number:");
            //int start = int.Parse(Console.ReadLine());
            //Console.WriteLine("Enter end number:");
            //int end = int.Parse(Console.ReadLine());
            //for (int i = start; i < end; i++)
            //{
            //    int count = 0;
            //    for (int j = 2; j <= (i / 2); j++)
            //    {
            //        if (i % j == 0)
            //        {
            //            count++;
            //            break;
            //        }
            //    }
            //    Console.WriteLine(count == 0 ? $"{i}-Is Prime" : $"{i}-Is Not Prime");
            //}

            //int count = 0;
            //while (count<5)
            //{
            //    Console.WriteLine("Gazi");
            //    count++;
            //}


            //int max = int.MinValue;
            //int toplam = 0;
            //while (true )
            //{
            //    Console.Write("Bir sayı giriniz: ");
            //    int sayi = int.Parse(Console.ReadLine());
            //    toplam += sayi;
            //    if (sayi > max)
            //    {
            //        max = sayi;
            //    }
            //    Console.WriteLine("Devam etmek istiyor musunuz?");
            //    string yanit = Console.ReadLine().ToLower();
            //    if (yanit == "h")
            //    {
            //        break;
            //    }
            //    else if (yanit == "e")
            //    {
            //        continue;
            //    }
            //    else
            //    {
            //        Console.WriteLine("Hatalı giriş yaptınız!");
            //    }
            //}
            //Console.WriteLine($"Girilen en büyük sayı: {max}\nSayıların toplamı:{toplam}");

            //do
            //{
            //    Console.WriteLine("Gazi");
            //} while (false);

            //int max = int.MinValue;
            //double toplam = 0;
            //double sayac = 0;
            //string yanit ;

            //do
            //{

            //    Console.Write("Bir sayı giriniz: ");
            //    int sayi = int.Parse(Console.ReadLine());
            //    toplam += sayi;
            //    sayac++;
            //    toplam += sayi;
            //    if (sayi > max)
            //    {
            //        max = sayi;
            //    }
            //    Console.WriteLine("Devam etmek istiyor musunuz?");

            //} while (yanit =="h");

            //Console.WriteLine($"Girilen en büyük sayı: {max}\nSayıların toplamı:{toplam}");

            //for (int i = 0; i < 10; i++)
            //{
            //    for (int j = 0; j < 10; j++)
            //    {
            //        Random rnd = new Random();
            //        int number = rnd.Next(33, 127);
            //        Console.Write((char)number);
            //    }
            //    Console.WriteLine();
            //}



            //Random rnd = new Random();
            //int number = rnd.Next(10);
            //while (true)
            //{
            //    Console.WriteLine("Sayıyı tahmin ediniz");
            //    int sayi = int.Parse(Console.ReadLine());
            //    if (number == sayi)
            //    {
            //        Console.WriteLine("Tebrikler bildiniz");
            //    }
            //    else
            //    {
            //        Console.WriteLine("Tekrar deneyiniz\n");
            //    }
            //}



            //ÖDEV
            // SEVİYE + PUAN SİSTEMİ 
            //KOLAY ORTA ZOR
            //ARALIK BÜYÜR HAK AZALIRSA
            //KOD TEKRARI OLMASIN
            //KOLAYDA SAYI BÜYÜKSE BÜYÜK DESİN KÜÇÜKSE KÜÇÜK DESİN DESTEK OLARAK


            Random rnd = new Random();
            int number = rnd.Next(10);
            string msg1 = "Sayıyı tahmin ediniz";
            string msg3 = "Tebrikler orta seviyeye geçtiniz";
            string msg2 = "Tekrar deneyiniz\n";
            string msg4 = "Tebrikler zor seviyeye geçtiniz";
            string msg5 = "Tebrikler kazandınız!";
            double sayac = 0;
            int puan = 100;
            while (true)
            {
                Console.WriteLine(msg1);
                int sayi = int.Parse(Console.ReadLine());
                if (number != sayi)
                {
                    Console.WriteLine(msg2);
                    puan = puan - 1;
                }
                else
                {
                    
                    {
                        Console.WriteLine(msg3);

                        Console.WriteLine($"Puanınız:{puan}");
                        
                        if (number != sayi)
                        {
                            Console.WriteLine(msg2);
                            puan = puan - 3;
                        }
                        else
                        {
                            number = rnd.Next(20);
                            for (; ; )
                            {
                                Console.WriteLine(msg1);
                            sayi = int.Parse(Console.ReadLine());

                            
                            Console.WriteLine(msg4);

                            Console.WriteLine($"Puanınız:{puan}");
                            


                                    number = rnd.Next(30);
                                for (; ; ) {
                                    if (number != sayi)
                                    {
                                        Console.WriteLine(msg2);
                                        puan = puan - 5;
                                    }
                                    else
                                    {
                                        Console.WriteLine(msg1);
                                        sayi = int.Parse(Console.ReadLine());


                                        Console.WriteLine(msg5);

                                        Console.WriteLine($"Puanınız:{puan}");
                                        break;
                                    }
                                }
                            }
                        }
                    }

                }
                if (puan<=30)
                {
                    Console.WriteLine($"Kaybettiniz Puanınız:{puan}");
                    break;
                }
            }
        }
    }
}