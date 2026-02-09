using System;

class PasscalUcgeni
{
    public static void Run()
    {
        Console.Write("Kaç satır olsun? ");
        int satir = int.Parse(Console.ReadLine());

        for (int i = 0; i < satir; i++)
        {
            int sayi = 1;

            for (int j = 0; j <= i; j++)
            {
                Console.Write(sayi + " ");
                sayi = sayi * (i - j) / (j + 1);
            }

            Console.WriteLine();
        }
    }
}
