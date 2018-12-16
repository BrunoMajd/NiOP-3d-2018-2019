using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace klasaPATH
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Unesite putanju izvornog direktorija:");
            string izvorniDirektorij = Console.ReadLine();
            Console.Write("Unesite putanju ciljnog direktorija:");
            string ciljniDirektorij = Console.ReadLine();
            try
            {
            foreach (string datoteka
            in Directory.GetFiles(izvorniDirektorij))
                {
                    string imeDatoteke = Path.GetFileName(datoteka);
                    string ciljnaDatoteka
                    = Path.Combine(ciljniDirektorij, imeDatoteke);
                    File.Copy(datoteka, ciljnaDatoteka, true);
                }
                Console.WriteLine("Gotovo!");
            }
            catch (Exception ex)
            {
                Console.WriteLine("GreSska: { 0}", ex.Message);
            }
            Console.ReadKey();
        }
    }
}
