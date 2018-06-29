using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadanie1
{
    class Luksusowy : Samochody
    {
        protected char klasa;
        bool podgrzewane_Fotele;

        public Luksusowy(int id, string marka, int rok_Produkcji, int k, string kol, bool powypadkowe,string rodzaj_Paliwa,char klasa, bool podgrzewane_Fotele) : base(id, marka, rok_Produkcji, k, kol, powypadkowe,rodzaj_Paliwa)
        {
            this.klasa = klasa;
            this.podgrzewane_Fotele = podgrzewane_Fotele;
        }

         override public void dodaj()
         {
            base.dodaj();

            Console.WriteLine("Klasa wyposażenia.");
            this.klasa = Char.Parse(Console.ReadLine());

            Console.WriteLine("Podgrzewane fotele.");
            this.podgrzewane_Fotele = bool.Parse(Console.ReadLine());

        }

        override public void usun() { }

        public void zapisz()
        {
            Console.WriteLine("Luksusowy samochód został dodany do bazy.");
            Console.ReadLine();
        }

        override public void wyswietl()
        {
            base.wyswietl();
            Console.WriteLine("Klasa wyposażenia " + this.klasa);
            Console.WriteLine("Podgrzewane fotele " + this.podgrzewane_Fotele);
        }
    }
}
