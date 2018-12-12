using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Initial_C
{
    class Bateau : Véhicule
    {
        private double longueur;

        public Bateau(int id, string etat, string constructeur, string modèle, int km, double longueur) :base (id, etat, constructeur, modèle, km)
        {
            this.Longueur = longueur;
        }

        public double Longueur
        {
            get
            {
                return longueur;
            }

            set
            {
                longueur = value;
            }
        }
    }
}
