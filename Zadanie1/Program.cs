using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Zadanie1
{
    class Program
    {
        static void Main(string[] args)
        {
            int wybor = 291;
            int idd=1;


            List<Samochody> Samochod = new List<Samochody>();
            do
            {
                Console.Clear();
                Console.WriteLine("0. Wyjdź z programu.");
                Console.WriteLine("1. Dodaj samochód rodzinny.");
                Console.WriteLine("2. Dodaj samochód terenowy.");
                Console.WriteLine("3. Dodaj samochód sportowy.");
                Console.WriteLine("4. Dodaj samochód luksusowy.");
                Console.WriteLine("5. Usuń samochód.");
                Console.WriteLine("6. Wyświetl listę samochodów.");
                wybor = int.Parse(Console.ReadLine());

                switch (wybor)
                {
                    case 1:
                        {

                           
                            Rodzinny sam_rodz = new Rodzinny(idd,"brak",0,0,"brak",false,"benzyna","osobowy","duża");

                            sam_rodz.dodaj();
                            Samochod.Add(sam_rodz);
                            sam_rodz.zapisz();
                            idd++;
                            break;
                        }

                    case 2:
                        {
                            
                            Terenowy sam_rodz = new Terenowy (idd, "brak", 0, 0, "brak", false, "benzyna",false);
       
                            sam_rodz.dodaj();
                            Samochod.Add(sam_rodz);
                            sam_rodz.zapisz();
                            idd++;
                            break;
                        }

                    case 3:
                        {
                            
                            Sportowy sam_rodz = new Sportowy(idd, "brak", 0, 0, "brak", false, "benzyna","zwykłe",2);

                            sam_rodz.dodaj();                          
                            Samochod.Add(sam_rodz);
                            sam_rodz.zapisz();
                            idd++;
                            break;
                        }

                    case 4:
                        {
                            
                            Luksusowy sam_rodz = new Luksusowy(idd, "brak", 0, 0, "brak", false, "benzyna", 'C',false);

                            sam_rodz.dodaj();
                            Samochod.Add(sam_rodz);
                            sam_rodz.zapisz();
                            idd++;
                            break;
                       } 

                    case 5:
                        {
                            Console.WriteLine("Który element chcesz usunąć?");
                            int numer = int.Parse(Console.ReadLine());
                            Samochod.RemoveAt(numer-1);
                
                            break;
                        }

                    case 6:
                        {
                            int i = 0;

                            foreach (Samochody x in Samochod)
                            {
                                i++;

                                Console.WriteLine("=================================");
                                Console.WriteLine("Element: " + i);
                                x.wyswietl();
                                Console.WriteLine();
                               
                            }
                           
                            Console.ReadLine();
                            break;
                        }
                }

            } while (wybor != 0);



        }

       
    }
}
