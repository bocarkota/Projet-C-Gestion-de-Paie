using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projetFinal
{
    public class RechercherEmploye
    {

        public static void recherche_employe(List<Employe> listeEmployes)
        {
            Console.Write("ENTRER L'ID DE L'EMPLOYE QUE VOUS RECHERCHEZ : ");
            int id = int.Parse(Console.ReadLine());

            Employe employeARechercher = listeEmployes.FirstOrDefault(e => e.ID_Employe == id);
            if (employeARechercher == null)
            {
                Console.WriteLine("AUCUN N'EMPLOYE NE CORESPOND A CET IDENTIFIANT.");
                return;
            }

            Console.WriteLine($"INFORMATIONS DE L'EMPLOYE {employeARechercher.nomEmploye} {employeARechercher.prenommEmploye} :");
            Console.WriteLine();
            Console.WriteLine($"ID : {employeARechercher.ID_Employe}");
            Console.WriteLine($"NOM : {employeARechercher.nomEmploye}");
            Console.WriteLine($"PRENOM : {employeARechercher.prenommEmploye}");
            Console.WriteLine($"DATE DE NAISSANCE : {employeARechercher.dateNaissanceEmploye.ToShortDateString()}");
            Console.WriteLine($"ADRESSE : {employeARechercher.adresseEmploye}");
            Console.WriteLine($"DATE D'EMBAUCHE : {employeARechercher.dateEmbaucheEmploye.ToShortDateString()}");
            Console.WriteLine($"NOMBRES D'HEURES TRAVAILLES : {employeARechercher.nbrHeureTravail} Heure(s)");
            Console.WriteLine($"ASSIDUITE : {(employeARechercher.assiduiteEmploye ? "OUI" : "NON")}");
            Console.WriteLine($"GRADE : {employeARechercher.gradeEmploye}");
            Console.WriteLine($"SALAIRE PAR HEURE  : {employeARechercher.salaireHeureEmploye} FCFA");
            Console.WriteLine();
        }
    }
}
