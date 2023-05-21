using projetFinal;

public class AfficherEmploye
{
    public static void afficheEmploye(List<Employe> listeEmployes)
    {
        Console.WriteLine("LA LISTE DE TOUS LES EMPLOYES :");

        foreach (Employe employe in listeEmployes)
        {
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
            Console.WriteLine();
        }
    }
}
