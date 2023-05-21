using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Gestion_Paies.Historique_paiement;

namespace Gestion_Paies
{
    public class Suprimer_fiches
    {
        public void supprimer_fiche(fiche_paiement fiche)
        {
            liste_paiement.Remove(fiche);
        }
    }
}
