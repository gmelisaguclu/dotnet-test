
// class Odev
// {
//     static void Main(string[] args)
//     {
//     string [] menu =
//         {
//             "1 - Toplama",
//             "2 - Çıkarma",
//             "3 - Çarpma",
//             "4 - Bölme",
//             "5 - Mod alma",
//             "0 - Çıkış"
//         };

//         while (true)
//         {

//             foreach (string item in menu)
//             {
//                 Console.WriteLine(item);
//             }
//             int secim = ReadInt("Seçiminiz: ");
//             if (secim == 0)
//             {
//                 Console.WriteLine("Program sonlandırıldı.");
//                 break;
//             }
//             if (secim < 1 || secim > 5)
//             {
//                 Console.WriteLine("Geçersiz seçim, lütfen tekrar deneyin.");
//                 continue;
//             }
//             if (secim == 5)
//             {
//                 int a = ReadInt("1. sayı: ");
//                 int b = ReadInt("2. sayı: ");
//                 Console.WriteLine($"Sonuç: {a % b}");
//                 continue;
//             }
//             double x = ReadDouble("1. sayı: ");
//             double y = ReadDouble("2. sayı: ");

//             if (secim == 4 && y == 0)
//             {
//                 Console.WriteLine("Bölen 0 olamaz!");
//                 continue;
//             }

//             double result = secim switch
//             {
//                 1 => x + y,
//                 2 => x - y,
//                 3 => x * y,
//                 4 => x / y,
//                 _ => 0
//             };
//             Console.WriteLine($"Sonuç: {result}");
//         }
//     }
//     static int ReadInt(string message)
//     {
//         while (true)
//         {
//             Console.Write(message);
//             if (int.TryParse(Console.ReadLine(), out int value))
//                 return value;

//             Console.WriteLine("Geçerli bir tam sayı giriniz!");
//         }
//     }

//     static double ReadDouble(string message)
//     {
//         while (true)
//         {
//             Console.Write(message);
//             if (double.TryParse(Console.ReadLine(), out double value))
//                 return value;

//             Console.WriteLine("Geçerli bir sayı giriniz!");
//         }
//     }


// }



// class Hesaplama
// {
//     static void Main(string[] args)
//     {
//         while (true)
//         {
//             Console.WriteLine("1-Hesapalama");
//             Console.WriteLine("0-Çıkış");

//             int secim = ReadInt("Seçiminiz: ");

//             if (secim == 0)
//             {
//                 Console.WriteLine("Program sonlandırıldı.");
//                 break;
//             }
//             if (secim != 1)
//             {
//                 Console.WriteLine("Geçersiz seçim, lütfen tekrar deneyin.");
//                 continue;
//             }

//             Console.WriteLine("1-Alan");
//             Console.WriteLine("2-Çevre");

//             int islemTipi = ReadInt("İşlem Tipi: ");
//             if(islemTipi<1 || islemTipi>2)
//             {
//                 Console.WriteLine("Geçersiz seçim, lütfen tekrar deneyin.");
//                 continue;
//             }

//             Console.WriteLine("1 - Üçgen");
//             Console.WriteLine("2 - Kare");
//             Console.WriteLine("3 - Dikdörtgen");
//             Console.WriteLine("4 - Daire");

//             int sekilTipi = ReadInt("Şekil Tipi: ");
//             if(sekilTipi<1 || sekilTipi>4)
//             {
//                 Console.WriteLine("Geçersiz seçim, lütfen tekrar deneyin.");
//                 continue;

//         }

//         double sonuc = 0;

//         if (sekilTipi == 1) // Üçgen
//             {
//                 Console.WriteLine("1 - Eşkenar Üçgen");
//                 Console.WriteLine("2 - İkizkenar Üçgen");
//                 Console.WriteLine("3 - Çeşitkenar Üçgen");

//                 int ucgenTipi = ReadInt("Üçgen Tipi: ");
//                 if(ucgenTipi<1 || ucgenTipi>3)
//                 {   
//                     Console.WriteLine("Geçersiz seçim, lütfen tekrar deneyin.");
//                     continue;
//                 }

