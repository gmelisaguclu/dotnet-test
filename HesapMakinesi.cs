using System;

class HesapMakinesi
{
    public static void Run()
    {
        string[] menu =
        {
            "1 - Toplama",
            "2 - Çıkarma",
            "3 - Çarpma",
            "4 - Bölme",
            "5 - Mod alma",
            "0 - Çıkış"
        };

        while (true)
        {
            foreach (string item in menu)
            {
                Console.WriteLine(item);
            }

            int secim = ReadInt("Seçiminiz: ");

            if (secim == 0)
            {
                Console.WriteLine("Program sonlandırıldı.");
                break;
            }

            if (secim < 1 || secim > 5)
            {
                Console.WriteLine("Geçersiz seçim, lütfen tekrar deneyin.");
                continue;
            }

            if (secim == 5) // Mod alma
            {
                int a = ReadInt("1. sayı: ");
                int b = ReadInt("2. sayı: ");
                Console.WriteLine($"Sonuç: {a % b}");
                continue;
            }

            double x = ReadDouble("1. sayı: ");
            double y = ReadDouble("2. sayı: ");

            if (secim == 4 && y == 0)
            {
                Console.WriteLine("Bölen 0 olamaz!");
                continue;
            }

            double result = secim switch
            {
                1 => x + y,
                2 => x - y,
                3 => x * y,
                4 => x / y,
                _ => 0
            };

            Console.WriteLine($"Sonuç: {result}");
        }
    }

    static int ReadInt(string message)
    {
        while (true)
        {
            Console.Write(message);
            if (int.TryParse(Console.ReadLine(), out int value))
                return value;

            Console.WriteLine("Geçerli bir tam sayı giriniz!");
        }
    }

    static double ReadDouble(string message)
    {
        while (true)
        {
            Console.Write(message);
            if (double.TryParse(Console.ReadLine(), out double value))
                return value;

            Console.WriteLine("Geçerli bir sayı giriniz!");
        }
    }
}
