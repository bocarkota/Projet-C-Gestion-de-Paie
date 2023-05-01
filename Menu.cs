using System;
using System.Diagnostics;

namespace Paie.Models
{
    internal class Menu
    {
        public void Afficher()
        {
            int choix;
            GestionEmploye gestion = new GestionEmploye();
         
           
            do
            {
                Console.WriteLine("ENTRER VOTRE CHOIX");
                Console.WriteLine("1. AJOUTER UN EMPLOYE");
                Console.WriteLine("2. MODIFIER UN EMPLOYE");
                Console.WriteLine("3. SUPPRIMER UN EMPLOYE");
                Console.WriteLine("4. AFFICHER TOUS LES EMPLOYES");
                Console.WriteLine("5. CALCULE DE SALAIRE");
                Console.WriteLine("6. FICHE DE PAIE");
                Console.WriteLine("6. HISTORIQUE DE PAIEMENT");
                Console.WriteLine("7. QUITTER");

                choix = int.Parse(Console.ReadLine());

                switch (choix)
                {
                    case 1:
                       
                        gestion.AjouterEmploye();
                        break;
                    case 2:
                       
                        gestion.ModifierEmploye();
                        break;
                    case 3:
                       
                        gestion.RetirerEmploye();
                        break;
                    case 4:
                        
                        gestion.AfficherEmploye();  
                        break;
                    case 5:
                        gestion.CalculerSalaireEmploye();
                       
                        break;

                    case 6:
                        gestion.fiche_paie();

                        break;

                    case 7:
                        Console.WriteLine("AU REVOIR !");
                        break;
                    default:
                        Console.WriteLine("CHOIX INVALIDE");
                        break;
                }
            } while (choix != 7);
        }
    }
}
