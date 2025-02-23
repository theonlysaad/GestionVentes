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
using Microsoft.Reporting.WinForms;
using Microsoft.Office.Interop.Excel;
namespace GestionVentes.PL
{
    public partial class USER_Liste_Produit : UserControl
    {
        private static USER_Liste_Produit Userproduit;
        private dbVenteContext db;

        //Creer une instance pour le usercontrole
        public static USER_Liste_Produit Instance
        {
            get
            {
                if (Userproduit == null)
                {
                    Userproduit = new USER_Liste_Produit();
                }
                return Userproduit;
            }
        }
        public USER_Liste_Produit()
        {
            InitializeComponent();
            db = new dbVenteContext();
        }

        //Actualiser datagrid produit

        public void Actualiserdvg()
        {
            db = new dbVenteContext();
            dvgproduit.Rows.Clear();
            //Pour afficher le nom de categorie à partir du numcategorie
            categorie cat = new categorie();
            foreach (var List in db.produits)
            {
                cat = db.categories.SingleOrDefault(s => s.numCategorie == List.numCategorie);
                if (cat != null)// si existe
                {
                    dvgproduit.Rows.Add(false, List.numProduit, List.nomProduit, List.qteStock, List.prixProduit, cat.nomCategorie);

                }
            }

            //Colorer les stocks vides en rouge
            for(int i = 0; i < dvgproduit.Rows.Count; i++)
            {
                if ((int)dvgproduit.Rows[i].Cells[3].Value == 0)
                {
                    dvgproduit.Rows[i].Cells[3].Style.BackColor = Color.Red;
                }
                else
                {
                    dvgproduit.Rows[i].Cells[3].Style.BackColor = Color.LightGreen;

                }
            }

        }

        // Verifier combien de ligne est séléctionnée
        public String SelectVerif()
        {
            int NmbreLigneSelect = 0;
            for (int i = 0; i < dvgproduit.Rows.Count; i++)
            {
                if ((bool)dvgproduit.Rows[i].Cells[0].Value == true) //Si la ligne est séléctionnée
                {
                    NmbreLigneSelect++;
                }
            }
            if (NmbreLigneSelect == 0)
            {
                return "Selectionner le Produit ";
            }
            else if (NmbreLigneSelect > 1)
            {
                return "Selectionner une seule ligne pour modifier";
            }
            return null;
        }

        private void USER_Liste_Produit_Load(object sender, EventArgs e)
        {
            Actualiserdvg();
        }

        private void textrecherche_Enter(object sender, EventArgs e)
        {

        }

        private void textrecherche_Enter_1(object sender, EventArgs e)
        {
            if (textrecherche.Text == "Rechercher")
            {
                textrecherche.Text = "";
                textrecherche.ForeColor = Color.Black;
            }
        }

        private void btnajouter_Click(object sender, EventArgs e)
        {
            //Afficher formulaire de saisie 
            PL.FRM_Ajouter_Modifie_Produit frmp = new PL.FRM_Ajouter_Modifie_Produit(this);
            frmp.ShowDialog();
        }

