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
    public partial class USER_LISTE_Commande : UserControl
    {
        private static USER_LISTE_Commande UserCommande;
        private dbVenteContext db;

        //Creer une instance pour le usercontrole
        public static USER_LISTE_Commande Instance
        {
            get
            {
                if (UserCommande == null)
                {
                    UserCommande = new USER_LISTE_Commande();
                }
                return UserCommande;
            }
        }
        public USER_LISTE_Commande()
        {
            InitializeComponent();
            db = new dbVenteContext();
        }

        private void USER_LISTE_Commande_Load(object sender, EventArgs e)
        {

        }

        //Remplir datagrid commande
        public void RemplirData()
        {
            dvgcommande.Rows.Clear();
            client c = new client();
            String NomPrenom;
            foreach (var L in db.commandes)
            {
                //Afficher nom et prenom de client
                c = db.clients.Single(s => s.numClient == L.numClient);
                NomPrenom = c.nomClient + "  " + c.prenomClient;
                dvgcommande.Rows.Add(L.numCommande,L.dateCommande,NomPrenom,L.Total_HT,L.TVA,L.Total_TTC);
            }
        }

        private void btnajouterCom_Click(object sender, EventArgs e)
        {
            PL.FRM_Details_Commande frmdc = new FRM_Details_Commande(this);
            frmdc.ShowDialog();
        }

        private void btnresearch_Click(object sender, EventArgs e)
        {
            //Rechercher entre deux dates
            var listecommande = db.commandes.ToList();//liste des commandes
            if (dvgcommande.Rows.Count!=0)
            {
                listecommande = listecommande.Where(s => s.dateCommande >= dateD.Value.Date && s.dateCommande <= dateF.Value.Date).ToList();
                //Remplir datagrid
                dvgcommande.Rows.Clear();
                client c = new client();
                String NomPrenom;
                foreach (var L in listecommande)
                {
                    //Afficher nom et prenom de client
                    c = db.clients.Single(s => s.numClient == L.numClient);
                    NomPrenom = c.nomClient + "  " + c.prenomClient;
                    dvgcommande.Rows.Add(L.numCommande, L.dateCommande, NomPrenom, L.Total_HT, L.TVA, L.Total_TTC);
                }
            }
        }

        private void dvgcommande_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dateD_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}
