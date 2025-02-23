using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionVentes.BL
{
    internal class CLS_Categorie
    {
        private dbVenteContext db = new dbVenteContext();
        private categorie c;
        //Ajouter categorie
        public bool AjouterCategorie(string nomCategorie, int numDepartement)
        {
            c = new categorie();
            c.nomCategorie = nomCategorie;
            c.numDepartement = numDepartement;
            //Verifier si le nom t le prenom déjà existe dans la base de données
            if (db.categories.SingleOrDefault(s => s.nomCategorie == nomCategorie) == null) // si n'existe pas
            {
                db.categories.Add(c); // Ajouter dans la table client
                db.SaveChanges(); // Enregistrer dans la base de données
                return true;
            }
            else // Si existe dans la bd
                return false;
        }

        //Modifier categorie
        public void ModifierCategorie(int id, string nomCategorie, int numDepartement)
        {
            c = new categorie();
            c = db.categories.SingleOrDefault(s => s.numCategorie == id); // Verifier si le client existe

            if (c != null) //s'il existe
            {
                c.nomCategorie = nomCategorie;
                c.numDepartement = numDepartement;

                db.SaveChanges();


            }
        }

        //Supprimer catégorie

        public void SupprimerCategorie(int id)
        {
            c = new categorie();
            c = db.categories.SingleOrDefault(s => s.numCategorie == id);
            if (c != null)
            {
                db.categories.Remove(c);
                db.SaveChanges();
            }
        }
    }
}
