using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GitPokusAplikace
{
    class Program
    {
        static void Main(string[] args)
        {
            int hello = 5;
            int dude = 6;
            int vysledek = hello + dude;
            System.Console.WriteLine("Sbohem zly svete, soucet helloduda je " + vysledek + " a Hello dne je: " + prom(10));
            System.Console.ReadKey();
        }

        static int prom(int hello)
        {
            return (hello * hello);
        }
    }
}
