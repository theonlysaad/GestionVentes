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
    public partial class FRM_Client_Commande : Form
    {
        private dbVenteContext db;
        public FRM_Client_Commande()
        {
            InitializeComponent();
            db = new dbVenteContext();
        }

        

        private void FRM_Client_Commande_Load(object sender, EventArgs e)
        {
            foreach(var S in db.clients)
            {
                dvgclientC.Rows.Add(S.numClient, S.nomClient, S.prenomClient, S.adresseClient, S.villeClient, S.paysClient, S.teleClient, S.emailClient);
            }
        }

        private void dvgclientC_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            Close();
        }
    }
}
