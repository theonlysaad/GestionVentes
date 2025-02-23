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
    public partial class FRM_Produit_Commande : Form
    {
        public Form frmdetail;
        public FRM_Produit_Commande(Form frmdetail)
        {
            InitializeComponent();
            this.frmdetail = frmdetail;
        }

        private void textquantité_KeyPress(object sender, KeyPressEventArgs e)
        {
            //text numérique
            if(!char.IsDigit(e.KeyChar) && e.KeyChar != 8)
            {
                e.Handled = true;
            }
        }

        private void textremise_KeyPress(object sender, KeyPressEventArgs e)
        {
            //text numérique
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != 8)
            {
                e.Handled = true;
            }
        }

        private void textquantité_TextChanged(object sender, EventArgs e)
        {
            if (textquantité.Text != "") //Pas vide
            {
                int quantité = int.Parse(textquantité.Text);
                int prix = int.Parse(lblprix.Text);
                if (int.Parse(textquantité.Text) > int.Parse(lblstock.Text))
                {
                    MessageBox.Show("Il y a seulement "+int.Parse(lblstock.Text)+" dans le stock","Stock",MessageBoxButtons.OK,MessageBoxIcon.Warning);
                    //Vider textbox Quantité
                    textquantité.Text = "";
                    textTotal.Text = lblprix.Text;
                }
                else
                {
                    //Calcul Total
                    textTotal.Text = (quantité * prix).ToString();
                }    
            }
            else
            {
                textTotal.Text = lblprix.Text;
            }
           
        }

        private void textremise_TextChanged(object sender, EventArgs e)
        {
            if (textremise.Text != "")
            {
                int quantité;
                if (textquantité.Text != "")
                {
                   quantité = int.Parse(textquantité.Text);

                }
                else
                {
                    quantité = 1;
                }
                int prix = int.Parse(lblprix.Text);
                int total = quantité * prix;
                int remise = int.Parse(textremise.Text);
                textTotal.Text = (total - (total * remise / 100)).ToString();
            }
            else
            {
                int quantité;
                if (textquantité.Text != "")
                {
                    quantité = int.Parse(textquantité.Text);

                }
                else
                {
                    quantité = 1;
                }
                int prix = int.Parse(lblprix.Text);
                textTotal.Text=(quantité*prix).ToString();
            }
        }

        private void btnenregistrer_Click(object sender, EventArgs e)
        {
            //Si textbox quantite et remise vides
            int Quant, Re;
            if (textquantité.Text!="")
            {
                Quant = int.Parse(textquantité.Text);
            }
            else
            {
                Quant = 1;
            }
            if (textremise.Text != "")
            {
                Re = int.Parse(textremise.Text);
            }
            else
            {
                Re = 0;
            }

            //Ajouter produit dans commande
            BL.D_Commande DETAIL = new BL.D_Commande
            {
                ID = int.Parse(lblid.Text),
                Nom = lblnom.Text,
                Quantité = Quant,
                Prix = lblprix.Text,
                Remise = Re.ToString(),
                Total = textTotal.Text,
            };

            //Ajout dans la liste
            if (grpProduit.Text=="Vendre Produit")
            {
                if (BL.D_Commande.listeDetail.SingleOrDefault(s => s.ID == DETAIL.ID) != null)
                {
                    MessageBox.Show("Produit déjà existe dans la commande", "Produit", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                BL.D_Commande.listeDetail.Add(DETAIL);
            }
            else //Modifier
            {
                DialogResult dr = MessageBox.Show("Voulez-vous vraiment modifier", "Modification", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dr == DialogResult.Yes)
                {
                    int index = BL.D_Commande.listeDetail.FindIndex(s => s.ID == int.Parse(lblid.Text));
                    BL.D_Commande.listeDetail[index] =DETAIL;
                    MessageBox.Show("Modification succes","Modification",MessageBoxButtons.OK,MessageBoxIcon.Asterisk);
                    Close();
                }
                else
                {
                    MessageBox.Show("Modification annulé", "Modification", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                }
            }
            
            //Actualiser datagrid
            (frmdetail as FRM_Details_Commande).Actualise_DetailCommande();
        }

        private void FRM_Produit_Commande_Load(object sender, EventArgs e)
        {

        }
    }
}
