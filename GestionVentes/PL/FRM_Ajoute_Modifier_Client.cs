using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net.Mail;
namespace GestionVentes.PL
{
    public partial class FRM_Ajoute_Modifier_Client : Form
    {
        private UserControl useCtrl;
        public FRM_Ajoute_Modifier_Client(UserControl useCtrl)
        {
            InitializeComponent();
            this.useCtrl = useCtrl;
        }

        private void FRM_Ajoute_Modifier_Client_Load(object sender, EventArgs e)
        {

        }

        // Les champs obligatoires
        string testobligatoire()
        {
            if (textNom.Text == "" || textNom.Text == "Nom de Client")
            {
                return "Entrer le Nom de Client";
            }

            if (textPrenom.Text == "" || textPrenom.Text == "Prenom Client")
            {
                return "Entrer le Prenom de Client";
            }

            if (textEmail.Text == "" || textEmail.Text == "Email Client")
            {
                return "Entrer l'Email de Client";
            }

            if (textAdresse.Text == "" || textAdresse.Text == "Adresse Client")
            {
                return "Entrer l'Adresse de Client";
            }

            if (textTel.Text == "" || textTel.Text == "Telephone Client")
            {
                return "Entrer le Telephone de Client";
            }

            if (textVille.Text == "" || textVille.Text == "Ville Client")
            {
                return "Entrer la Ville du Client";
            }

            if (textPays.Text == "" || textPays.Text == "Pays Client")
            {
                return "Entrer le Pays de Client";
            }

            //Verifier si l'email est valide
            if (textEmail.Text!= "" || textEmail.Text!= "Email Client")
            {
                try
                {
                    new MailAddress(textEmail.Text); //Pour verifier si l'email est valide ou non
                }
                catch (Exception e)
                {
                    return "Email Invalide";
                }
            }

            return null;
        }

        private void btnquitter_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void lblTitre_Click(object sender, EventArgs e)
        {

        }

        private void textNom_Enter(object sender, EventArgs e)
        {
            //Pour vider le textbox
            if (textNom.Text == "Nom de Client")
            {
                textNom.Text = "";
                textNom.ForeColor = Color.WhiteSmoke; // Changer couleur de texte
            }
        }

        private void textPrenom_Enter(object sender, EventArgs e)
        {

            //Pour vider le textbox
            if (textPrenom.Text == "Prenom Client")
            {
                textPrenom.Text = "";
                textPrenom.ForeColor = Color.WhiteSmoke; // Changer couleur de texte
            }
        }

        private void textAdresse_Enter(object sender, EventArgs e)
        {
            //Pour vider le textbox
            if (textAdresse.Text == "Adresse Client")
            {
                textAdresse.Text = "";
                textAdresse.ForeColor = Color.WhiteSmoke; // Changer couleur de texte
            }
        }

        private void textEmail_Enter(object sender, EventArgs e)
        {
            //Pour vider le textbox
            if (textEmail.Text == "Email Client")
            {
                textEmail.Text = "";
                textEmail.ForeColor = Color.WhiteSmoke; // Changer couleur de texte
            }
        }

        private void textTel_Enter(object sender, EventArgs e)
        {
            //Pour vider le textbox
            if (textTel.Text == "Telephone Client")
            {
                textTel.Text = "";
                textTel.ForeColor = Color.WhiteSmoke; // Changer couleur de texte
            }
        }

        private void textVille_Enter(object sender, EventArgs e)
        {
            //Pour vider le textbox
            if (textVille.Text == "Ville Client")
            {
                textVille.Text = "";
                textVille.ForeColor = Color.WhiteSmoke; // Changer couleur de texte
            }
        }

        private void textPays_Enter(object sender, EventArgs e)
        {
            //Pour vider le textbox
            if (textPays.Text == "Pays Client")
            {
                textPays.Text = "";
                textPays.ForeColor = Color.WhiteSmoke; // Changer couleur de texte
            }
        }

        private void textTel_TextChanged(object sender, KeyPressEventArgs e)
        {

        }

        private void textTel_TextChanged(object sender, EventArgs e)
        {

        }

