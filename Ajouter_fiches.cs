using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Gestion_Paies.Historique_paiement;

namespace Gestion_Paies
{
    public class Ajouter_fiches
    {
        public void Ajouter_fiche(fiche_paiement fiche)
        {
            liste_paiement.Add(fiche);
        }
    }
}
