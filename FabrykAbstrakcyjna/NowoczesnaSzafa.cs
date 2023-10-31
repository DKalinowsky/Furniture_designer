using System;
using System.Collections.Generic;
using System.Text;

namespace FabrykAbstrakcyjna
{
    class NowoczesnaSzafa : Szafa
    {
        private string kolorledow;

        public NowoczesnaSzafa(int _cena, string _material, int _liczbadrzwi, int _liczbapolek, int _liczbaszuflad, int _wysokosc, int _szerokosc, string _kolorledow) : base(_cena, _material, _liczbadrzwi, _liczbapolek, _liczbaszuflad, _wysokosc, _szerokosc)
        {
            kolorledow = _kolorledow;
        }
        public override string ToString()
        {
            return "Szafa w stylu nowoczesnym\nmateriał: " + material + "\nliczba drzwi: " + liczbadrzwi + "\nilość półek: " + liczbapolek + "\nilość szuflad: " + liczbaszuflad + "\nwyokość: " + wysokosc + "\nszerokość: " + szerokosc + "\nkolor ledow: " + kolorledow + "\ncena: " + cena;

        }
    }
}
