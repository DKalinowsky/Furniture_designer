using System;
using System.Collections.Generic;
using System.Text;

namespace FabrykAbstrakcyjna
{
    class KlasycznaSzafa : Szafa
    {
        private int weight;

        public KlasycznaSzafa(int _cena, string _material, int _liczbadrzwi, int _liczbapolek, int _liczbaszuflad, int _wysokosc, int _szerokosc, int _weight) : base(_cena, _material, _liczbadrzwi, _liczbapolek, _liczbaszuflad, _wysokosc, _szerokosc)
        {
            weight = _weight;
        }
        public override string ToString()
        {
            return "Szafa w stylu klasycznym\nmateriał: " + material + "\nliczba drzwi: " + liczbadrzwi + "\nilość półek: " + liczbapolek  + "\nilość szuflad: " + liczbaszuflad + "\nwyokość: " + wysokosc + "\nszerokość: " + szerokosc + "\nwaga: " + weight + "\ncena: " + cena;

        }
    }
}
