using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eunyceRattrapage
{
    class Program
    {
        static void Main(string[] args)
        {
            Voiture v = new Voiture(2018, 500);
            Console.Out.WriteLine(v);
            v.Demarrer();
        }
    }
}
