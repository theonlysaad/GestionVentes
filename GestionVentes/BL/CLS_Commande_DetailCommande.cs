using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionVentes.BL
{
    internal class CLS_Commande_DetailCommande
    {
        private dbVenteContext db = new dbVenteContext();
        private commande cm;
        private detailsCommandes dc;
        public int Idcommande;
        public void Ajouter_Commande(DateTime dateCommande,int Idclient, string totalht, string tva, string totalttc)
        {
            cm = new commande();
            cm.dateCommande = dateCommande;
            cm.numClient = Idclient;
            cm.Total_HT = totalht;
            cm.TVA = tva;
            cm.Total_TTC = totalttc;
            db.commandes.Add(cm);
            db.SaveChanges();
            Idcommande = cm.numCommande;//id du commande ajouté
        }

        //Puis on va ajouter détails commande
        public void Ajouter_Detail(int idproduit,String nomProduit,int quantite, String prix, String remise,  String total)
        {
            dc = new detailsCommandes();
            dc.numCommande = Idcommande;
            dc.numProduit = idproduit;
            dc.nomProduit = nomProduit;
            dc.qte = quantite;
            dc.Prix = prix;
            dc.Remise = remise;
            dc.Total = total;
            db.detailsCommandes.Add(dc);
            db.SaveChanges();

        }
    }
}
