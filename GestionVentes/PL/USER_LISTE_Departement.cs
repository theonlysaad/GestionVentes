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
    public partial class USER_LISTE_Departement : UserControl
    {

        private static USER_LISTE_Departement Userdep;
        private dbVenteContext db;

        public static USER_LISTE_Departement Instance
        {
            get
            {
                if (Userdep == null)
                {
                    Userdep = new USER_LISTE_Departement();
                }
                return Userdep;
            }
        }
        public USER_LISTE_Departement()
        {
            InitializeComponent();
            db = new dbVenteContext();
        }

        public void Actualiserdvg()
        {
            db = new dbVenteContext();
            dvgdep.Rows.Clear(); //vider datagrid view
            foreach (var List in db.departements)
            {
                    dvgdep.Rows.Add(false, List.numDepartement, List.nomDepartement);
            }
        }

        public String SelectVerif()
        {
            int NmbreLigneSelect = 0;
            for (int i = 0; i < dvgdep.Rows.Count; i++)
            {
                if ((bool)dvgdep.Rows[i].Cells[0].Value == true) //Si la ligne est séléctionnée
                {
                    NmbreLigneSelect++;
                }
            }
            if (NmbreLigneSelect == 0)
            {
                return "Selectionner le Département ";
            }
            else if (NmbreLigneSelect > 1)
            {
                return "Selectionner une seule ligne pour modifier";
            }
            return null;
        }

        private void USER_LISTE_Departement_Load(object sender, EventArgs e)
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
            PL.FRM_Ajoute_Modifier_Departement frmd = new PL.FRM_Ajoute_Modifier_Departement(this);
            frmd.ShowDialog();
        }

        private void btnmodifiercat_Click(object sender, EventArgs e)
        {
            departement dt = new departement();
            if (SelectVerif() != null)
            {
                MessageBox.Show(SelectVerif(), "Modification", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                PL.FRM_Ajoute_Modifier_Departement frmd = new PL.FRM_Ajoute_Modifier_Departement(this);
                frmd.lblDep.Text = "Modifier Département";
                frmd.btnactualiser.Visible = false;
                for (int i = 0; i < dvgdep.Rows.Count; i++) //Verifie ligne séléctionné
                {
                    if ((bool)dvgdep.Rows[i].Cells[0].Value == true)//si ligne selectionné
                    {
                        int myidselect = (int)dvgdep.Rows[i].Cells[1].Value;
                        dt = db.departements.SingleOrDefault(s => s.numDepartement == myidselect);
                        if (dt != null) //si existe
                        {
                            frmd.textNomDep.Text = dvgdep.Rows[i].Cells[2].Value.ToString();
                            frmd.IdDep = (int)dvgdep.Rows[i].Cells[1].Value;
                        }
                    }
                }
                frmd.ShowDialog();
            }
        }
    }
}