//                 if (islemTipi == 1) // Alam
//                 {
//                     double taban = ReadDouble("Taban: ");
//                     double yukseklik = ReadDouble("Yükseklik: ");
//                     sonuc = (taban * yukseklik) / 2;
//                 }
//                 else // Çevre
//                 {
//                     double kenar1 = ReadDouble("Kenar 1: ");
//                     double kenar2 = ReadDouble("Kenar 2: ");
//                     double kenar3 = ReadDouble("Kenar 3: ");
//                     sonuc = kenar1 + kenar2 + kenar3;
//                 }
//             }

//                 else if (sekilTipi == 2) // Kare
//                 {
//                     double kenar = ReadDouble("Kenar: ");
//                     sonuc = islemTipi == 1 ? kenar * kenar : 4 * kenar;
//                 }
//                 else if (sekilTipi == 3) // Dikdörtgen
//                 {
//                     double uzunKenar = ReadDouble("Uzun Kenar: ");
//                     double kisaKenar = ReadDouble("Kısa Kenar: ");
//                     sonuc = islemTipi == 1 ? uzunKenar * kisaKenar : 2 * (uzunKenar + kisaKenar);
//                 }
//                 else if (sekilTipi == 4) // Daire
//                 {
//                     double yaricap = ReadDouble("Yarıçap: ");
//                     sonuc = islemTipi == 1 ? Math.PI * yaricap * yaricap : 2 * Math.PI * yaricap;
//                 }
//                   Console.WriteLine($"\nSonuç: {sonuc}");
//             }
//     }

// private static double ReadDouble(string message)
//     {
//         while (true)
//         {
//             Console.Write(message);
//             if (double.TryParse(Console.ReadLine(), out double value))
//                 return value;

//             Console.WriteLine("Geçerli bir sayı giriniz!");
//         }
//     }

//     private static int ReadInt(string message)
//     {
//         while (true)
//         {
//             Console.Write(message);
//             if (int.TryParse(Console.ReadLine(), out int value))
//                 return value;

//             Console.WriteLine("Geçerli bir tam sayı giriniz!");
//         }
//     }
// }



// class NotHesaplama
// {
//     static void Main(string[] args)
//     {
//         while (true)
//         {
//             Console.WriteLine("Not hesaplamak için H, çıkış için E: ");
//             string secim = Console.ReadLine().ToUpper();

//             if (secim == "E")
//             {
//                 Console.WriteLine("Program sonlandırıldı.");
//                 break;
//             }

//             if (secim != "H")
//             {
//                 Console.WriteLine("Geçersiz seçim, lütfen tekrar deneyin.");
//                 continue;
//             }

//             Console.WriteLine("Dersin adı: ");
//             string dersAdi = Console.ReadLine();

//             int adet = ReadInt("Kaç not gireceksiniz? ");

//             double toplam = 0;
//             int yuzde = 0;

//             for (int i = 1; i <= adet; i++)
//             {
//                 double not = ReadDouble($"{i}. not: ", 0, 100);
//                 int notYuzdesi = ReadInt($"{i}. notun yüzdesi: ", 0, 100);

//                 toplam += not * notYuzdesi / 100;
//                 yuzde += notYuzdesi;
//             }

//             if (yuzde != 100)
//             {
//                 Console.WriteLine("Not yüzdelerinin toplamı 100 olmalıdır.");
//                 continue;
//             }

//             string harf;
//             bool gecti;

//             if (toplam >= 85) harf = "AA";
//             else if (toplam >= 70) harf = "BB";
//             else if (toplam >= 60) harf = "CB";
//             else if (toplam >= 50) harf = "CC";
//             else harf = "FF";

//             gecti = harf != "FF";

//             Console.WriteLine("\nSonuç:");
//             Console.WriteLine($"Ders: {dersAdi}");
//             Console.WriteLine($"Ortalama: {toplam:F1}");
//             Console.WriteLine($"Harf Notu: {harf}");
//             Console.WriteLine(gecti ? "Durum: GEÇTİ" : "Durum: KALDI");
//         }
//     }

