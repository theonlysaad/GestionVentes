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
    public partial class FRM_MENU : Form
    {
        public FRM_MENU()
        {
            InitializeComponent();
            panel1.Size = new Size(276, 1007);
            panelParamettre.Visible = false;
        }

        // Desactiver form
        public void desactiverForm()
        {
            btnclient.Enabled = false;
            btnproduit.Enabled = false;
            btncommande.Enabled = false;
            btncategorie.Enabled = false;
            btndepartement.Enabled = false;
           // btncopie.Enabled = false;
          //  btnrestaurer.Enabled = false;
            btndeconnecter.Enabled = false;
            pen.Enabled=false;
            //connecte activer
            btnconnecter.Enabled=true;
        }

        // Activer form

        public void activerForm()
        {
            btnclient.Enabled = true;
            btnproduit.Enabled = true;
            btncommande.Enabled = true;
            btncategorie.Enabled = true;
            btndepartement.Enabled = true;
            // btncopie.Enabled = true;
            // btnrestaurer.Enabled = true;
            btndeconnecter.Enabled = true;
            pen.Enabled = true;
            //connecte desactiver
            btnconnecter.Enabled = false;
            panelParamettre.Visible = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btnclient_Click(object sender, EventArgs e)
        {
            pen.Top = btnclient.Top;
            /*Test test = new Test();
            test.TopLevel = false;
            test.AutoScroll = true;
            this.panel4.Controls.Add(test);

            test.Show();
            */

            if (!pnlafficher.Controls.Contains(USER_Liste_Client.Instance))
            {
                pnlafficher.Controls.Add(USER_Liste_Client.Instance);
                USER_Liste_Client.Instance.Dock = DockStyle.Fill;
            } else
            {
                USER_Liste_Client.Instance.BringToFront();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            pen.Top = btnproduit.Top;
            if (!pnlafficher.Controls.Contains(USER_Liste_Produit.Instance))
            {
                pnlafficher.Controls.Add(USER_Liste_Produit.Instance);
                USER_Liste_Produit.Instance.Dock = DockStyle.Fill;
            }
            else



            {
                USER_Liste_Produit.Instance.BringToFront();
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            pen.Top = btncategorie.Top;
            if (!pnlafficher.Controls.Contains(USER_LISTE_Catégorie.Instance))
            {
                pnlafficher.Controls.Add(USER_LISTE_Catégorie.Instance);
                USER_LISTE_Catégorie.Instance.Dock = DockStyle.Fill;
            }
            else
            {
                USER_LISTE_Catégorie.Instance.BringToFront();
            }

        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            if(panel1.Width== 276)
            {
                panel1.Size = new Size(106, 1007);
            }else
            {
                panel1.Size = new Size(276, 1007);
            }
        }

        private void btncommande_Click(object sender, EventArgs e)
        {
            pen.Top = btncommande.Top;
            if (!pnlafficher.Controls.Contains(USER_LISTE_Commande.Instance))
            {
                pnlafficher.Controls.Add(USER_LISTE_Commande.Instance);
                USER_LISTE_Commande.Instance.Dock = DockStyle.Fill;
            }
            else
            {
                USER_LISTE_Catégorie.Instance.BringToFront();
            }
        }

        

        private void FRM_MENU_Load(object sender, EventArgs e)
        {
            desactiverForm();
        }

        private void button5_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click_1(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btnparamettre_Click(object sender, EventArgs e)
        {
            panelParamettre.Size = new Size(360,83);
            panelParamettre.Visible = !panelParamettre.Visible;


        }

        private void btnconnecter_Click(object sender, EventArgs e)
        {
            //Afficher le formulaire de connexion
            FRM_Connexion frmc = new FRM_Connexion(this); //this = FRM_MENU
            frmc.ShowDialog();
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnrestaurer_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btndeconnecter_Click(object sender, EventArgs e)
        {
            desactiverForm();
        }

        private void pnlafficher_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pen_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panelParamettre_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btncopie_Click(object sender, EventArgs e)
        {

        }

        private void btnproduit_Enter(object sender, EventArgs e)
        {

        }

        private void btndepartement_Click(object sender, EventArgs e)
        {
            pen.Top = btndepartement.Top;
            if (!pnlafficher.Controls.Contains(USER_LISTE_Departement.Instance))
            {
                pnlafficher.Controls.Add(USER_LISTE_Departement.Instance);
                USER_LISTE_Departement.Instance.Dock = DockStyle.Fill;
            }
            else
            {
                USER_LISTE_Departement.Instance.BringToFront();
            }
        }
    }
}
