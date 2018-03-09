using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eunyceRattrapage
{
    class Voiture : Vehicule
    {
        public Voiture(int anneemodele, int prix) : base(anneemodele, prix)
        {
           
        }

        public override string accelerer()
        {
            throw new NotImplementedException();
        }

        public override string demarrer()
        {
            Console.WriteLine("Demarer");
        
        }
    }
     
}
    
