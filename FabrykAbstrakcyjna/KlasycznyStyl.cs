using System;
using System.Collections.Generic;
using System.Text;

namespace FabrykAbstrakcyjna
{
    class KlasycznyStyl : ProjektantWnetrz 
    {
        public override Biurko WyprodukujBiurko(int limitCeny)
        {
            if (limitCeny >= 1000)
            {
                return new KlasyczneBiurko(1899, "bambus", 2, 2, 2, 1, 2, 100);
            }
            else if (limitCeny >= 500 && limitCeny < 1000)
            {
                return new KlasyczneBiurko(899, "dab", 2, 2, 2, 1, 2, 70);
            }
            else if (limitCeny >= 300 && limitCeny < 500)
            {
                return new KlasyczneBiurko(359, "pleksa", 1, 1, 1, 1, 2, 50);
            }
            else
                return null;
        }

        public override Szafa WyprodukujSzafe(int limitCeny)
        {
            if (limitCeny >= 1000)
            {
                return new KlasycznaSzafa(2199, "bambus", 4, 4, 8, 2, 1, 10);
            }
            else if (limitCeny >= 500 && limitCeny < 1000)
            {
                return new KlasycznaSzafa(599, "kasztan", 2, 2, 6, 2, 1, 10);
            }
            else if (limitCeny >= 300 && limitCeny < 500)
            {
                return new KlasycznaSzafa(319, "sosna", 2, 1, 2, 2, 1, 10);
            }
            else
                return null;
        }
    }
}
