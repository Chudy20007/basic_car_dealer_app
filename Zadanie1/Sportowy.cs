using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadanie1
{
    class Sportowy : Samochody
    {
        protected string rodzaj_Nadwozia;
        protected byte liczba_Cylindrow;

        public Sportowy(int id, string marka, int rok_Produkcji, int k, string kol, bool powypadkowe, string rodzaj_Paliwa,string rodzaj_Nadwozia, byte liczba_Cylindrow) : base(id, marka, rok_Produkcji, k, kol, powypadkowe, rodzaj_Paliwa)
        {
            this.liczba_Cylindrow = liczba_Cylindrow;
            this.rodzaj_Nadwozia = rodzaj_Nadwozia;
        }

         override public void dodaj()
         {
            base.dodaj();
            Console.WriteLine("Rodzaj nadwozia.");
            this.rodzaj_Nadwozia = Console.ReadLine();

            Console.WriteLine("Liczba cylindrów.");
            this.liczba_Cylindrow = byte.Parse(Console.ReadLine());
         }

        public void zapisz()
        {
            Console.WriteLine("Sportowy samochód został dodany do bazy.");
            Console.ReadLine();
        }

        override public void usun() { }

        override public void wyswietl()
        {
            base.wyswietl();
            Console.WriteLine("Rodzaj nadwozia " + this.rodzaj_Nadwozia);
            Console.WriteLine("Liczba cylindrów " + this.liczba_Cylindrow);
        }


    }
}
