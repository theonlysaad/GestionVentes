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
    public partial class USER_Liste_Client : UserControl
    {
        private static USER_Liste_Client Userclient;
        private dbVenteContext db;

        //Creer une instance pour le usercontrole
        public static USER_Liste_Client Instance
        {
            get
            {
                if(Userclient == null)
                {
                    Userclient = new USER_Liste_Client();
                }
                return Userclient;
            }
        }
        public USER_Liste_Client()
        {
            InitializeComponent();
            db = new dbVenteContext();
            //Désactiver textbox de recherche
            textrecherche.Enabled = false;
        }

        public void Actualiserdatagrid()
        {
            db = new dbVenteContext();
            dvgclient.Rows.Clear(); //vider datagrid view
            foreach(var S in db.clients)
            {
                //Ajouter les lignes dans datagrid
                dvgclient.Rows.Add(false,S.numClient,S.nomClient,S.prenomClient,S.adresseClient,S.villeClient,S.paysClient,S.teleClient,S.emailClient);
            }
        }

        // Verifier combien de ligne est séléctionnée
        public String SelectVerif()
        {
            int NmbreLigneSelect = 0;
            for(int i = 0; i < dvgclient.Rows.Count; i++)
            {
                if ((bool)dvgclient.Rows[i].Cells[0].Value == true) //Si la ligne est séléctionnée
                {
                    NmbreLigneSelect++;
                }
            }
            if(NmbreLigneSelect == 0)
            {
                return "Selectionner le Client que vous voullez modifier";
            }
            else if (NmbreLigneSelect > 1)
            {
                return "Selectionner une seule ligne pour modifier";
            }
            return null;
        }
        private void btnsupprimerclient_Click(object sender, EventArgs e)
        {
            BL.CLS_Client cclient = new BL.CLS_Client();
            // Supprimer tout les clients séléctionnés
            int select = 0;
            for(int i=0; i < dvgclient.Rows.Count; i++)
            {
                if ((bool)dvgclient.Rows[i].Cells[0].Value == true)
                {
                    select++; //Combien de lignes séléctionnés
                }
            }

            if (select == 0)
            {
                MessageBox.Show("Aucun client séléctionné", "Suppression",MessageBoxButtons.OK,MessageBoxIcon.Error);
            } else
            {
                DialogResult r =
                    MessageBox.Show("Voulez-vous vraiment supprimer", "Suppression", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if(r == DialogResult.Yes)
                {
                    //Pour supprimer tout les clients séléctionnés
                    for (int i = 0; i < dvgclient.Rows.Count; i++)
                    {
                        if ((bool)dvgclient.Rows[i].Cells[0].Value == true)
                        {
                            cclient.SupprimerClient(int.Parse(dvgclient.Rows[i].Cells[1].Value.ToString()));
                        }
                    }
                    //Actualiser datagrid
                    Actualiserdatagrid();
                    MessageBox.Show("Suppression avec succés","Suppression",MessageBoxButtons.OK,MessageBoxIcon.Asterisk);
                } else
                {
                    MessageBox.Show("Suppression est annullée", "Suppression", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                }
            }

        }

        private void textBox1_Enter(object sender, EventArgs e)
        {
            if(textrecherche.Text == "Rechercher")
            {
                textrecherche.Text ="";
                textrecherche.ForeColor = Color.Black;
            }
        }

        private void USER_Liste_Client_Load(object sender, EventArgs e)
        {
            Actualiserdatagrid();
        }

        private void dvgclient_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Activer le textbox rechercher si j'ai choisi un champ
            textrecherche.Enabled = true;
            textrecherche.Text = ""; //Vider le textbox de recherche
        }

        private void btnajouterclient_Click(object sender, EventArgs e)
        {
            //Afficher formulaire de saisie 
            PL.FRM_Ajoute_Modifier_Client frmc = new FRM_Ajoute_Modifier_Client(this);
            frmc.ShowDialog();
        }

        private void textrecherche_TextChanged(object sender, EventArgs e)
        {
            db = new dbVenteContext();
            var listerecherche = db.clients.ToList(); // listerecherche = lister les clients
            if(textrecherche.Text != "") //Pas vide
            {
                switch (comborechercher.Text)
                {
                    case "Nom":
                        listerecherche = listerecherche.Where(s => s.nomClient.IndexOf(textrecherche.Text, StringComparison.CurrentCultureIgnoreCase) != -1).ToList();
                        // != -1 existe dans la base de données
                        break;
                    case "Prenom":
                        listerecherche = listerecherche.Where(s => s.prenomClient.IndexOf(textrecherche.Text, StringComparison.CurrentCultureIgnoreCase) != -1).ToList();
                        // != -1 existe dans la base de données
                        break;
                    case "Adresse":
                        listerecherche = listerecherche.Where(s => s.adresseClient.IndexOf(textrecherche.Text, StringComparison.CurrentCultureIgnoreCase) != -1).ToList();
                        // != -1 existe dans la base de données
                        break;
                    case "Ville":
                        listerecherche = listerecherche.Where(s => s.villeClient.IndexOf(textrecherche.Text, StringComparison.CurrentCultureIgnoreCase) != -1).ToList();
                        // != -1 existe dans la base de données
                        break;
                    case "Pays":
                        listerecherche = listerecherche.Where(s => s.paysClient.IndexOf(textrecherche.Text, StringComparison.CurrentCultureIgnoreCase) != -1).ToList();
                        // != -1 existe dans la base de données
                        break;
                    case "Telephone":
                        listerecherche = listerecherche.Where(s => s.teleClient.IndexOf(textrecherche.Text, StringComparison.CurrentCultureIgnoreCase) != -1).ToList();
                        // != -1 existe dans la base de données
                        break;
                    case "Email":
                        listerecherche = listerecherche.Where(s => s.emailClient.IndexOf(textrecherche.Text, StringComparison.CurrentCultureIgnoreCase) != -1).ToList();
                        // != -1 existe dans la base de données
                        break;
                }

            }

            //Vider datagrid
            dvgclient.Rows.Clear();
            //Ajouter listerecherche dans datagridview client
            foreach (var l in listerecherche)
            {
                dvgclient.Rows.Add(false,l.numClient,l.nomClient,l.prenomClient,l.adresseClient,l.villeClient,l.paysClient,l.teleClient,l.emailClient);
            }


        }

        public int IDselect;
        private void btnmodifierclient_Click(object sender, EventArgs e)
        {
            PL.FRM_Ajoute_Modifier_Client frmclient = new PL.FRM_Ajoute_Modifier_Client(this);
            if (SelectVerif() == null)
            {
                for (int i = 0; i < dvgclient.Rows.Count; i++)
                {
                    if ((bool)dvgclient.Rows[i].Cells[0].Value == true)
                    {
                        IDselect = (int)dvgclient.Rows[i].Cells[1].Value;
                        frmclient.textNom.Text = dvgclient.Rows[i].Cells[2].Value.ToString();
                        frmclient.textPrenom.Text = dvgclient.Rows[i].Cells[3].Value.ToString();
                        frmclient.textAdresse.Text = dvgclient.Rows[i].Cells[4].Value.ToString();
                        frmclient.textVille.Text = dvgclient.Rows[i].Cells[5].Value.ToString();
                        frmclient.textPays.Text = dvgclient.Rows[i].Cells[6].Value.ToString();
                        frmclient.textTel.Text = dvgclient.Rows[i].Cells[7].Value.ToString();
                        frmclient.textEmail.Text = dvgclient.Rows[i].Cells[8].Value.ToString();
                    }
                }


                PL.FRM_Ajoute_Modifier_Client frmc = new FRM_Ajoute_Modifier_Client(this);
                frmc.lblTitre.Text = "Modifier Client";
                frmc.btnactualiser.Visible = false;
                frmc.ShowDialog();
            }
            else
            {
                MessageBox.Show(SelectVerif(), "Modification", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


        }

        private void textrecherche_Leave(object sender, EventArgs e)
        {

        }
    }
}
