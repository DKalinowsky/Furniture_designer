using System;

namespace FabrykAbstrakcyjna
{
    class Program
    {
        static void Main(string[] args)
        {
            KlasycznyStyl kstyl = new KlasycznyStyl();
            Biurko biurko1 = kstyl.WyprodukujBiurko(679);
            Szafa szafa1 = kstyl.WyprodukujSzafe(1000);

            NowoczesnyStyl mstyl = new NowoczesnyStyl();
            Biurko biurko2 = mstyl.WyprodukujBiurko(3000);
            Szafa szafa2 = mstyl.WyprodukujSzafe(3000);

            SkandynawskiStyl sstyl = new SkandynawskiStyl();
            Biurko biurko3 = sstyl.WyprodukujBiurko(1500);
            Szafa szafa3 = sstyl.WyprodukujSzafe(1000);

            Console.WriteLine(biurko1);
            Console.WriteLine(szafa1);
            Console.WriteLine(biurko2);
            Console.WriteLine(szafa2);
            Console.WriteLine(biurko3);
            Console.WriteLine(szafa3);

        }
    }
}
