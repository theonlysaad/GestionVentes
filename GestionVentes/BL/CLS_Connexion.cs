using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionVentes.BL
{
    internal class CLS_Connexion
    {
        //fonction pour verifier la connexion
        public bool ConnexionValide(dbVenteContext db, String Nom, String mdp)
        {
            Utilisateur U = new Utilisateur();    // Table utilisateur
            U.nomUtilisateur = Nom;
            U.mdpUtilisateur = mdp;

            if (db.Utilisateurs.SingleOrDefault(s => s.nomUtilisateur == Nom && s.mdpUtilisateur == mdp) != null) // si le nom de l'utilisateur et lemot de passe existe dans la base de données
            {
                return true;
            }
            else // si n'existe pas
                return false;
        }

    }
}
