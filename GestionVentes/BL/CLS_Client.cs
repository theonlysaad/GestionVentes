using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionVentes.BL
{
    class CLS_Client
    {
        private dbVenteContext db = new dbVenteContext();
        private client c ; // Table Client

        // Fct pour ajouter un client dans la base de données
        
        public bool AjouterClient( string nom , string prenom , string adresse , String telephone , string email , string pays , string ville )
        {
            c = new client();
            c.nomClient = nom;
            c.prenomClient = prenom;
            c.adresseClient = adresse;
            c.teleClient = telephone;
            c.villeClient = ville;
            c.emailClient = email;
            c.paysClient = pays;

            //Verifier si le nom t le prenom déjà existe dans la base de données
            if (db.clients.SingleOrDefault(s => s.nomClient == nom && c.prenomClient == prenom) == null) // si n'existe pas
            {
                db.clients.Add(c); // Ajouter dans la table client
                db.SaveChanges(); // Enregistrer dans la base de données
                return true;
            }
            else // Si existe dans la bd
                return false;
        }

        // Fct pour modifier le client dans la base de données

        public void ModifierClient(int id, string nom, string prenom, string adresse, String telephone, string email, string pays, string ville)
        {
            c = new client();
            c = db.clients.SingleOrDefault(s => s.numClient == id); // Verifier si le client existe

            if (c != null) //s'il existe
            {
                c.nomClient = nom;
                c.prenomClient = prenom;
                c.adresseClient = adresse;
                c.teleClient = telephone;
                c.villeClient = ville;
                c.emailClient = email;
                c.paysClient = pays;
                db.SaveChanges();


            }
        }

        // Fct pour supprimer un client

        public void SupprimerClient(int id)
        {
            c = new client();
            c = db.clients.SingleOrDefault(s => s.numClient == id);
            if(c!= null) //Existe
            {
                db.clients.Remove(c);
                db.SaveChanges();

            }
        }
    }


}
