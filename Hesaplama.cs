using System;

class Hesaplama
{
    public static void  Run()
    {
        while (true)
        {
            Console.WriteLine("1-Hesaplama");
            Console.WriteLine("0-Çıkış");

            int secim = ReadInt("Seçiminiz: ");

            if (secim == 0)
            {
                Console.WriteLine("Program sonlandırıldı.");
                break;
            }
            if (secim != 1)
            {
                Console.WriteLine("Geçersiz seçim, lütfen tekrar deneyin.");
                continue;
            }

            Console.WriteLine("1-Alan");
            Console.WriteLine("2-Çevre");

            int islemTipi = ReadInt("İşlem Tipi: ");
            if (islemTipi < 1 || islemTipi > 2)
            {
                Console.WriteLine("Geçersiz seçim, lütfen tekrar deneyin.");
                continue;
            }

            Console.WriteLine("1 - Üçgen");
            Console.WriteLine("2 - Kare");
            Console.WriteLine("3 - Dikdörtgen");
            Console.WriteLine("4 - Daire");

            int sekilTipi = ReadInt("Şekil Tipi: ");
            if (sekilTipi < 1 || sekilTipi > 4)
            {
                Console.WriteLine("Geçersiz seçim, lütfen tekrar deneyin.");
                continue;
            }

            double sonuc = 0;

            if (sekilTipi == 1) // Üçgen
            {
                Console.WriteLine("1 - Eşkenar Üçgen");
                Console.WriteLine("2 - İkizkenar Üçgen");
                Console.WriteLine("3 - Çeşitkenar Üçgen");

                int ucgenTipi = ReadInt("Üçgen Tipi: ");
                if (ucgenTipi < 1 || ucgenTipi > 3)
                {
                    Console.WriteLine("Geçersiz seçim, lütfen tekrar deneyin.");
                    continue;
                }

                if (islemTipi == 1) // Alan
                {
                    double taban = ReadDouble("Taban: ");
                    double yukseklik = ReadDouble("Yükseklik: ");
                    sonuc = (taban * yukseklik) / 2;
                }
                else // Çevre
                {
                    double kenar1 = ReadDouble("Kenar 1: ");
                    double kenar2 = ReadDouble("Kenar 2: ");
                    double kenar3 = ReadDouble("Kenar 3: ");
                    sonuc = kenar1 + kenar2 + kenar3;
                }
            }
            else if (sekilTipi == 2) // Kare
            {
                double kenar = ReadDouble("Kenar: ");
                sonuc = islemTipi == 1 ? kenar * kenar : 4 * kenar;
            }
            else if (sekilTipi == 3) // Dikdörtgen
            {
                double uzunKenar = ReadDouble("Uzun Kenar: ");
                double kisaKenar = ReadDouble("Kısa Kenar: ");
                sonuc = islemTipi == 1
                    ? uzunKenar * kisaKenar
                    : 2 * (uzunKenar + kisaKenar);
            }
            else if (sekilTipi == 4) // Daire
            {
                double yaricap = ReadDouble("Yarıçap: ");
                sonuc = islemTipi == 1
                    ? Math.PI * yaricap * yaricap
                    : 2 * Math.PI * yaricap;
            }

            Console.WriteLine($"\nSonuç: {sonuc}\n");
        }
    }

    private static double ReadDouble(string message)
    {
        while (true)
        {
            Console.Write(message);
            if (double.TryParse(Console.ReadLine(), out double value))
                return value;

            Console.WriteLine("Geçerli bir sayı giriniz!");
        }
    }

    private static int ReadInt(string message)
    {
        while (true)
        {
            Console.Write(message);
            if (int.TryParse(Console.ReadLine(), out int value))
                return value;

            Console.WriteLine("Geçerli bir tam sayı giriniz!");
        }
    }
}
