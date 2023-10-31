using System;
using System.Collections.Generic;
using System.Text;

namespace FabrykAbstrakcyjna
{
    class NowoczesnyStyl : ProjektantWnetrz
    {
        public override Biurko WyprodukujBiurko(int limitCeny)
        {
            if (limitCeny >= 1000)
            {
                return new NowoczesneBiurko(2199, "szkło", 0, 0, 0, 1, 2, "biały", "hartowane");
            }
            else if (limitCeny < 1000 && limitCeny >= 300)
            {
                return new NowoczesneBiurko(999, "szkło", 0, 0, 0, 1, 2, "biały", "zwykłe");
            }
            else
                return null;
        }

        public override Szafa WyprodukujSzafe(int limitCeny)
        {
            if (limitCeny >= 1000)
            {
                return new NowoczesnaSzafa(2199, "drewno", 2, 2, 2, 2, 1, "biały");
            }
            else if (limitCeny < 1000 && limitCeny >= 300)
            {
                return new NowoczesnaSzafa(599, "kasztan", 2, 2, 6, 2, 1, "szary");
            }
            else
                return null;
        }
    }
}
