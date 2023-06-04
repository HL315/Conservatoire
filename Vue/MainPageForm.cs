using ConservatoireChatgpt.Modele;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ConservatoireChatgpt.Controleur;

namespace ConservatoireChatgpt.Vue
{
    public partial class MainPageForm : Form
    {
        private MainPageController mainPageController;

        public MainPageForm()
        {
            InitializeComponent();
            mainPageController = new MainPageController();
        }

        private void MainPageForm_Load(object sender, EventArgs e)
        {
            // Remplir les combobox avec les noms des professeurs et des élèves
            List<string> nomsProfesseurs = mainPageController.GetNomsProfesseurs();
            List<string> nomsEleves = mainPageController.GetNomsEleves();

            comboBoxProfesseur.DataSource = nomsProfesseurs;
            comboBoxEleve.DataSource = nomsEleves;
        }

        private void btnEnregistrer_Click(object sender, EventArgs e)
        {
            if (comboBoxProfesseur.SelectedItem != null)

            {
                // Récupérer les valeurs sélectionnées et les entrées utilisateur
                string nomProfesseur = comboBoxProfesseur.SelectedItem.ToString();
                string nomEleve = comboBoxEleve.SelectedItem.ToString();
                decimal somme = decimal.Parse(txtMontant.Text);
                string libelle = txtLibelle.Text;

                // Obtenir les identifiants des professeurs et des élèves à partir des noms
                int professeurID = mainPageController.ObtenirProfesseurID(nomProfesseur);
                int eleveID = mainPageController.ObtenirEleveID(nomEleve);

                // Ajouter la transaction
                mainPageController.AjouterTransaction(professeurID, eleveID, somme, libelle);

                // Afficher un message de réussite
                MessageBox.Show("Transaction ajoutée avec succès !");
            }

            else

            {
                // Aucun élément sélectionné dans la combobox Professeur
                MessageBox.Show("Veuillez sélectionner un professeur !");
            }
        }
    }
}
