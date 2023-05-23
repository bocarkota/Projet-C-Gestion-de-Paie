using System;
using System.Collections.Generic;
using System.Linq;

namespace projetFinal
{
    public class ListePaiement
    {
        public static void AfficherListeFichePaiement(List<Employe> listeEmployes)
        {

            //AFFICHER LA LISTE DES FICHES DE PAIEMENT DE CHAQUE EMPLOYE


            Console.WriteLine("LISTE DES FICHES DE PAIEMENT");
            Console.WriteLine("-------------------------");

            foreach (Employe emp in listeEmployes)
            {
                Console.WriteLine($"ID : {emp.ID_Employe}");
                Console.WriteLine($"NOM ET PRENOM : {emp.prenommEmploye} {emp.nomEmploye}");
                Console.WriteLine($"Fonction : {emp.gradeEmploye}");
                Console.WriteLine($"ASSIDUITE : {(emp.assiduiteEmploye ? "OUI" : "NON")}");
                Console.WriteLine($"DATE DE PAIEMENT : {DateTime.Now}");
                Console.WriteLine("-------------------------");
                emp.salaireFixe = emp.salaireHeureEmploye * emp.nbrHeureTravail;
                Console.WriteLine($"SALAIRE BRUT : {emp.salaireFixe}");
                Console.WriteLine($"PRIME : {emp.prime}");
                Console.WriteLine($"TAXE: {emp.taxe}");
                Console.WriteLine($"SALAIRE NET : {emp.salaireNet}");
                Console.WriteLine();
            }
        }
    }
}
