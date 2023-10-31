using System;
using System.Collections.Generic;
using System.Text;

namespace FabrykAbstrakcyjna
{
    abstract class ProjektantWnetrz
    {
        public abstract Biurko WyprodukujBiurko(int limitCeny);

        public abstract Szafa WyprodukujSzafe(int limitCeny);
    }
}
