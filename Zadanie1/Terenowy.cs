using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadanie1
{
    class Terenowy : Samochody
    {
        bool naped4x4;

        public Terenowy(int id, string marka, int rok_Produkcji, int k, string kol, bool powypadkowe, string rodzaj_Paliwa,bool naped4x4) : base(id, marka, rok_Produkcji, k, kol, powypadkowe, rodzaj_Paliwa)
        {
            this.naped4x4 = naped4x4;
        }

         override public void dodaj()
         {
            base.dodaj();
           Console.WriteLine("Napęd 4x4?");
           this.naped4x4 = bool.Parse(Console.ReadLine());
         }   

         override public void usun() { }

        public void zapisz()
        {
            Console.WriteLine("Terenowy samochód został dodany do bazy.");
            Console.ReadLine();
        }

        override public void wyswietl()
         {
            base.wyswietl();
            Console.WriteLine("Napęd 4x4 " + this.naped4x4);
        }
    }
}
