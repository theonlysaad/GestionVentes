using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GestionVentes.RAP
{
    public partial class FRM_RAPPORT : Form
    {
        public FRM_RAPPORT()
        {
            InitializeComponent();
        }

        private void FRM_RAPPORT_Load(object sender, EventArgs e)
        {

            this.RPafficher.RefreshReport();
            this.RPafficher.RefreshReport();
        }

        private void RPafficher_Load(object sender, EventArgs e)
        {

        }
    }
}
