using System;
using System.Collections.Generic;
using System.Text;

namespace FabrykAbstrakcyjna
{
    abstract class Szafa
    {
        public int cena;
        public string material;
        public int liczbadrzwi;
        public int liczbapolek;
        public int liczbaszuflad;
        public int wysokosc;
        public int szerokosc;

        public int Cena
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

        public Szafa(int _cena, string _material, int _liczbadrzwi, int _liczbapolek, int _liczbaszuflad, int _wysokosc, int _szerokosc)
        {
            Cena = _cena;
            material = _material;
            liczbadrzwi = _liczbadrzwi;
            liczbapolek = _liczbapolek;
            liczbaszuflad = _liczbaszuflad;
            wysokosc = _wysokosc;
            szerokosc = _szerokosc;
        }

    }
}
