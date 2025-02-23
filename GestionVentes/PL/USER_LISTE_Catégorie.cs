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
    public partial class USER_LISTE_Catégorie : UserControl
    {
        private static USER_LISTE_Catégorie Usercat;
        private dbVenteContext db;

        public static USER_LISTE_Catégorie Instance
        {
            get
            {
                if (Usercat == null)
                {
                    Usercat = new USER_LISTE_Catégorie();
                }
                return Usercat;
            }
        }
        public USER_LISTE_Catégorie()
        {
            InitializeComponent();
            db = new dbVenteContext();

        }

        public void Actualiserdvg()
        {
            db = new dbVenteContext();
            dvgcat.Rows.Clear(); //vider datagrid view
            departement dep = new departement();
            foreach (var List in db.categories)
            {
                dep = db.departements.SingleOrDefault(s => s.numDepartement == List.numDepartement);
                if (dep != null)// si existe
                {
                    dvgcat.Rows.Add(false, List.numCategorie, List.nomCategorie,dep.nomDepartement);

                }
            }
        }

        public String SelectVerif()
        {
            int NmbreLigneSelect = 0;
            for (int i = 0; i < dvgcat.Rows.Count; i++)
            {
                if ((bool)dvgcat.Rows[i].Cells[0].Value == true) //Si la ligne est séléctionnée
                {
                    NmbreLigneSelect++;
                }
            }
            if (NmbreLigneSelect == 0)
            {
                return "Selectionner la Catégorie ";
            }
            else if (NmbreLigneSelect > 1)
            {
                return "Selectionner une seule ligne pour modifier";
            }
            return null;
        }



        private void USER_LISTE_Catégorie_Load(object sender, EventArgs e)
        {
            Actualiserdvg();

        }

        private void textrecherche_Enter(object sender, EventArgs e)
        {
            if (textrecherche.Text == "Rechercher")
            {
                textrecherche.Text = "";
                textrecherche.ForeColor = Color.Black;
            }
        }

        private void btnajouterCat_Click(object sender, EventArgs e)
        {
            //Afficher formulaire de saisie 
            PL.FRM_Ajoute_Modifier_Categorie frmp = new PL.FRM_Ajoute_Modifier_Categorie(this);
            frmp.ShowDialog();
        }

        private void btnmodifiercat_Click(object sender, EventArgs e)
        {
            categorie ct = new categorie();
            if (SelectVerif() != null)
            {
                MessageBox.Show(SelectVerif(), "Modification", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                PL.FRM_Ajoute_Modifier_Categorie frmp = new PL.FRM_Ajoute_Modifier_Categorie(this);
                frmp.lblCat.Text = "Modifier Catégorie";
                frmp.btnactualiser.Visible = false;
                for (int i = 0; i < dvgcat.Rows.Count; i++) //Verifie ligne séléctionné
                {
                    if ((bool)dvgcat.Rows[i].Cells[0].Value == true)//si ligne selectionné
                    {
                        int myidselect = (int)dvgcat.Rows[i].Cells[1].Value;
                        ct = db.categories.SingleOrDefault(s => s.numCategorie == myidselect);
                        if (ct != null) //si existe
                        {
                            frmp.comboDep.Text = dvgcat.Rows[i].Cells[3].Value.ToString();
                            frmp.textNomCat.Text = dvgcat.Rows[i].Cells[2].Value.ToString();
                            frmp.IdCat = (int)dvgcat.Rows[i].Cells[1].Value;
                        }
                    }
                }
                frmp.ShowDialog();
            }
        }

        private void btnsupprimercat_Click(object sender, EventArgs e)
        {
            BL.CLS_Categorie catt = new BL.CLS_Categorie();
            // Supprimer tout les clients séléctionnés
            int select = 0;
            for (int i = 0; i < dvgcat.Rows.Count; i++)
            {
                if ((bool)dvgcat.Rows[i].Cells[0].Value == true)
                {
                    select++; //Combien de lignes séléctionnés
                }
            }

            if (select == 0)
            {
                MessageBox.Show("Aucun client séléctionné", "Suppression", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                DialogResult r =
                    MessageBox.Show("Voulez-vous vraiment supprimer", "Suppression", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (r == DialogResult.Yes)
                {
                    //Pour supprimer tout les clients séléctionnés
                    for (int i = 0; i < dvgcat.Rows.Count; i++)
                    {
                        if ((bool)dvgcat.Rows[i].Cells[0].Value == true)
                        {
                            catt.SupprimerCategorie(int.Parse(dvgcat.Rows[i].Cells[1].Value.ToString()));
                        }
                    }
                    //Actualiser datagrid
                    Actualiserdvg();
                    MessageBox.Show("Suppression avec succés", "Suppression", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                }
                else
                {
                    MessageBox.Show("Suppression est annullée", "Suppression", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                }
            }
        }

        private void textrecherche_TextChanged(object sender, EventArgs e)
        {
            db = new dbVenteContext();
            var listerecherche = db.categories.ToList(); // listerecherche = lister les produits
            if (textrecherche.Text != "") //Pas vide
            {
                listerecherche = listerecherche.Where(s => s.nomCategorie.IndexOf(textrecherche.Text, StringComparison.CurrentCultureIgnoreCase) != -1).ToList();
                // != -1 existe dans la base de données


            }
            departement dep = new departement();
            //Vider datagrid
            dvgcat.Rows.Clear();
            //Ajouter listerecherche dans datagridview client
            foreach (var l in listerecherche)
            {
                dep = db.departements.SingleOrDefault(s => s.numDepartement == l.numDepartement);
                dvgcat.Rows.Add(false, l.numCategorie, l.nomCategorie,dep.nomDepartement);
            }
        }
    }
}
