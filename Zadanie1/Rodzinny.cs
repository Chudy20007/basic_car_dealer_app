using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadanie1
{
   public class Rodzinny : Samochody
    {
        protected string typ_samochodu;
        protected string ekonomicznosc;

        public Rodzinny(int id, string marka, int rok_Produkcji, int k, string kol, bool powypadkowe, string rodzaj_Paliwa, string typ, string ekonomicznosc) : base(id, marka, rok_Produkcji, k, kol, powypadkowe, rodzaj_Paliwa )
        {
            this.typ_samochodu = typ_samochodu;
            this.ekonomicznosc = ekonomicznosc;
            
        }

        override public void dodaj()
        {

            base.dodaj();
            Console.WriteLine("Typ samochodu.");
            this.typ_samochodu = Console.ReadLine();

        }

        public void zapisz()
        {
            Console.WriteLine("Rodzinny samochód został dodany do bazy.");
            Console.ReadLine();
        }

        override public void usun() { }

        override public void wyswietl()
        {

            base.wyswietl();
            Console.WriteLine("Typ samochodu "+this.typ_samochodu);
        }

        
    }
}
