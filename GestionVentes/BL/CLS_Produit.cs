using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionVentes.BL
{
    internal class CLS_Produit
    {
        private dbVenteContext db = new dbVenteContext();
        private produit p;
        //Ajouter produit
        public bool AjouterProduit(string nomProduit, int qteStock , string prixProduit, byte[] imageProduit, int numCategorie )
        {
            p = new produit();
            p.nomProduit = nomProduit;
            p.qteStock = qteStock;
            p.prixProduit = prixProduit;
            p.imageProduit = imageProduit;
            p.numCategorie = numCategorie;
            //Verifier si le nom t le prenom déjà existe dans la base de données
            if (db.produits.SingleOrDefault(s => s.nomProduit == nomProduit) == null) // si n'existe pas
            {
                db.produits.Add(p); // Ajouter dans la table client
                db.SaveChanges(); // Enregistrer dans la base de données
                return true;
            }
            else // Si existe dans la bd
                return false;
        }
        
        //Modifier produit
        public void ModifierProduit(int id, string nomProduit, int qteStock, string prixProduit, byte[] imageProduit, int numCategorie)
        {
            p = new produit();
            p = db.produits.SingleOrDefault(s => s.numProduit == id); // Verifier si le client existe

            if (p != null) //s'il existe
            {
                p.nomProduit = nomProduit;
                p.qteStock = qteStock;
                p.prixProduit= prixProduit;
                p.imageProduit = imageProduit;
                p.numCategorie = numCategorie;
               
                db.SaveChanges();


            }
        }

        //Supprimer produit
        public void SupprimerProduit(int id)
        {
            p = new produit();
            p = db.produits.SingleOrDefault(s => s.numProduit == id);
            if(p != null)
            {
                db.produits.Remove(p);
                db.SaveChanges();
            }
        }

    }


}
