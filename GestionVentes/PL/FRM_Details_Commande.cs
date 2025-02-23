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
    public partial class FRM_Details_Commande : Form
    {
        private dbVenteContext db;
        private UserControl usercontrol;

        public FRM_Details_Commande(UserControl user)
        {
            InitializeComponent();
            db = new dbVenteContext();
            usercontrol = user;
        }
        //Remplir datagrid de Commande par liste

        public void Actualise_DetailCommande()
        {
            //Calcul total ht,tva,total,ttc
            float TotalHt=0,TVA=0,Totalttc=0;
            if (textTVA.Text != "")
            {
                TVA = float.Parse(textTVA.Text);
            }
            
            dgvDetailCommande.Rows.Clear();
            foreach(var L in BL.D_Commande.listeDetail)
            {
                dgvDetailCommande.Rows.Add(L.ID,L.Nom,L.Quantité,L.Prix,L.Remise,L.Total);
                TotalHt = TotalHt + float.Parse(L.Total);
            }
            textHT.Text = TotalHt.ToString();
            //Calcul Total TTC
            Totalttc = (TotalHt + (TotalHt * TVA / 100));
            //Afficher Total TTC dans textbox ttc
            textTTC.Text = Totalttc.ToString();

        }
        // Function remplir datagrid du produit

        public void RemplirdvgProduit()
        {
            db = new dbVenteContext();
            dgvCP.Rows.Clear();
            foreach (var List in db.produits)
            {
                dgvCP.Rows.Add(List.numProduit, List.nomProduit, List.qteStock, List.prixProduit);
            }

           

            dgvCP.ClearSelection();

        }
        private void btnquitter_Click(object sender, EventArgs e)
        {
            Close();
            BL.D_Commande.listeDetail.Clear();  
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void textRechercherP_Enter(object sender, EventArgs e)
        {
            if (textRechercherP.Text == "Rechercher")
            {
                textRechercherP.Text = "";
                textRechercherP.ForeColor = Color.White;
            }
        }

        private void FRM_Details_Commande_Load(object sender, EventArgs e)
        {
            RemplirdvgProduit();
        }

        private void textRechercherP_TextChanged(object sender, EventArgs e)
        {
            db = new dbVenteContext();
            var listerecherche = db.produits.ToList(); // listerecherche = lister les produits
            if (textRechercherP.Text != "") //Pas vide
            {
                listerecherche = listerecherche.Where(s => s.nomProduit.IndexOf(textRechercherP.Text, StringComparison.CurrentCultureIgnoreCase) != -1).ToList();
                // != -1 existe dans la base de données


            }
            //Vider datagrid
            dgvCP.Rows.Clear();
            //Ajouter listerecherche dans datagridview client
            foreach (var l in listerecherche)
            {
                dgvCP.Rows.Add(l.numProduit, l.nomProduit, l.qteStock, l.prixProduit);
            }
        }

        private void btnClient_Click(object sender, EventArgs e)
        {
            PL.FRM_Client_Commande frmcc = new FRM_Client_Commande();
            frmcc.ShowDialog();

            //Afficher les infos du clients
            Idclient = (int)frmcc.dvgclientC.CurrentRow.Cells[0].Value;
            textNomC.Text = frmcc.dvgclientC.CurrentRow.Cells[1].Value.ToString();
            textPrenomC.Text = frmcc.dvgclientC.CurrentRow.Cells[2].Value.ToString();
            textVilleC.Text = frmcc.dvgclientC.CurrentRow.Cells[4].Value.ToString();
            textPaysC.Text = frmcc.dvgclientC.CurrentRow.Cells[5].Value.ToString();
            textTelC.Text = frmcc.dvgclientC.CurrentRow.Cells[6].Value.ToString();
            textEmailC.Text = frmcc.dvgclientC.CurrentRow.Cells[7].Value.ToString();


        }

        private void dgvCP_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dgvCP_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            FRM_Produit_Commande frmp = new FRM_Produit_Commande(this);
            //Si stock est vide
            if ((int)dgvCP.CurrentRow.Cells[2].Value == 0)
            {
                MessageBox.Show("Stock vide","Stock", MessageBoxButtons.OK, MessageBoxIcon.Error);
            } else
            {
                //Afficher les informations
                frmp.lblid.Text = dgvCP.CurrentRow.Cells[0].Value.ToString();
                frmp.lblnom.Text=dgvCP.CurrentRow.Cells[1].Value.ToString();
                frmp.lblstock.Text = dgvCP.CurrentRow.Cells[2].Value.ToString();
                frmp.lblprix.Text = dgvCP.CurrentRow.Cells[3].Value.ToString();
                frmp.ShowDialog();

            }
        }

        private void modifierToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FRM_Produit_Commande frmpc = new FRM_Produit_Commande(this);
            produit pr = new produit();
            if (dgvDetailCommande.CurrentRow != null)
            {
                frmpc.grpProduit.Text = "Modifier Produit";
                //Afficher information de produit à modifier
                frmpc.lblid.Text = dgvDetailCommande.CurrentRow.Cells[0].Value.ToString();
                frmpc.lblnom.Text = dgvDetailCommande.CurrentRow.Cells[1].Value.ToString();
                //Importer stock du produit
                int IDP= int.Parse(dgvDetailCommande.CurrentRow.Cells[0].Value.ToString());  
                pr = db.produits.Single(s => s.numProduit == IDP );
                frmpc.lblstock.Text=pr.qteStock.ToString();
                /////////////////////////////////
                
                frmpc.lblprix.Text= dgvDetailCommande.CurrentRow.Cells[3].Value.ToString();
                frmpc.textquantité.Text = dgvDetailCommande.CurrentRow.Cells[2].Value.ToString();
                frmpc.textremise.Text = dgvDetailCommande.CurrentRow.Cells[4].Value.ToString();
                frmpc.textTotal.Text = dgvDetailCommande.CurrentRow.Cells[5].Value.ToString();

                frmpc.ShowDialog();
            }
        }

        private void contextMenuStrip1_Opening(object sender, CancelEventArgs e)
        {

        }

        private void supprimerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (dgvDetailCommande.CurrentRow != null)
            {
                DialogResult dr = MessageBox.Show("Voulez vous vraiment supprimer", "Suppression", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dr == DialogResult.Yes)
                {
                    //Supprimer produit commande de la liste
                    int index = BL.D_Commande.listeDetail.FindIndex(s => s.ID == int.Parse(dgvDetailCommande.CurrentRow.Cells[0].Value.ToString()));
                    BL.D_Commande.listeDetail.RemoveAt(index);
                    //Actualiser datagrid
                    Actualise_DetailCommande();
                    MessageBox.Show("Suppression avec succes","Suppression",MessageBoxButtons.OK,MessageBoxIcon.Asterisk);
                }
                else
                {
                    MessageBox.Show("Suppression annulée", "Suppression", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }



            }
        }

        private void textTVA_TextChanged(object sender, EventArgs e)
        {
            //Calcul TTC
            Actualise_DetailCommande();
        }

        public int Idclient;
        private void btnenregistrer_Click(object sender, EventArgs e)
        {
            BL.CLS_Commande_DetailCommande clscdc = new BL.CLS_Commande_DetailCommande();

            if (dgvDetailCommande.Rows.Count == 0) //Si datagrid est vide
            {
                MessageBox.Show("Ajouter des produits", "Enregistrer", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (textNomC.Text == "")
                {
                    MessageBox.Show("Ajouter un client","Client", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    //Enregitrer commande
                    clscdc.Ajouter_Commande(dateCommande.Value,Idclient,textHT.Text,textTVA.Text,textTTC.Text);
                    //Enregistrer liste detail commande dans base de données
                    foreach (var L in BL.D_Commande.listeDetail )
                    {
                        clscdc.Ajouter_Detail(L.ID,L.Nom,L.Quantité,L.Prix,L.Remise,L.Total);
                    }
                    (usercontrol as USER_LISTE_Commande ).RemplirData();
                    //Vider la liste
                    BL.D_Commande.listeDetail.Clear();
                    //Quitter form
                    Close();
                    MessageBox.Show("Commande ajouté avec succés","Commande",MessageBoxButtons.OK,MessageBoxIcon.Asterisk);
                }
            }

        }
    }
}
