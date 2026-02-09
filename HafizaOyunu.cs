using System;
using System.Collections.Generic;
using System.Diagnostics;

class HafizaOyunu
{
    public static void Run()
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
