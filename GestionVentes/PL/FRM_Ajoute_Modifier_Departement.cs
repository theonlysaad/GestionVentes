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

namespace GestionVentes.PL
{
    public partial class FRM_Ajoute_Modifier_Departement : Form
    {
        private dbVenteContext db;
        private UserControl userDep;
        public FRM_Ajoute_Modifier_Departement(UserControl user)
        {
            InitializeComponent();
            db = new dbVenteContext();
            this.userDep = user;
        }

        string testobligatoire()
        {
            if (textNomDep.Text == "" || textNomDep.Text == "Nom Département")
            {
                return "Entrer le Nom Département";
            }

            return null;

        }
        private void btnquitter_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void textNomDep_Enter(object sender, EventArgs e)
        {
            if (textNomDep.Text == "Nom Département")
            {
                textNomDep.Text = "";
                textNomDep.ForeColor = Color.WhiteSmoke; // Changer couleur de texte
            }
        }

        private void btnactualiser_Click(object sender, EventArgs e)
        {
            //Vider le formulaire
            textNomDep.Text = "Nom Département"; textNomDep.ForeColor = Color.White;
        }


        public int IdDep;
        private void btnenregistrer_Click(object sender, EventArgs e)
        {
            if (testobligatoire() != null)
            {
                MessageBox.Show(testobligatoire(), "Obligatoire", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {

                if (lblDep.Text == "Ajouter Département")
                {
                    BL.CLS_Departement clcat = new BL.CLS_Departement();
                    

                    if (clcat.AjouterDepartement(textNomDep.Text) == true)
                    {
                        MessageBox.Show("Département ajouté avec succés", "Ajouter", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                        (userDep as USER_LISTE_Departement).Actualiserdvg();
                    }
                    else
                    {
                        MessageBox.Show("Catégorie déjà existante ", "Ajouter", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    }

                }
                else //Modification
                {
                    BL.CLS_Departement dep = new BL.CLS_Departement();
                    DialogResult rs = MessageBox.Show("Voulez-vous vraiment modifier ce département", "Moidifcation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (rs == DialogResult.Yes)
                    {
                        dep.ModifierDepartement(IdDep, textNomDep.Text);
                        MessageBox.Show("Catégorie modifiée avec succés", "Modification", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                        //Actualiser datagrid
                        (userDep as USER_LISTE_Departement).Actualiserdvg();
                        Close();//Pour quitter formulaire
                    }
                    else
                    {
                        MessageBox.Show("Modification annulée", "Modification", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                    }

                }
            }
        }

       

        private void FRM_Ajoute_Modifier_Departement_Load(object sender, EventArgs e)
        {

        }
    }
}
