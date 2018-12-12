using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Initial_C
{
    class Camion : Véhicule
    {
        private float capacitéDeCharge;
        private int hauteur;

        public Camion(int id, string etat, string constructeur, string modèle, int km, float capacitéDeCharge, int hauteur): base(id, etat, constructeur, modèle, km)
        {
            this.CapacitéDeCharge = capacitéDeCharge;
            this.Hauteur = hauteur;
        }

        public float CapacitéDeCharge
        {
            get
            {
                return capacitéDeCharge;
            }

            set
            {
                capacitéDeCharge = value;
            }
        }

        public int Hauteur
        {
            get
            {
                return hauteur;
            }

            set
            {
                hauteur = value;
            }
        }
    }
}