//     static double ReadDouble(string mesaj, double min, double max)
//     {
//         while (true)
//         {
//             Console.Write(mesaj);
//             if (double.TryParse(Console.ReadLine(), out double deger) && deger >= min && deger <= max)
//                 return deger;

//             Console.WriteLine("Geçerli bir sayı giriniz!");
//         }
//     }

//     static int ReadInt(string mesaj, int min = int.MinValue, int max = int.MaxValue)
//     {
//         while (true)
//         {
//             Console.Write(mesaj);
//             if (int.TryParse(Console.ReadLine(), out int deger) && deger >= min && deger <= max)
//                 return deger;

//             Console.WriteLine("Geçerli bir tam sayı giriniz!");
//         }
//     }
// }

// class PasscalUcgeni
// {
//     static void Main()
//     {
//         Console.Write("Kaç satır olsun? ");
//         int satir = int.Parse(Console.ReadLine());

//         for (int i = 0; i < satir; i++)
//         {
//             int sayi = 1;
//             for (int j = 0; j <= i; j++)
//             {
//                 Console.Write(sayi + " ");
//                 sayi = sayi * (i - j) / (j + 1);
//             }
//             Console.WriteLine();
//         }
        
//     }
// }


using System;
using System.Collections.Generic;
using System.Diagnostics;

class HafizaOyunu
{
    static void Main()
    {
        char[] harfler = { 'A','A','B','B','C','C','D','D','E','E','F','F','G','G','H','H' };
        Shuffle(harfler);

        bool[] acik = new bool[16];
        int adim = 0;
        Stopwatch sure = Stopwatch.StartNew();

        while (true)
        {
            EkraniYaz(harfler, acik);

            if (HepsiAcik(acik))
                break;

            int secim1 = KartSec(acik, "1. kartı seçiniz: ");
            acik[secim1] = true;
            EkraniYaz(harfler, acik);

            int secim2 = KartSec(acik, "2. kartı seçiniz: ");
            acik[secim2] = true;
            EkraniYaz(harfler, acik);

            adim++;

            if (harfler[secim1] != harfler[secim2])
{
    Console.WriteLine("Eşleşmedi!");
    System.Threading.Thread.Sleep(1500);
    acik[secim1] = acik[secim2] = false;
}
else
{
    Console.WriteLine("Eşleşti!");
    System.Threading.Thread.Sleep(1500);
}

        }

        sure.Stop();
        Console.WriteLine("\nOYUN BİTTİ!");
        Console.WriteLine($"Toplam adım sayısı: {adim}");
        Console.WriteLine($"Toplam süre: {sure.Elapsed.TotalMinutes:F2} dk");
    }

    static void EkraniYaz(char[] kartlar, bool[] acik)
    {
        Console.Clear();
        for (int i = 0; i < 16; i++)
        {
            if (acik[i])
                Console.Write($" {kartlar[i]} ");
            else
                Console.Write($" {i + 1} ");

            if ((i + 1) % 4 == 0)
                Console.WriteLine();
        }
        Console.WriteLine("--------------------");
    }

    static int KartSec(bool[] acik, string mesaj)
    {
        while (true)
        {
            Console.Write(mesaj);
            if (int.TryParse(Console.ReadLine(), out int secim))
            {
                secim--;
                if (secim >= 0 && secim < 16 && !acik[secim])
                    return secim;
            }
            Console.WriteLine("Geçersiz seçim!");
        }
    }

    static bool HepsiAcik(bool[] acik)
    {
        foreach (bool b in acik)
            if (!b) return false;
        return true;
    }

    static void Shuffle(char[] dizi)
    {
        Random rnd = new Random();
        for (int i = 0; i < dizi.Length; i++)
        {
            int j = rnd.Next(dizi.Length);
            (dizi[i], dizi[j]) = (dizi[j], dizi[i]);
        }
    }
}
