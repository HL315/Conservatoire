using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;
using ConservatoireChatgpt.Controleur;

namespace ConservatoireChatgpt.Vue
{
    public partial class LoginForm : Form
    {
        private LoginController loginController;

        public void CloseLoginForm()
        {
            // Ferme le formulaire LoginForm
            this.Close();
        }

        public LoginForm()
        {
            InitializeComponent();
            loginController = new LoginController();
        }

        private void boutonLogin_Click(object sender, EventArgs e)
        {
            string login = txtLogin.Text;
            string mdp = txtMdp.Text;

            bool isAuthenticated = loginController.VerifyLogin(login, mdp);

            if (isAuthenticated)
            {
                MessageBox.Show("Connexion réussie !");
                MainPageForm mainForm = new MainPageForm();
                mainForm.ShowDialog(); // Utilise la méthode ShowMainPage() pour afficher le formulaire MainPageForm
                CloseLoginForm(); // Utilise la méthode CloseLoginForm() pour fermer le formulaire LoginForm
            }
            else
            {
                // Code pour gérer le cas d'échec de connexion
                MessageBox.Show("Identifiant ou mot de passe incorrect !");
            }
        }
    }
}