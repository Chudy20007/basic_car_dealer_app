using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadanie1
{
    abstract public class Samochody
    {
        protected int id;
        protected string marka;
        protected int rok_Produkcji;
        protected int km;
        protected string kolor;
        protected bool powypadkowe;
        protected string rodzaj_Paliwa;


         virtual public void dodaj()
        {


            Console.WriteLine("Podaj markę.");
            this.marka = Console.ReadLine();

            Console.WriteLine("Podaj kolor.");
            this.kolor = Console.ReadLine();

            Console.WriteLine("Powypadkowy?");
            this.powypadkowe = Boolean.Parse(Console.ReadLine());

            Console.WriteLine("Podaj przebieg (km).");
            this.km = Int32.Parse(Console.ReadLine());

            Console.WriteLine("Rok produkcji.");
            this.rok_Produkcji = Int32.Parse(Console.ReadLine());

            Console.WriteLine("Rodzaj paliwa.");
            this.rodzaj_Paliwa =Console.ReadLine();
        }

        virtual public void usun() { }

        virtual public void wyswietl()
        {
            Console.WriteLine("ID " + this.id);
            Console.WriteLine("Marka " + this.marka);
            Console.WriteLine("Rok produkcji " + this.rok_Produkcji);
            Console.WriteLine("Przebieg "+ this.km);
            Console.WriteLine("Kolor " + this.kolor);
            Console.WriteLine("Powypadkowe " + this.powypadkowe);
            Console.WriteLine("Rodzaj paliwa " + this.rodzaj_Paliwa);

        }

     

        public Samochody(int id, string marka, int rok_Produkcji, int km, string kolor, bool powypadkowe, string rodzaj_Paliwa)
        {
            this.id = id;
            this.marka = marka;
            this.rok_Produkcji = rok_Produkcji;
            this.km = km;
            this.kolor = kolor;
            this.powypadkowe = powypadkowe;
            this.rodzaj_Paliwa = rodzaj_Paliwa;
        }
    }
}
