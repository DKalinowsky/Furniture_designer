using System;
using System.Collections.Generic;
using System.Text;

namespace FabrykAbstrakcyjna
{
    abstract class Biurko
    {
        public int cena;
        public string material;
        public int liczbadrzwi;
        public int liczbapolek;
        public int liczbaszuflad;
        public int dlugosc;
        public int wysokosc;

        public int Koszt
        {
            get { return cena; }
            set
            {
                if (value < 0)
                {
                    Console.WriteLine("Cena nie może być ujemny !");
                }
                else
                {
                    cena = value;
                }
            }
        }

        public Biurko(int _cena, string _material, int _liczbadrzwi, int _liczbapolek, int _liczbaszuflad, int _dlugosc, int _wysokosc)
        {
            Koszt = _cena;
            material = _material;
            liczbadrzwi = _liczbadrzwi;
            liczbapolek = _liczbapolek;
            liczbaszuflad = _liczbaszuflad;
            dlugosc = _dlugosc;
            wysokosc = _wysokosc;
        }
    }
}