        private void textTel_KeyPress(object sender, KeyPressEventArgs e)
        {
            //Textbox nuumeric

            if (e.KeyChar < 48 || e.KeyChar > 57) //Code asci des num
            {
                e.Handled = true;
            }
            if (e.KeyChar == 8)
            {
                e.Handled = false;
            }
        }

        private void btnenregistrer_Click(object sender, EventArgs e)
        {
            if (testobligatoire() != null)
            {
                MessageBox.Show(testobligatoire(), "Obligatoire", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            if(lblTitre.Text=="Ajouter Client")
            {
                BL.CLS_Client client = new BL.CLS_Client();
                
                if (client.AjouterClient(textNom.Text, textPrenom.Text, textAdresse.Text, textTel.Text, textEmail.Text, textPays.Text, textVille.Text) == true)
                { 
                    MessageBox.Show("Client ajouté avec succés", "Ajouter", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                    (useCtrl as USER_Liste_Client).Actualiserdatagrid();
                } else
                {
                MessageBox.Show("Nom et prénom de client déjà existant ", "Ajouter", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
            } else // Si on veut modifier
            {
                BL.CLS_Client clsclient = new BL.CLS_Client();
                USER_Liste_Client ulc = new USER_Liste_Client();
                DialogResult R = MessageBox.Show("Vous etes sures de modifier le client !","Modification",MessageBoxButtons.YesNo,MessageBoxIcon.Question);
                if (R==DialogResult.Yes)
                {
                    clsclient.ModifierClient(ulc.IDselect, textNom.Text, textPrenom.Text, textAdresse.Text, textTel.Text, textEmail.Text, textPays.Text, textVille.Text);

                    //Pour actualiser datagrid
                    (ulc as USER_Liste_Client).Actualiserdatagrid();
                    MessageBox.Show("Client a été modifié avec succés","Modification",MessageBoxButtons.OK,MessageBoxIcon.Question);
                }else
                {
                    MessageBox.Show("Modification a échoué", "Modification", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                }


            }
        }

        private void textNom_Leave(object sender, EventArgs e)
        {
            if (textNom.Text == "")
            {
                textNom.Text = "Nom de Client";
                textNom.ForeColor = Color.White; // Changer couleur de texte
            }
        }

        private void textPrenom_Leave(object sender, EventArgs e)
        {
            if (textPrenom.Text == "")
            {
                textPrenom.Text = "Prenom Client";
                textPrenom.ForeColor = Color.White; // Changer couleur de texte
            }
        }

        private void textEmail_Leave(object sender, EventArgs e)
        {
            if (textEmail.Text == "")
            {
                textEmail.Text = "Email Client";
                textEmail.ForeColor = Color.White; // Changer couleur de texte
            }
        }

        private void textAdresse_Leave(object sender, EventArgs e)
        {
            if (textAdresse.Text == "")
            {
                textAdresse.Text = "Adresse Client";
                textAdresse.ForeColor = Color.White; // Changer couleur de texte
            }
        }

        private void textTel_Leave(object sender, EventArgs e)
        {
            if (textTel.Text == "")
            {
                textTel.Text = "Telephone Client";
                textTel.ForeColor = Color.White; // Changer couleur de texte
            }
        }

        private void textPays_Leave(object sender, EventArgs e)
        {
            if (textPays.Text == "")
            {
                textPays.Text = "Pays Client";
                textPays.ForeColor = Color.White; // Changer couleur de texte
            }
        }

        private void textVille_Leave(object sender, EventArgs e)
        {
            if (textVille.Text == "")
            {
                textVille.Text = "Ville Client";
                textVille.ForeColor = Color.White; // Changer couleur de texte
            }
        }

        private void btnactualiser_Click(object sender, EventArgs e)
        {
            //Vider les textbox

            textNom.Text = "Nom de Client"; textNom.ForeColor = Color.White;
            textPrenom.Text = "Prenom Client"; textPrenom.ForeColor = Color.White;
            textEmail.Text = "Email Client"; textEmail.ForeColor = Color.White;
            textAdresse.Text = "Adresse Client"; textAdresse.ForeColor = Color.White;
            textPays.Text = "Pays Client"; textPays.ForeColor = Color.White;
            textVille.Text = "Ville Client"; textVille.ForeColor = Color.White;
            textTel.Text = "Telephone Client"; textTel.ForeColor = Color.White;


        }

        private void textNom_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
