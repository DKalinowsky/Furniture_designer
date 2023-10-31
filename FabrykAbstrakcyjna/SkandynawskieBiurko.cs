using System;
using System.Collections.Generic;
using System.Text;

namespace FabrykAbstrakcyjna
{
    class SkandynawskieBiurko : Biurko
    {
        private string krajprodukcji;

        public SkandynawskieBiurko(int _cena, string _material, int _liczbadrzwi, int _liczbapolek, int _liczbaszuflad, int _wysokosc, int _szerokosc, string _krajprodukcji) : base(_cena, _material, _liczbadrzwi, _liczbapolek, _liczbaszuflad, _wysokosc, _szerokosc)
        {
            krajprodukcji = _krajprodukcji;
        }
        public override string ToString()
        {
            return "Biurko w stylu skandynawskim\nmateriał: " + material + "\nliczba drzwi: " + liczbadrzwi + "\nilość półek: " + liczbapolek + "\nilość szuflad: " + liczbaszuflad + "\nwyokość: " + wysokosc + "\nszerokość: " + dlugosc + "\nkraj produkcji: " + krajprodukcji + "\ncena: " + cena;

        }
    }
}
