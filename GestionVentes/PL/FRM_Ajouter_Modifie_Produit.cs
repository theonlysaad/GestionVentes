using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace GestionVentes.PL
{
    public partial class FRM_Ajouter_Modifie_Produit : Form
    {
        private dbVenteContext db;
        private UserControl userProduit;
        public FRM_Ajouter_Modifie_Produit(UserControl user)
        {
            InitializeComponent();
            db = new dbVenteContext();
            this.userProduit = user;
            //Afficher les categories dans comboxcategorie
            comboCategorie.DataSource = db.categories.ToList();
            //Pour filtrer seulement les noms des categories
            comboCategorie.DisplayMember = "nomCategorie"; //Afficher seulement les noms des categories
            comboCategorie.ValueMember = "numCategorie";
            this.userProduit = user;
        }

        // Les champs obligatoires
        string testobligatoire()
        {
            if (textNom.Text == "" || textNom.Text == "Nom de Client")
            {
                return "Entrer le Nom du Produit";
            }

            if (textQuantite.Text == "" || textQuantite.Text == "Quantité")
            {
                return "Entrer la Quantité";
            }

            if (textPrix.Text == "" || textPrix.Text == "Prix")
            {
                return "Entrer le Prix";
            }

            if (picProduit.Image == null)
            {
                return "Entrer l'Image du Produit";
            }

            if(comboCategorie.Text == "")
            {
                return "Entrer Catégorie";
            }

            return null;

        }
            private void textNom_Enter(object sender, EventArgs e)
        {
            //Pour vider le textbox
            if (textNom.Text == "Nom Produit")
            {
                textNom.Text = "";
                textNom.ForeColor = Color.WhiteSmoke; // Changer couleur de texte
            }
        }

        private void textQuantite_Enter(object sender, EventArgs e)
        {
            //Pour vider le textbox
            if (textQuantite.Text == "Quantité")
            {
                textQuantite.Text = "";
                textQuantite.ForeColor = Color.WhiteSmoke; // Changer couleur de texte
            }
        }

        private void textPrix_Enter(object sender, EventArgs e)
        {
            //Pour vider le textbox
            if (textPrix.Text == "Prix")
            {
                textPrix.Text = "";
                textPrix.ForeColor = Color.WhiteSmoke; // Changer couleur de texte
            }
        }

        private void btnquitter_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void FRM_Ajouter_Modifie_Produit_Load(object sender, EventArgs e)
        {

        }

        private void btnParcourir_Click(object sender, EventArgs e)
        {
            //Afficher fichier image
            OpenFileDialog OP = new OpenFileDialog();
            OP.Filter = "|*.JPG;*.PNG;*.GIF;*.BMP;*.JFIF"; //Afficher seulement les images

            if(OP.ShowDialog() == DialogResult.OK)
            {
                picProduit.Image = Image.FromFile(OP.FileName);
            }
        }

        private void btnactualiser_Click(object sender, EventArgs e)
        {
            //Vider le formulaire
            textNom.Text = "Nom Produit"; textNom.ForeColor = Color.White;
            textQuantite.Text = "Quantité"; textQuantite.ForeColor = Color.White;
            textPrix.Text = "Prix"; textPrix.ForeColor = Color.White;
            comboCategorie.Text = "";
            picProduit.Image = null;



        }

        private void textQuantite_KeyPress(object sender, KeyPressEventArgs e)
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

        private void textPrix_KeyPress(object sender, KeyPressEventArgs e)
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

        public int IdProduit;
        private void btnenregistrer_Click(object sender, EventArgs e)
        {
            if (testobligatoire() != null)
            {
                MessageBox.Show(testobligatoire(), "Obligatoire", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {

                if (lblTitre.Text == "Ajouter Produit")
                {
                    BL.CLS_Produit clproduit = new BL.CLS_Produit();
                    //Convertir image en byte
                    //Ajouter system.IO
                    MemoryStream MR = new MemoryStream();
                    picProduit.Image.Save(MR,picProduit.Image.RawFormat);
                    byte[] byteimageP = MR.ToArray();//Convertir image en byte[]

                    if (clproduit.AjouterProduit(textNom.Text, int.Parse(textQuantite.Text),textPrix.Text,byteimageP,Convert.ToInt32(comboCategorie.SelectedValue))==true)
                    {
                        MessageBox.Show("Produit ajouté avec succés", "Ajouter", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                        (userProduit as USER_Liste_Produit).Actualiserdvg();
                    }
                    else
                    {
                        MessageBox.Show("Produit déjà existant ", "Ajouter", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    }

                } else //Modification
                {
                    MemoryStream MR = new MemoryStream();
                    picProduit.Image.Save(MR, picProduit.Image.RawFormat);
                    byte[] byteimageP = MR.ToArray();//Convertir image en byte[]
                    BL.CLS_Produit prod = new BL.CLS_Produit();
                    DialogResult rs = MessageBox.Show("Voulez-vous vraiment modifier ce produit","Moidifcation",MessageBoxButtons.YesNo,MessageBoxIcon.Question);
                   if(rs == DialogResult.Yes)
                    {
                        prod.ModifierProduit(IdProduit, textNom.Text, int.Parse(textQuantite.Text), textPrix.Text, byteimageP, Convert.ToInt32(comboCategorie.SelectedValue));
                        MessageBox.Show("Produit modifié avec succés","Modification",MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                        //Actualiser datagrid
                        (userProduit as USER_Liste_Produit).Actualiserdvg();
                        Close();//Pour quitter formulaire
                    } else
                    {
                        MessageBox.Show("Modification annulée", "Modification", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                    }

                }
            }
        }

        private void picProduit_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {

        }

        private void comboCategorie_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
