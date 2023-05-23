using System;

namespace projetFinal
{
    public class ModifierFichePayement
    {
        public static void ModifierFichePayement(Employe employe)
        {
            Console.WriteLine("MODIFIER LA FICHE DE PAIEMENT");
            Console.WriteLine("============================");
            Console.WriteLine($"ID : {employe.ID_Employe}");
            Console.WriteLine($"NOM : {employe.nomEmploye}");
            Console.WriteLine($"PRENOM : {employe.prenommEmploye}");
            Console.WriteLine($"DATE DE NAISSANCE : {employe.dateNaissanceEmploye.ToShortDateString()}");
            Console.WriteLine($"ADRESSE : {employe.adresseEmploye}");
            Console.WriteLine($"DATE D'EMBAUCHE : {employe.dateEmbaucheEmploye.ToShortDateString()}");
            Console.WriteLine($"NOMBRES D'HEURES TRAVAILLES : {employe.nbrHeureTravail} Heure(s)");
            Console.WriteLine($"ASSIDUITE : {(employe.assiduiteEmploye ? "OUI" : "NON")}");
            Console.WriteLine($"GRADE : {employe.gradeEmploye}");
            Console.WriteLine($"SALAIRE PAR HEURE: {employe.salaireHeureEmploye} FCFA");

            Console.WriteLine("\nEntrez les nouvelles informations :");
            Console.Write("NOMBRES D'HEURES TRAVAILLES : ");
            employe.nbrHeureTravail = Convert.ToInt32(Console.ReadLine());
            Console.Write("ASSIDUITE (OUI/NON) : ");
            string assiduite = Console.ReadLine();
            employe.assiduiteEmploye = (assiduite.ToUpper() == "OUI");
            Console.Write("GRADE : ");
            employe.gradeEmploye = Console.ReadLine();
            Console.Write("SALAIRE PAR HEURE : ");
            employe.salaireHeureEmploye = Convert.ToDouble(Console.ReadLine());

            double salaireTotal = employe.nbrHeureTravail * employe.salaireHeureEmploye;
            Console.WriteLine($"\nNOUVEAU SALAIRE TOTAL : {salaireTotal} FCFA");

            Console.WriteLine("============================");
        }
    }
}
