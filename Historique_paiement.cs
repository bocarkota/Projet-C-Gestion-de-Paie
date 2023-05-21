using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gestion_Paies
{
    public class Historique_paiement
    {
        private int id_historique;
        private Employe employe;
        private List<fiche_paiement> liste_paiement;

        public Historique_paiement(int id_historique, Employe employe, List<fiche_paiement> liste_paiement)
        {
            this.id_historique = id_historique;
            this.employe = employe;
            this.liste_paiement = liste_paiement;
        }
    }
}
