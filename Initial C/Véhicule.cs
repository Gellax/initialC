using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Initial_C
{
    public abstract class Véhicule
    {
        protected int id;
        protected string etat;
        protected string constructeur;
        protected string modèle;
        private int km;

        protected int Id
        {
            get
            {
                return id;
            }

            set
            {
                id = value;
            }
        }

        protected string Etat
        {
            get
            {
                return etat;
            }

            set
            {
                etat = value;
            }
        }

        public string Constructeur
        {
            get
            {
                return constructeur;
            }

            set
            {
                constructeur = value;
            }
        }

        public string Modèle
        {
            get
            {
                return modèle;
            }

            set
            {
                modèle = value;
            }
        }

        protected int Km
        {
            get
            {
                return km;
            }

            set
            {
                km = value;
            }
        }

        public Véhicule(int id, string etat, string constructeur, string modèle, int km)
        {
            this.Id = id;
            this.Etat = etat;
            this.Constructeur = constructeur;
            this.Modèle = modèle;
            this.Km = km;
        }

    }
}
