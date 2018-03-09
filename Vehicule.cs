using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eunyceRattrapage
{
    class Caminion: Vehicule
    {
        public Caminion(int anneemodele, int prix ): base (anneemodele,prix)
        {

        }
        public override string Demarrer()
        {
            Console.WriteLine(" demarrage");
            return null;
        }
        public override string accelerer()
        {
            Console.WriteLine(" Accelerer");
        }
    }
}
