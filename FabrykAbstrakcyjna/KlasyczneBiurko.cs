using System;
using System.Collections.Generic;
using System.Text;

namespace FabrykAbstrakcyjna
{
    class KlasyczneBiurko : Biurko
    {
        private int waga;

        public KlasyczneBiurko(int _cena, string _material, int _liczbadrzwi, int _liczbapolek, int _liczbaszuflad, int _wysokosc, int _dlugosc, int _waga) : base(_cena, _material, _liczbadrzwi, _liczbapolek, _liczbaszuflad, _wysokosc, _dlugosc)
        {
            waga = _waga;
        }
        public override string ToString()
        {
            return "Biurko w stylu klasycznym\nmateriał: " + material + "\nliczba drzwi: " + liczbadrzwi + "\nilość półek: " + liczbapolek + "\nilość szuflad: " + liczbaszuflad + "\nwyokość: " + wysokosc + "\nszerokość: " + dlugosc + "\nwaga: " + waga + "\ncena: " + cena;

        }
    }
}
