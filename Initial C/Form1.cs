using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Initial_C
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        //Les différentes listes de véhicules en variables globales
        List<Voiture> voitures;
        List<Camion> camions;
        List<Bateau> bateaux;

        //Load de l'application - généré automatiquement par l'IDE
        private void Form1_Load(object sender, EventArgs e)
        {
            //Mise en place du jeu d'essai
            voitures = JeuDEssai.initializeVoiture();
            camions = JeuDEssai.initializeCamion();
            bateaux = JeuDEssai.initializeBateau();
        }

        //Event listener - S'active quand l'index sélectionné dans la Combobox change
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
          
            switch (cbCatégorie.Text)
            {
                case "Voiture": dgvVehicule.DataSource = voitures;
                    break;
                case "Camion": dgvVehicule.DataSource = camions;
                    break;
                case "Bateau": dgvVehicule.DataSource = bateaux;
                    break;
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if(!dgvVehicule.SelectedRows.Equals(null))
            {
                switch(cbCatégorie.Text)
                {
                    case "Voiture":
                        voitures.RemoveAt(dgvVehicule.CurrentRow.Index);
                        dgvVehicule.DataSource = null;
                        dgvVehicule.DataSource = voitures;
                        break;
                    case "Camion":
                        camions.RemoveAt(dgvVehicule.CurrentRow.Index);
                        dgvVehicule.DataSource = null;
                        dgvVehicule.DataSource = camions;
                        break;
                    case "Bateau":
                        bateaux.RemoveAt(dgvVehicule.CurrentRow.Index);
                        dgvVehicule.DataSource = null;
                        dgvVehicule.DataSource = bateaux;
                        break;
                }
            }

            else
            {
                MessageBox.Show("Veuillez Selectionner une ligne à effacer");
            }
        }
    }
}
