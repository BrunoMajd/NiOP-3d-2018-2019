using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using klaseAndObjekti.Klase;

namespace klaseAndObjekti
{
    class Program
    {
        static void Main(string[] args)
        {
            Vozilo ime = new Vozilo();
            bool krug = true;

            do
            {
                Console.WriteLine("O kojem je vozilu rijec?");
                ime.setVrsta(Console.ReadLine().ToString());
                Console.WriteLine("Broj kotača: ");
                int brojKotaca = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Leti? (y/n)");
                bool leti;
                if (Console.ReadLine().ToLower() == "y") { leti = true; } else leti = false;
                Console.WriteLine("Pliva? (y/n)");
                bool pliva;
                if (Console.ReadLine().ToLower() == "y") { pliva = true; } else pliva = false;
                bool vozi;
                Console.WriteLine("Vozi? (y/n)");
                if (Console.ReadLine().ToLower() == "y") { vozi = true; } else vozi = false;
                Console.WriteLine("Vrsta: ");
                string vrsta = Console.ReadLine();
                Console.WriteLine("Oznaka: ");
                string oznaka = Console.ReadLine();
                Vozilo objVozilo = new Vozilo(brojKotaca, leti, pliva, vozi, vrsta, oznaka);
                Console.WriteLine(objVozilo.ToString());
                Console.WriteLine("Unesti jos jedno vozilo? (y/n)");
                if (Console.ReadLine().ToLower() == "y") { krug = true; } else krug = false;
            } while (krug == true);

            Console.WriteLine("Kraj unosa.");


            Console.ReadLine();

        }

    }

}

    
