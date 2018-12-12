using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Initial_C
{
    class JeuDEssai
    {
        public static List<Voiture> initializeVoiture()
        {
            List<Voiture> fleetCar = new List<Voiture>();
            fleetCar.Add(new Voiture(1, "en marche", "Citroen", "C4", 42, 5));
            fleetCar.Add(new Voiture(2, "en réparation", "Renault", "Clio", 33, 6));
            fleetCar.Add(new Voiture(3, "en marche", "Fiat", "Panda", 69, 4));
            return fleetCar;
        }

        public static List<Camion> initializeCamion()
        {
            List<Camion> fleetTruk = new List<Camion>();
            fleetTruk.Add(new Camion(4, "en marche", "Renault", "ork", 707, 1500, 260));
            fleetTruk.Add(new Camion(5, "en marche", "DAF", "Euro", 10001, 1600, 250));
            return fleetTruk;
        }

        public static List<Bateau> initializeBateau()
        {
            List<Bateau> fleetBoat = new List<Bateau>();
            fleetBoat.Add(new Bateau(6, "en marche", "Plouf", "Petit Bato", 89, 4.60));
            fleetBoat.Add(new Bateau(6, "en réparation", "Sunk'n'Norwegian", "Hello World!", 89, 4.60));
            return fleetBoat;
        }
            
    }
}
