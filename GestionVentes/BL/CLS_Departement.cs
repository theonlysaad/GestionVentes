using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionVentes.BL
{
    internal class CLS_Departement
    {
        private dbVenteContext db = new dbVenteContext();
        private departement d;
        //Ajouter departement
        public bool AjouterDepartement(string nomDepartement)
        {
            d = new departement();
            d.nomDepartement = nomDepartement;
            //Verifier si le nom déjà existe dans la base de données
            if (db.departements.SingleOrDefault(s => s.nomDepartement == nomDepartement) == null) // si n'existe pas
            {
                db.departements.Add(d); // Ajouter dans la table departement
                db.SaveChanges(); // Enregistrer dans la base de données
                return true;
            }
            else // Si existe dans la bd
                return false;
        }

        //Modifier departement
        public void ModifierDepartement(int id, string nomDepartement)
        {
            d = new departement();
            d = db.departements.SingleOrDefault(s => s.numDepartement == id); // Verifier si le client existe

            if (d != null) //s'il existe
            {
                d.nomDepartement = nomDepartement;
                db.SaveChanges();


            }
        }

        //Supprimer departement
        public void SupprimerDepartement(int id)
        {
            d = new departement();
            d = db.departements.SingleOrDefault(s => s.numDepartement == id);
            if (d != null)
            {
                db.departements.Remove(d);
                db.SaveChanges();
            }
        }
    }
}