        private void btnmodifier_Click(object sender, EventArgs e)
        {
            produit pr = new produit();
            if (SelectVerif() != null)
            {
                MessageBox.Show(SelectVerif(), "Modification", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                PL.FRM_Ajouter_Modifie_Produit frmp = new PL.FRM_Ajouter_Modifie_Produit(this);
                frmp.lblTitre.Text = "Modifier Produit";
                frmp.btnactualiser.Visible = false;
                for (int i = 0; i < dvgproduit.Rows.Count; i++) //Verifie ligne séléctionné
                {
                    if ((bool)dvgproduit.Rows[i].Cells[0].Value == true)//si ligne selectionné
                    {
                        int myidselect = (int)dvgproduit.Rows[i].Cells[1].Value;
                        pr = db.produits.SingleOrDefault(s => s.numProduit == myidselect);
                        if (pr != null) //si existe
                        {
                            frmp.comboCategorie.Text = dvgproduit.Rows[i].Cells[5].Value.ToString();
                            frmp.textNom.Text = dvgproduit.Rows[i].Cells[2].Value.ToString();
                            frmp.textQuantite.Text = dvgproduit.Rows[i].Cells[3].Value.ToString();
                            frmp.textPrix.Text = dvgproduit.Rows[i].Cells[4].Value.ToString();
                            frmp.IdProduit = (int)dvgproduit.Rows[i].Cells[1].Value;
                            //Afficher l'image du produit pour modifier
                            MemoryStream ms = new MemoryStream(pr.imageProduit);//Pour convertir l'image et l'afficher
                            frmp.picProduit.Image = Image.FromStream(ms);
                        }


                    }
                }
                frmp.ShowDialog();
            }


        }

        private void btnafficherphoto_Click(object sender, EventArgs e)
        {
            produit pr = new produit();

            if (SelectVerif() != null)
            {
                MessageBox.Show(SelectVerif(), "Selectionner", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                for (int i = 0; i < dvgproduit.Rows.Count; i++) //Verifie ligne séléctionné
                {
                    if ((bool)dvgproduit.Rows[i].Cells[0].Value == true)//si ligne selectionné
                    {
                        int myidselect = (int)dvgproduit.Rows[i].Cells[1].Value;
                        pr = db.produits.SingleOrDefault(s => s.numProduit == myidselect);
                        if (pr != null) //si existe
                        {
                            FRM_Photo_Produit frmP = new FRM_Photo_Produit();
                            //Declarer System.IO
                            MemoryStream ms = new MemoryStream(pr.imageProduit);//Pour convertir l'image et l'afficher
                            frmP.ProduitImage.Image = Image.FromStream(ms);
                            frmP.ProduitNom.Text = dvgproduit.Rows[i].Cells[2].Value.ToString();
                            //Afficher formulaire
                            frmP.ShowDialog();
                        }
                    }
                }
            }
        }

        private void btnsupprimer_Click(object sender, EventArgs e)
        {
            BL.CLS_Produit prd = new BL.CLS_Produit();
            // Supprimer tout les clients séléctionnés
            int select = 0;
            for (int i = 0; i < dvgproduit.Rows.Count; i++)
            {
                if ((bool)dvgproduit.Rows[i].Cells[0].Value == true)
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
                    for (int i = 0; i < dvgproduit.Rows.Count; i++)
                    {
                        if ((bool)dvgproduit.Rows[i].Cells[0].Value == true)
                        {
                            prd.SupprimerProduit(int.Parse(dvgproduit.Rows[i].Cells[1].Value.ToString()));
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
            var listerecherche = db.produits.ToList(); // listerecherche = lister les produits
            if (textrecherche.Text != "") //Pas vide
            {
              listerecherche = listerecherche.Where(s => s.nomProduit.IndexOf(textrecherche.Text, StringComparison.CurrentCultureIgnoreCase) != -1).ToList();
              // != -1 existe dans la base de données
                           

            }
            categorie cat = new categorie();
            //Vider datagrid
            dvgproduit.Rows.Clear();
            //Ajouter listerecherche dans datagridview client
            foreach (var l in listerecherche)
            {
                cat = db.categories.SingleOrDefault(s => s.numCategorie == l.numCategorie);
                dvgproduit.Rows.Add(false,l.numProduit,l.nomProduit,l.qteStock,l.prixProduit,cat.nomCategorie);
            }
        }

        private void btnexcel_Click(object sender, EventArgs e)
        {
            db = new dbVenteContext();
            using (SaveFileDialog sdf = new SaveFileDialog() { Filter = "Excel Workbook|$.xlsx", ValidateNames = true })//Filtrer seulement fichier excel
            {
                if (sdf.ShowDialog() == DialogResult.OK)
                {
                    Microsoft.Office.Interop.Excel.Application app = new Microsoft.Office.Interop.Excel.Application();
                    Workbook wb = app.Workbooks.Add(XlSheetType.xlWorksheet);
                    Worksheet ws = (Worksheet)app.ActiveSheet;
                    app.Visible = false;
                    //Ajouter les lignes fichier excel
                    ws.Cells[1, 1] = "Num_Produit";
                    ws.Cells[1, 2] = "Nom_Produit";
                    ws.Cells[1, 3] = "Quantité";
                    ws.Cells[1, 4] = "Prix";
                    //Ajouter liste de produit de base de données dans fichier excel
                    var ListeProduit = db.produits.ToList();//Lister les produits
                    int i = 2;
                    foreach (var L in ListeProduit)
                    {
                        ws.Cells[i, 1] = L.numProduit;
                        ws.Cells[i, 2] = L.nomProduit;
                        ws.Cells[i, 3] = L.qteStock;
                        ws.Cells[i, 4] = L.prixProduit;
                        i++;
                    }

                    //Changer style de fichier
                    ws.Range["A1:D1"].Interior.Color = Color.Brown;//BackgroundColor
                    ws.Range["A1:D1"].Font.Color = Color.White;//Text color
                    ws.Range["A1:D1"].Font.Size = 15;//Text color
                    ws.Range["A:D"].HorizontalAlignment = XlHAlign.xlHAlignCenter;//Centrer le texte
                    ws.Range["A1:D1"].ColumnWidth = 16;//Changer column size


                    wb.SaveAs(sdf.FileName);//Sauvegarder dans fichier Excel
                    app.Quit();
                    MessageBox.Show("Sauvegarde avec succé sur Excel", "Excel", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                }
               

            }
        }

        private void btnimprimerSelect_Click(object sender, EventArgs e)
        {
            String nomCat=null;
            db = new dbVenteContext();
            int idselect=0;
            RAP.FRM_RAPPORT fr = new RAP.FRM_RAPPORT();
            produit pr = new produit();
            if (SelectVerif() != null)
            {
                MessageBox.Show(SelectVerif(),"Imprimer Produit",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
            else
            {
                for(int i = 0;i<dvgproduit.Rows.Count;i++)
                {
                    if ((bool)dvgproduit.Rows[i].Cells[0].Value==true)
                    {
                        idselect = (int)dvgproduit.Rows[i].Cells[1].Value;
                        nomCat = dvgproduit.Rows[i].Cells[5].Value.ToString();
                    }
                }

                pr = db.produits.SingleOrDefault(s=>s.numProduit==idselect);
                if (pr != null)
                {
                    fr.RPafficher.LocalReport.ReportEmbeddedResource = "GestionVentes.RAP.RPT_Produit.rdlc";
                    ReportParameter Pcat = new ReportParameter("RPCategorie",nomCat);
                    ReportParameter Pnom = new ReportParameter("RPNom", pr.nomProduit);
                    ReportParameter Pprix = new ReportParameter("RPPrix", pr.prixProduit);
                    ReportParameter Pqte = new ReportParameter("RPQuantité", pr.qteStock.ToString());
                    String Imagestring = Convert.ToBase64String(pr.imageProduit);
                    ReportParameter Pimage = new ReportParameter("RPImage", Imagestring);

                    fr.RPafficher.LocalReport.SetParameters(new ReportParameter[] { Pnom , Pqte ,Pprix, Pcat , Pimage }); 
                    fr.RPafficher.RefreshReport();
                    fr.ShowDialog();    
                }
            }
        }

        private void btnimprimerTout_Click(object sender, EventArgs e)
        {
            RAP.FRM_RAPPORT fr = new RAP.FRM_RAPPORT();
            db = new dbVenteContext();
            try
            {
                var listeProduit = db.produits.ToList();
                fr.RPafficher.LocalReport.ReportEmbeddedResource = "GestionVentes.RAP.RPT_LISTE_PRODUIT.rdlc";
                fr.RPafficher.LocalReport.DataSources.Add(new ReportDataSource("databaseproduit", listeProduit));
                ReportParameter date = new ReportParameter("Date", DateTime.Now.ToString());
                fr.RPafficher.LocalReport.SetParameters(new ReportParameter[] { date });
                fr.RPafficher.RefreshReport();
                fr.ShowDialog();
            }catch(Exception EX)
            {
                MessageBox.Show(EX.Message);
            }
        }
    }
}
