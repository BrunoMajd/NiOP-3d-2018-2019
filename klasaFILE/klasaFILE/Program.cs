using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace klasaFILE
{
    class Program
    {
        static void Main(string[] args)
        {
            {
                Console.Write("Unesite vase ime:");
                string ime = Console.ReadLine();
                string datoteka = "ime.txt";
                if (File.Exists(datoteka))
                {
                    if (Directory.Exists("backup"))
                    {
                        Directory.CreateDirectory("backup");
                    }
                    File.Copy(datoteka, "backup\\ime" + DateTime.Now.ToString("yyyy_MM_dd_HH_mm_ss") + ".txt");
                    File.Delete(datoteka);
                }
                File.WriteAllText(datoteka, ime);
                Console.ReadKey();
            }
        }
    }
}

