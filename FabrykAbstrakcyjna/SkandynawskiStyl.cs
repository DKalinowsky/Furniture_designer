using System;
using System.Collections.Generic;
using System.Text;

namespace FabrykAbstrakcyjna
{
    class SkandynawskiStyl : ProjektantWnetrz
    {
        public override Biurko WyprodukujBiurko(int limitCeny)
        {
            if (limitCeny >= 1000)
            {
                return new SkandynawskieBiurko(1299, "drewno", 1, 2, 2, 1, 2, "Szwecja");
            }
            else if (limitCeny < 1000 && limitCeny >= 300)
            {
                return new SkandynawskieBiurko(499, "drewno", 1, 1, 1, 1, 2, "Norwegia");
            }
            else
                return null;
        }

        public override Szafa WyprodukujSzafe(int limitCeny)
        {
            if (limitCeny >= 1000)
            {
                return new SkandynawskaSzafa(1199, "drewno", 2, 8, 4, 2, 1, "Szwecja");
            }
            else if (limitCeny < 1000 && limitCeny >= 300)
            {
                return new SkandynawskaSzafa(679, "drewno", 2, 6, 2, 2, 1, "Norwegia");
            }
            else
                return null;
        }
    }
}
