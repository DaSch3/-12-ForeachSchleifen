using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ForeachSchleifen
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] zahlenListe = new int[5];

            zahlenListe[0] = 10;
            zahlenListe[1] = 20;
            zahlenListe[2] = 30;
            zahlenListe[3] = 40;
            zahlenListe[4] = 50;

            foreach(int zahl in zahlenListe)
            {
                Console.WriteLine(zahl);
            }

            Console.ReadKey();
        }
    }
}
