using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace GestionVentes.PL
{
    public partial class FRM_Ajoute_Modifier_Categorie : Form
    {
        private dbVenteContext db;
        private UserControl userCat;
        public FRM_Ajoute_Modifier_Categorie(UserControl user)
        {
            InitializeComponent();
            db = new dbVenteContext();
            this.userCat = user;
            //Afficher les categories dans comboxcategorie
            comboDep.DataSource = db.departements.ToList();
            //Pour filtrer seulement les noms des categories
            comboDep.DisplayMember = "nomDepartement"; //Afficher seulement les noms des categories
            comboDep.ValueMember = "numDepartement";
            this.userCat = user;
        }

        string testobligatoire()
        {
            if (textNomCat.Text == "" || textNomCat.Text == "Nom Catégorie")
            {
                return "Entrer le Nom Catégorie";
            }

            if (comboDep.Text == "")
            {
                return "Entrer Département";
            }

            return null;

        }
        private void btnquitter_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void FRM_Ajoute_Modifier_Categorie_Load(object sender, EventArgs e)
        {

        }

        private void textNomCat_Enter(object sender, EventArgs e)
        {
            if (textNomCat.Text == "Nom Catégorie")
            {
                textNomCat.Text = "";
                textNomCat.ForeColor = Color.WhiteSmoke; // Changer couleur de texte
            }
        }

        private void btnactualiser_Click(object sender, EventArgs e)
        {
            //Vider le formulaire
            textNomCat.Text = "Nom Catégorie"; textNomCat.ForeColor = Color.White;       
            comboDep.Text = "";
        }

        public int IdCat;
        private void btnenregistrer_Click(object sender, EventArgs e)
        {
            if (testobligatoire() != null)
            {
                MessageBox.Show(testobligatoire(), "Obligatoire", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {

                if (lblCat.Text == "Ajouter Catégorie")
                {
                    BL.CLS_Categorie clcat = new BL.CLS_Categorie();
                   

                    if (clcat.AjouterCategorie(textNomCat.Text,Convert.ToInt32(comboDep.SelectedValue)) == true)
                    {
                        MessageBox.Show("Catégorie ajouté avec succés", "Ajouter", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                        (userCat as USER_LISTE_Catégorie).Actualiserdvg();
                    }
                    else
                    {
                        MessageBox.Show("Catégorie déjà existante ", "Ajouter", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    }

                }
                else //Modification
                {
                    BL.CLS_Categorie cat = new BL.CLS_Categorie();
                    DialogResult rs = MessageBox.Show("Voulez-vous vraiment modifier cette catégorie", "Moidifcation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (rs == DialogResult.Yes)
                    {
                        cat.ModifierCategorie(IdCat, textNomCat.Text, Convert.ToInt32(comboDep.SelectedValue));
                        MessageBox.Show("Catégorie modifiée avec succés", "Modification", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                        //Actualiser datagrid
                        (userCat as USER_LISTE_Catégorie).Actualiserdvg();
                        Close();//Pour quitter formulaire
                    }
                    else
                    {
                        MessageBox.Show("Modification annulée", "Modification", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                    }

                }
            }
        }

        private void comboDep_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
