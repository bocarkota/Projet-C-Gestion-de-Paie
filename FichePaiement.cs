using System;
using System.Collections.Generic;
using System.Linq;

namespace projetFinal
{
    public class FichePaiement

    {

       
        public static void AfficherFichePaiement(List<Employe> listeEmployes)
        {
            //AFFICHE LE BULLETIN DE SALAIRE DE L EMPLOYE CHOISI


            Console.Write("ENTRER L'ID DE L'EMPLOYE DONT VOUS SOUHAITEZ RETIRER LE BULETIN DE SALAIRE : ");
            int id = int.Parse(Console.ReadLine());

            Employe emp = listeEmployes.FirstOrDefault(e => e.ID_Employe == id);
            if (emp == null)
            {
                Console.WriteLine("AUCUN N'EMPLOYE NE CORESPOND A CET IDENTIFIANT.");
                return;
            }


            Console.WriteLine("FICHE DE PAIEMENT");
            Console.WriteLine("-------------------------");
            Console.WriteLine($"ID : {emp.ID_Employe}");
            Console.WriteLine($"NOM ET PRENOM : {emp.prenommEmploye} {emp.nomEmploye}");
            Console.WriteLine($"Fonction : {emp.gradeEmploye}");
            Console.WriteLine($"ASSIDUITE : {(emp.assiduiteEmploye ? "OUI" : "NON")}");
            Console.WriteLine($"DATE DE PAIEMENT : {DateTime.Now}");
            Console.WriteLine("-------------------------");
             emp.salaireFixe= emp.salaireHeureEmploye * emp.nbrHeureTravail;
            Console.WriteLine($"SALAIRE BRUT : {emp.salaireFixe}");
            Console.WriteLine($"PRIME : {emp.prime}");
            Console.WriteLine($"TAXE: {emp.taxe}");

            Console.WriteLine($"SALAIRE NET : {emp.salaireNet}");

            
        }
    }
}
