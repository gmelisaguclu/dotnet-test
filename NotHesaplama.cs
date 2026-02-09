using System;

static class NotHesaplama
{
    public static void Run()
    {
        while (true)
        {
            Console.WriteLine("Not hesaplamak için H, çıkış için E: ");
            string ? secim = Console.ReadLine().ToUpper();
            if (secim == null)
               {
                  Console.WriteLine("seçim boş olamaz, lütfen tekrar deneyin.");
                  continue;
        }  

 
            if (secim == "E")
            {
                Console.WriteLine("Program sonlandırıldı.");
                break;
            }

            if (secim != "H")
            {
                Console.WriteLine("Geçersiz seçim, lütfen tekrar deneyin.");
                continue;
            }

            Console.WriteLine("Dersin adı: ");
            string ? dersAdi = Console.ReadLine();
            if (dersAdi == null)
            {
                Console.WriteLine("Ders adı boş olamaz!");
                continue;
            }

            int adet = ReadInt("Kaç not gireceksiniz? ");

            double toplam = 0;
            int yuzdeToplam = 0;

            for (int i = 1; i <= adet; i++)
            {
                double not = ReadDouble($"{i}. not: ", 0, 100);
                int notYuzdesi = ReadInt($"{i}. notun yüzdesi: ", 0, 100);

                toplam += not * notYuzdesi / 100;
                yuzdeToplam += notYuzdesi;
            }

            if (yuzdeToplam != 100)
            {
                Console.WriteLine("Not yüzdelerinin toplamı 100 olmalıdır.");
                continue;
            }

            string harfNotu;
            bool gecti;

            if (toplam >= 85) harfNotu = "AA";
            else if (toplam >= 70) harfNotu = "BB";
            else if (toplam >= 60) harfNotu = "CB";
            else if (toplam >= 50) harfNotu = "CC";
            else harfNotu = "FF";

            gecti = harfNotu != "FF";

            Console.WriteLine("\nSonuç:");
            Console.WriteLine($"Ders: {dersAdi}");
            Console.WriteLine($"Ortalama: {toplam:F1}");
            Console.WriteLine($"Harf Notu: {harfNotu}");
            Console.WriteLine(gecti ? "Durum: GEÇTİ" : "Durum: KALDI");
        }
    }

    static double ReadDouble(string mesaj, double min, double max)
    {
        while (true)
        {
            Console.Write(mesaj);
            if (double.TryParse(Console.ReadLine(), out double deger) &&
                deger >= min && deger <= max)
                return deger;

            Console.WriteLine("Geçerli bir sayı giriniz!");
        }
    }

    static int ReadInt(string mesaj, int min = int.MinValue, int max = int.MaxValue)
    {
        while (true)
        {
            Console.Write(mesaj);
            if (int.TryParse(Console.ReadLine(), out int deger) &&
                deger >= min && deger <= max)
                return deger;

            Console.WriteLine("Geçerli bir tam sayı giriniz!");
        }
    }
}
