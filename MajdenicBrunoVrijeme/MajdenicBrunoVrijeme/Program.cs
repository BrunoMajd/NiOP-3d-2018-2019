using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MajdenicBrunoVrijeme
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime novaGodina = new DateTime(DateTime.Now.Year + 1, 1, 1);
            TimeSpan preostalo = novaGodina - DateTime.Now;
            Console.WriteLine("Do Nove godine preostalo je:");
            Console.WriteLine("{0}dana, {1}sati, {2}minuta , {3} sekundi", preostalo.Days, preostalo.Hours, preostalo.Minutes, preostalo.Seconds);
            Console.WriteLine("U danima: {0}", preostalo.TotalDays);
            Console.WriteLine("U satima: {0}", preostalo.TotalHours);
            Console.WriteLine("U minutama: {0}", preostalo.TotalMinutes);
            Console.WriteLine("U sekundama: {0}", preostalo.TotalSeconds);
            Console.ReadKey();
        }
    }
}
