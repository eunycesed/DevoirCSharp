using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eunyceRattrapage
{
   abstract class Vehicule
    {
        int matricule;
        int anneemodele;
        int prix;
        static int nbrevihi = 0;
    
    public int Matricule
    {
        get { return matricule; }
        set { matricule = value; }


    }

        public int Anneemodele
        {
            get
            { return anneemodele; }
            set  { anneemodele = value; }
        }
        public int Prix
        {
            get
            { return prix; }
            set
            { prix = value; }


        }
        public static int Nbrevihi
        {
            get
            { return nbrevihi; }
        }

        public Vehicule (int matricule, int anneemodele, int prix)
        {
            nbrevihi++;
            matricule = nbrevihi;
            this.Anneemodele = 0;
            this.prix = prix;

        }
      

        public abstract string demarrer();
        public abstract string accelerer();

        public override string ToString()
        {
            return "Matricule" + this.matricule + " Annemodele" + this.anneemodele.ToString() + " prix" + this.prix;

        }



    }

}
