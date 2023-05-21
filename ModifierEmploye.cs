using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static projetFinal.ControleSaisie;

namespace projetFinal
{
    public class ModifierEmploye
    {

        public static void modifierEmploye(List<Employe> listeEmployes)
        {
            Console.Write("ENTRER L'ID DE L'EMPLOYE QUE VOUS SOUHAITEZ MODIFIER : ");
            int id = int.Parse(Console.ReadLine());

            Employe employeAModifier = listeEmployes.FirstOrDefault(e => e.ID_Employe == id);
            if (employeAModifier == null)
            {
                Console.WriteLine("AUCUN N'EMPLOYE NE CORESPOND A CET IDENTIFIANT.");
                return;
            }

            Console.WriteLine($"EMPLOYE TROUVE : {employeAModifier.nomEmploye} {employeAModifier.prenommEmploye}");

            //ToDo : NE PAS OUBLIER DE FAIRE LE CONTROLE DE SAISIE POUR TOUS LES CHAMPS DANS CETTE CLASSE

            // ENTRER LE NOUVEAU NOM DE L'EMPLOYE
            Console.Write("ENTRER LE NOUVEAU NOM DE L'EMPLOYE : ");
            string nouveauNom = Console.ReadLine();

            while (!controleSaisie(nouveauNom) || String.IsNullOrEmpty(nouveauNom))
            {
                Console.WriteLine("VEUILLEZ ENTRER UN NOUVEAU NOM VALIDE SVP !");
                Console.Write("ENTRER LE NOUVEAU NOM DE L'EMPLOYE : ");
                nouveauNom = Console.ReadLine();
            }

            employeAModifier.nomEmploye = nouveauNom;



            // ENTRER LE NOUVEAU PRENOM DE L'EMPLOYE
            Console.Write("ENTRER LE NOUVEAU PRENOM DE L'EMPLOYE: ");
            string nouveauPrenom = Console.ReadLine();

            while (!controleSaisie(nouveauPrenom) || String.IsNullOrEmpty(nouveauPrenom))
            {
                Console.WriteLine("VEUILLEZ ENTRER UN NOUVEAU PRENOM VALIDE SVP !");
                Console.Write(" ENTRER LE NOUVEAU PRENOM DE L'EMPLOYE :");
                nouveauPrenom = Console.ReadLine();

            }
            employeAModifier.prenommEmploye = nouveauPrenom;

            // ENTRER LA NOUVELLE DATE DE NAISSANCE

            Console.Write("ENTRER LA NOUVELLE DATE DE NAISSANCE DE L'EMPLOYE (FORMAT JJ/MM/AAAA) : ");
            DateOnly nouvelleDateNaissance;
            while (!DateOnly.TryParse(Console.ReadLine(), out nouvelleDateNaissance))
            {
                Console.Write("DATE INVALIDE, VEUILLEZ REESAYER : ");
            }
            employeAModifier.dateNaissanceEmploye = nouvelleDateNaissance;

            // ENTRER LA NOUVELLE ADRESSE DE L'EMPLOYE

            Console.Write("ENTRER LA NOUVELLE ADRESSE DE L'EMPLOYE : ");
            string nouvelleAdresse = Console.ReadLine();
            employeAModifier.adresseEmploye = nouvelleAdresse;

            // ENTRER LA NOUVELLE DATE D'EMBAUCHE DE L'EMPLOYE

            Console.Write("ENTRER LA NOUVELLE DATE D'EMBAUCHE DE L'EMPLOYE (FORMAT JJ/MM/AAAA) : ");
            DateOnly nouvelleDateEmbauche;
            while (!DateOnly.TryParse(Console.ReadLine(), out nouvelleDateEmbauche))
            {
                Console.Write("DATE INVALIDE, VEUILLEZ REESAYER : ");
            }
            employeAModifier.dateEmbaucheEmploye = nouvelleDateEmbauche;

            // ENTRER LE NOUVEAU NOMBRE D'HEURE EFFECTUE PAR L'EMPLOYE

            Console.Write("ENTRER LE NOUVEAU NOMBRE D'HEURE EFFECTUEES PAR L'EMPLOYE : ");
            double nouveauNbrHeureT;
            while (!double.TryParse(Console.ReadLine(), out nouveauNbrHeureT))
            {
                Console.Write("NOMBRE INVALIDE, VEUILLEZ REESAYER: ");
            }
            employeAModifier.nbrHeureTravail = nouveauNbrHeureT;

            // ENTRER LA NOUVELLE ASSIDUITE DE L'EMPLOYE

            Console.Write("L'EMPLOYE EST-IL ASSIDUT ? (Oui/Non) : ");
            bool nouvelleAssiduite = Console.ReadLine().Equals("Oui", StringComparison.OrdinalIgnoreCase);
            employeAModifier.assiduiteEmploye = nouvelleAssiduite;

            // E?TRER LE NOUVEAU GRADE DE L'EMPLOYE

            Console.Write("ENTRER LE NOUVEAU GRADE DE L'EMPLOYE : ");
            string nouveauGrade = Console.ReadLine();
            employeAModifier.gradeEmploye = nouveauGrade;

            // ENTRER LE NOUVEAU SALAIRE DE L'EMPLOYE

            Console.Write("ENTRER LE NOUVEAU SALAIRE DE BASE DE L'EMPLOYE : ");
            decimal nouveauSalaireBase;
            while (!decimal.TryParse(Console.ReadLine(), out nouveauSalaireBase))
            {
                Console.Write("NOMBRE INVALIDE, VEUILLEZ REESAYER : ");
            }
            employeAModifier.salaireBaseEmploye = nouveauSalaireBase;

            Console.WriteLine("L'EMPLOYE A ETE MODIFIE AVEC SUCCES !.");
        }
    }
}
