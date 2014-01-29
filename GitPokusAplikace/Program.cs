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
            int dude = 4;
            int vysledek = hello + dude;
            System.Console.WriteLine("TOMAS WAS HERE " + vysledek + " a Hello dne je: " + prom(10));
            System.Console.ReadKey();
        }

        static int prom(int hello)
        {
            return (hello * hello);
        }
    }
}
