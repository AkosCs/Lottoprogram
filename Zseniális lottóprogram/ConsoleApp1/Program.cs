using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            const int n = 1000; //elemszám
            int[] vektor = new int[n];




            //feltöltés bejárással
            Random r = new Random();
            for (int i = 0; i < n; i++)
            {
                vektor[i] = r.Next(10, 100);
            }

            Console.WriteLine("Az eredeti tömb: ");

            foreach(int egyelem in vektor)
            {
                Console.Write(egyelem+";\t");
            }





            //Összegzés tétele: a tömb elemeinek összege
            //Teljes összegzés
            int szum = 0;
            for (int i = 0; i < n; i++)
            {
                szum += vektor[i];
            }
            Console.WriteLine("\n\nAz elemek összege: " + szum);




            //részleges összegzés:
            //T tulajdonságú elemek összege (párosak)
            szum = 0;
            for (int i = 0; i < n; i++)
            {
                if (vektor[i]%2==0)
                {
                    szum += vektor[i];
                }
            }
            Console.WriteLine("A pár. elemek összege: " + szum);




            //megszámlálás tétele
            //? T tul. elem van (prímek)

            int db = 0;
            for (int i = 0; i < n; i++)
            {
                if (ezprim(vektor[i])) db++;
            }

            Console.WriteLine("A vektorban {0} db prím van.", db);

            //eldöntés tétele
            //Szerepel-e a tömbben T tul. elem?

            Console.Write("Melyik szám érdekel? ");
            int sz = int.Parse(Console.ReadLine());
            bool szerepel = false;
            for (int i = 0; i < n; i++)
            {
                if (vektor[i]==sz)
                {
                    szerepel = true;
                    break;
                }
            }

            Console.Write("A keresett elem ");
            if (!szerepel) Console.Write("nem ");
            Console.WriteLine("szerepel a vektorban.");



            //kiválasztás tételek:
            //szélsőértékek megh: min. max.

            int min = vektor[0], max = vektor[0];
            for (int i = 1; i < n; i++)
            {
                if (vektor[i] < min) min = vektor[i];
                if (vektor[i] > max) max = vektor[i];
            }

            Console.WriteLine("A min. érték: " + min);
            Console.WriteLine("A max érték: " + max);






            //szélsőértékek meghat.


            int minind = 0, maxind = 0;
            for (int i = 1; i < n; i++)
            {
                if (vektor[i] < vektor[minind]) minind = i;
            if (vektor[i] > vektor[maxind]) maxind = i;
            }
            Console.WriteLine("A min indexe: " + minind);
            Console.WriteLine("A max indexe: " + maxind);

            //kiválogatás
            //szétválogatás
            //metszet
            //unió

            
       





            Console.ReadLine();

        }

        static bool ezprim(int szam)
        {
            bool az = true;
            for(int i=2;i<szam/2+1;i++)
            {
                if (szam%i==0)
                {
                    az = false;
                    break;
                }
            }
            return az;
        }
    }
}
