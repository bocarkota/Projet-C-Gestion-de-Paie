using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static projetFinal.Employe;

namespace projetFinal
{
    public class Enregistrement
    {
        public void Menu()
        {
            List<Employe> listeEmployes = new List<Employe>();
            int choix;
            do
            {
                Console.WriteLine("*****************************************************************");
                Console.WriteLine("*****************************************************************");
                Console.WriteLine("**************   FAITE VOTRE CHOIX:  ****************************");
                Console.WriteLine("                1: AJOUTER UN EMPLOYE                            ");
                Console.WriteLine("                2: MODIFIER UN EMPLOYE                           ");
                Console.WriteLine("                3: SUPPRIMER UN EMPLOYE                          ");
                Console.WriteLine("                4: AFFICHER LA LISTE DES EMPLOYES                ");
                Console.WriteLine("                5: RECHERCHER UN EMPLOYE                         ");
                Console.WriteLine("                6: CALCULER LE SALAIRE DE L'EMPLOYE              ");
                Console.WriteLine("                7: QUITTER                                       ");
                Console.WriteLine("*****************************************************************");
                Console.WriteLine("*****************************************************************");
                choix = Convert.ToInt32(Console.ReadLine());




                switch (choix)
                {

                    case 1:
                        AjoutEmployeListe.ajouterEmployeListe(listeEmployes);

                        break;

                    case 2:
                        ModifierEmploye.modifierEmploye(listeEmployes);



                        break;

                    case 3:SupprimerEmploye.supprimerEmploye(listeEmployes);


                        break;
                    case 4:
                       AfficherEmploye.afficheEmploye ( listeEmployes);

                        break;

                    case 5:
                        RechercherEmploye.recherche_employe(listeEmployes);


                        break;

                    case 6:
                        CalculeSalaire.calcule_salaire(listeEmployes);
                        break;

                    case 7:QuitterProgramme.Quitter();


                        break;


                    default:

                        break;

                }
            } while (choix != 7);
        }
    }
}
