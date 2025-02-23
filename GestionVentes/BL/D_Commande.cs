using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionVentes.BL
{
    internal class D_Commande
    {

        public static List<D_Commande> listeDetail = new List<D_Commande>();
        public int ID { get; set; }
        public String Nom { get; set; }
        public int Quantité { get; set; }
        public String Prix { get; set; }

        public String  Remise { get; set; }

        public String Total { get; set; }
    }
}
