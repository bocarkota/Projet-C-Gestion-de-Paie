using System;

namespace projetFinal
{
	public class AfficherFichePayement
	{
		public static void AfficherFichePayement(Employe employe)
		{
			Console.WriteLine("FICHE DE PAIEMENT");
			Console.WriteLine("=================");
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

			double salaireTotal = employe.nbrHeureTravail * employe.salaireHeureEmploye;
			Console.WriteLine($"SALAIRE TOTAL : {salaireTotal} FCFA");
			Console.WriteLine("=================");
		}
	}
}
