using GestionVentes.BL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GestionVentes.PL
{
    public partial class FRM_Connexion : Form
    {

        private dbVenteContext db;
        private Form frmmenu;
        // Classe connexion
        BL.CLS_Connexion C = new BL.CLS_Connexion();
        public FRM_Connexion(Form frmmenu)
        {
            InitializeComponent();
            this.frmmenu = frmmenu;
            //Initisialiser  base de données
            db = new dbVenteContext();
        }

        //Pour tester les champs obligatoires
        String testobligatoire()
        {
            if(textNom.Text =="" || textNom.Text == "Nom d'utilisateur")//si le nom d'utilisateur ou le textbox est "Nom d'utilisateur"
            {
                return "Entrer votre Nom";
            }
            if (textMdp.Text == "" || textMdp.Text == "Mot de Passe")//si le mot de passe ou le textbox est "Mot de Passe"
            {
                return "Entrer votre mot de passe";
            }
            //Si l'utilisateur a entré le nom d'utilisateur et le mot de passe
            return null;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void FRM_Connexion_Load(object sender, EventArgs e)
        {

        }

        private void btnquitter_Click(object sender, EventArgs e)
        {
            //Quitter le formulaire
            this.Close();
        }

        private void textNom_Enter(object sender, EventArgs e)
        {
            //Pour vider le textbox
            if(textNom.Text == "Nom d'utilisateur")
            {
                textNom.Text = "";
                textNom.ForeColor = Color.WhiteSmoke; // Changer couleur de texte
            }
        }

        private void textMdp_Enter(object sender, EventArgs e)
        {
            //Pour vider le textbox
            if (textMdp.Text == "Mot de Passe")
            {
                textMdp.Text = "";
                textMdp.UseSystemPasswordChar = false;
                textMdp.PasswordChar = '*';
                textMdp.ForeColor = Color.WhiteSmoke; // Changer couleur de texte
            }
        }

        private void textNom_Leave(object sender, EventArgs e)
        {

            if (textNom.Text == "") { 
            textNom.Text = "Nom d'utilisateur";
            textNom.ForeColor = Color.Silver; // Changer couleur de texte
        }
        }

        private void textMdp_Leave(object sender, EventArgs e)
        {
            if (textMdp.Text == "")
            {
                textMdp.Text = "Mot de Passe";
                textMdp.UseSystemPasswordChar = true; // Desactiver passwordchar
                textMdp.ForeColor = Color.Silver; // Changer couleur de texte
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(testobligatoire() == null)
            {
                if (C.ConnexionValide(db,textNom.Text,textMdp.Text) == true) // Utilisateur existe
                {
                    MessageBox.Show("Connexion a reussi","Connexion",MessageBoxButtons.OK,MessageBoxIcon.Asterisk);
                    (frmmenu as FRM_MENU).activerForm();
                    this.Close(); //Quitter le formulaire connexion
                }
                else
                {
                    MessageBox.Show("Connexion a échoué", "Connexion", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
            } else
            {
                MessageBox.Show(testobligatoire(), "obligatoire", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
