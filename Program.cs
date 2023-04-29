using System;

namespace GestionPaie
{
    class Program
    {
        static void Main(string[] args)
        {
            bool continuer = true;

            while (continuer)
            {
                Console.WriteLine("Gestion de paie");
                Console.WriteLine("----------------");
                Console.WriteLine("1. Ajouter employé");
                Console.WriteLine("2. Modifier employé");
                Console.WriteLine("3. Supprimé employé");
                Console.WriteLine("4. Informations sur les employés");
                Console.WriteLine("5. Calcul Paiement");
                Console.WriteLine("6. Afficher Fiches de paiement");
                Console.WriteLine("7. Modifier Fiche de Paiement");
                Console.WriteLine("8.Ajouter Historique Paiement");
                Console.WriteLine("9.Supprimer Historique Paiement");
                Console.WriteLine("10. Quitter");

                Console.Write("Choisissez une option : ");
                string Choix = Console.ReadLine();

                switch (Choix)
                {
                    case "1":
                        AjouterEmploye();
                        break;
                    case "2":
                        ModifierEmploye();
                        break;
                    case "3":
                        SupprimerEmploye();
                        break;
                    case "4":
                        AfficherEmploye();
                        break;
                    case "5":
                        CalculSalaire();
                        break;
                    case "6":
                        AfficherFichePaiement();
                        break;
                    case "7":
                        ModifierFichePaiement();
                        break;
                    case "8":
                        AjouterHistoriquePaiement();
                        break;
                    case "9":
                        SupprimerHistoriquePaiement();
                        break;
                    default:
                        Console.WriteLine("Choix impossible");
                        break;
                }
                Console.WriteLine();
            }
        }
        static void AjouterEmploye()
        {
            Console.WriteLine("Ajout des employés :");
            Console.WriteLine("---------------------------------------");
            // Code 
        }

        static void ModifierEmploye()
        {
            Console.WriteLine("Employe modifier !");
            Console.WriteLine("-------------------");
            // Code 
        }

        static void SupprimerEmploye()
        {
            Console.WriteLine("Employe Supprimé !");
            Console.WriteLine("---------------------------");
            // Code 
        }

        static void AfficherEmploye()
        {
            Console.WriteLine("Les Employe sont :");
            Console.WriteLine("--------------------------------");
            // Code
        }
        static void CalculSalaire()
        {
            Console.WriteLine("Salaire est :");
            Console.WriteLine("--------------------------------");
            // Code
        }
        static void AfficherFichePaiement()
        {
            Console.WriteLine("La fiche de paiements est :");
            Console.WriteLine("--------------------------------");
            // Code 
        }
        static void ModifierFichePaiement()
        {
            Console.WriteLine("la fiche de paiement est modifiée");
            Console.WriteLine("--------------------------------");
            // Code 
        }
        static void AjouterHistoriquePaiement()
        {
            Console.WriteLine("L'historique des paiements :");
            Console.WriteLine("--------------------------------");
            // Code
        }
        static void SupprimerHistoriquePaiement()
        {
            Console.WriteLine("Historique des Paiements supprimée");
            Console.WriteLine("--------------------------------");
            // Code
        }
    }
}
