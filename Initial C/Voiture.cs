using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Initial_C
{
    class Voiture : Véhicule
    {
        private int nbPlaces;

        public Voiture(int id, string etat, string constructeur, string modèle, int km, int nbPlaces) : base(id, etat, constructeur, modèle, km)
        {           
            this.NbPlaces = nbPlaces;
        }

        public int NbPlaces
        {
            get
            {
                return nbPlaces;
            }

            set
            {
                nbPlaces = value;
            }
        }
    }
}
