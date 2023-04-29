using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gestion_De_Paie
{
    internal class Historique_Paiement
    {
        private int ID_historique;
        private Employe employe;
        //cet attribut sert de stocker la liste de paiement. cette liste contient  toutes les fiches de paiement associées à l'historique de paiement.
        private List<fiche_paiement> liste_paiement;

        //le constructeur 
        public Historique_paiement(int id_historique, Employe employe, List<fiche_paiement> liste_paiement)
        {
            // initialisation des attributs prives de la classe avec les valeurs fournies dans les paramettres du constructeurs
            this.id_historique = id_historique;
            this.employe = employe;
            this.liste_paiement = liste_paiement;
        }

        public void Ajouter_fiche(fiche_paiement fiche)
        {
            liste_paiement.Add(fiche);
        }

        public void supprimer_fiche(fiche_paiement fiche)
        {
            liste_paiement.Remove(fiche);
        }
    }
}
