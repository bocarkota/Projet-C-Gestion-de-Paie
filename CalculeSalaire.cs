using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projetFinal
{
    public class CalculeSalaire
    {

        public static void calcule_salaire(List<Employe> listeEmployes)
        {



            Console.Write("ENTRER L'ID DE L'EMPLOYE DONT VOUS SOUHAITEZ CALCULER LE SALAIRE : ");
            int id = int.Parse(Console.ReadLine());

            Employe emp = listeEmployes.FirstOrDefault(e => e.ID_Employe == id);
            if (emp == null)
            {
                Console.WriteLine("AUCUN N'EMPLOYE NE CORESPOND A CET IDENTIFIANT.");
                return;
            }



            // Calcul du salaire en fonction du nombre d'heure
            decimal salaire = emp.salaireHeureEmploye * emp.nbrHeureTravail;
            emp.salaireFixe = salaire;

            Console.WriteLine($"LE SALAIRE BRUT: {emp.salaireFixe} ");
            Console.WriteLine("  ");


            // Calcul de la la prime en fonction de l'assiduite
            if (emp.assiduiteEmploye)
            {
                emp.prime = emp.salaireFixe * 0.05m;
                emp.salaireFixe += emp.prime;

                Console.WriteLine("UNE PRIME DE 5% A ETE AJOUTER AU SALAIRE.");
               
            }

            // Calcul de la taxe

            if (emp.salaireFixe <= 100000)
            {
                emp.taxe = emp.salaireFixe * 0.01m;
                emp.salaireFixe = emp.salaireFixe - emp.taxe;

                Console.WriteLine("LA TAXE DE 1% A ETE RETIRER SUR LE SALAIRE.");
                Console.WriteLine("  ");
            }


            else if (emp.salaireFixe <= 200000)
            {
                emp.taxe = emp.salaireFixe * 0.02m;
                emp.salaireFixe = emp.salaireFixe - emp.taxe;

                Console.WriteLine("LA TAXE DE 2% A ETE RETIRER SUR LE SALAIRE.");
                Console.WriteLine("  ");
            }

           else if (emp.salaireFixe <= 300000)
            {
                emp.taxe = emp.salaireFixe * 0.03m;
                emp.salaireFixe = emp.salaireFixe - emp.taxe;

                Console.WriteLine("LA TAXE DE 3% A ETE RETIRER SUR LE SALAIRE.");
                Console.WriteLine("  ");
            }


            else
            {
                emp.taxe = emp.salaireFixe * 0.04m; 
                emp.salaireFixe -= emp.taxe; // Retrait de la taxe du salaire

                Console.WriteLine("LA TAXE DE 4% A ETE RETIRER SUR LE SALAIRE.");
                Console.WriteLine("  ");
            }
            emp.salaireNet = emp.salaireFixe;

            Console.WriteLine($"LE SALAIRE {emp.prenommEmploye} {emp.nomEmploye} EST: ");

            Console.WriteLine($"LE SALAIRE NET: {emp.salaireNet} ");
        }
    }
}
