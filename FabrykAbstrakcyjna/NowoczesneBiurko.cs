using System;
using System.Collections.Generic;
using System.Text;

namespace FabrykAbstrakcyjna
{
    class NowoczesneBiurko : Biurko
    {
        private string kolorledow;
        private string rodzajszkla;

        public NowoczesneBiurko(int _cena, string _material, int _liczbadrzwi, int _liczbapolek, int _liczbaszuflad, int _wysokosc, int _szerokosc, string _kolorledow, string _rodzajszkla) : base(_cena, _material, _liczbadrzwi, _liczbapolek, _liczbaszuflad, _wysokosc, _szerokosc)
        {
            kolorledow = _kolorledow;
            rodzajszkla = _rodzajszkla;
        }
        public override string ToString()
        {
            return "Biurko w stylu nowoczesnym\nmateriał: " + material + "\nliczba drzwi: " + liczbadrzwi + "\nilość półek: " + liczbapolek + "\nilość szuflad: " + liczbaszuflad + "\nwyokość: " + wysokosc + "\nszerokość: " + dlugosc + "\nkolor ledow: " + kolorledow + "\nrodzaj szkła: " + rodzajszkla + "\ncena: " + cena;

        }
    }
}
