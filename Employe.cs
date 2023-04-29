using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projetFinal
{
    public class Employe
    {
        public int ID_Employe { get; set; }
        public string nomEmploye { get; set; }
        public string prenommEmploye { get; set; }
        public DateTime dateNaissanceEmploye { get; set; }
        public string adresseEmploye { get; set; }
        public DateTime dateEmbaucheEmploye { get; set; }
        public double nbrHeureTravail { get; set; }
        public bool assiduiteEmploye { get; set; }
        public string gradeEmploye { get; set; }
        public decimal salaireBaseEmploye { get; set; }

        public Employe(int id,string nom, string prenom, DateTime dateN, string adresse, DateTime dateE, double nbrHeureT, bool assiduite, string grade, decimal salaireBase)
        {
            this.ID_Employe = id;
            this.nomEmploye = nom;
            this.prenommEmploye = prenom;
            this.dateNaissanceEmploye = dateN;
            this.adresseEmploye = adresse;
            this.dateEmbaucheEmploye = dateE;
            this.nbrHeureTravail = nbrHeureT;
            this.assiduiteEmploye = assiduite;
            this.gradeEmploye = grade;
            this.salaireBaseEmploye = salaireBase;
            
            this.ID_Employe = GetNextEmployeeId();
        }

        private static int nextEmployeeId = 1;
        private static int GetNextEmployeeId() => ++nextEmployeeId;



        public static Employe AjouterEmploye()
        {
            Console.Write("ENTRER ID DE L'EMPLOYE: ");
            int id = int.Parse(Console.ReadLine());

            Console.Write("ENTRER LE NOM DE L'EMPLOYE : ");
            string nom = Console.ReadLine();

            Console.Write("ENTRER LE PRENOM DE L'EMPLOYE: ");
            string prenom = Console.ReadLine();

            Console.Write("ENTRER LA DATE DE NAISSANCE DE L'EMPLOYE (FORMAT JJ/MM/AAAA) : ");
            DateTime dateN;
            while (!DateTime.TryParse(Console.ReadLine(), out dateN))
            {
                Console.Write("DATE INVALIDE, VEUILLEZ REESAYER : ");
            }

            Console.Write("ENTRER L'ADRESSE DE L'EMPLOYE : ");
            string adresse = Console.ReadLine();

            Console.Write("ENTRER LA DATE D'EMBAUCHE DE L'EMPLOYE (FORMAT JJ/MM/AAAA) : ");
            DateTime dateE;
            while (!DateTime.TryParse(Console.ReadLine(), out dateE))
            {
                Console.Write("DATE INVALIDE, VEUILLEZ REESAYER : ");
            }

            Console.Write("ENTRER LE NOMBRE D'HEURE(S) EFFECTUE(S) PAR L'EMPLOYE : ");
            double nbrHeureT;
            while (!double.TryParse(Console.ReadLine(), out nbrHeureT))
            {
                Console.Write("NOMBRE INVALIDE, VEUILLEZ REESAYER: ");
            }

            Console.Write("L'EMPLOYE EST-IL ASSIDUT ?: ");
            bool assiduite = Console.ReadLine().Equals("Oui", StringComparison.OrdinalIgnoreCase);

            Console.Write("ENTRER LE GRADE DE L'EMPLOYE : ");
            string grade = Console.ReadLine();

            Console.Write("ENTRER LE SALAIRE DE BASE DE L'EMPLOYE  : ");
            decimal salaireBase;
            while (!decimal.TryParse(Console.ReadLine(), out salaireBase))
            {
                Console.Write("NOMBRE INVALIDE, VEUILLEZ REESAYER : ");
            }

            Employe nouvelEmploye = new Employe(id,nom, prenom, dateN, adresse, dateE, nbrHeureT, assiduite, grade, salaireBase);
            return nouvelEmploye;
        }


        public static void ModifierEmploye(List<Employe> listeEmployes)
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

            Console.Write("ENTRER LE NOUVEAU NOM DE L'EMPLOYE : ");
            string nouveauNom = Console.ReadLine();
            employeAModifier.nomEmploye = nouveauNom;

            Console.Write("ENTRER LE NOUVEAU PRENOM DE L'EMPLOYE: ");
            string nouveauPrenom = Console.ReadLine();
            employeAModifier.prenommEmploye = nouveauPrenom;

            Console.Write("ENTRER LA NOUVELLE DATE DE NAISSANCE DE L'EMPLOYE (FORMAT JJ/MM/AAAA) : ");
            DateTime nouvelleDateNaissance;
            while (!DateTime.TryParse(Console.ReadLine(), out nouvelleDateNaissance))
            {
                Console.Write("DATE INVALIDE, VEUILLEZ REESAYER : ");
            }
            employeAModifier.dateNaissanceEmploye = nouvelleDateNaissance;

            Console.Write("ENTRER LA NOUVELLE ADRESSE DE L'EMPLOYE : ");
            string nouvelleAdresse = Console.ReadLine();
            employeAModifier.adresseEmploye = nouvelleAdresse;

            Console.Write("ENTRER LA NOUVELLE DATE D4EMBAUCHE DE L'EMPLOYE (FORMAT JJ/MM/AAAA) : ");
            DateTime nouvelleDateEmbauche;
            while (!DateTime.TryParse(Console.ReadLine(), out nouvelleDateEmbauche))
            {
                Console.Write("DATE INVALIDE, VEUILLEZ REESAYER : ");
            }
            employeAModifier.dateEmbaucheEmploye = nouvelleDateEmbauche;

            Console.Write("ENTRER LE NOUVEAU NOMBRE D'HEURE EFFECTUEES PAR L'EMPLOYE : ");
            double nouveauNbrHeureT;
            while (!double.TryParse(Console.ReadLine(), out nouveauNbrHeureT))
            {
                Console.Write("NOMBRE INVALIDE, VEUILLEZ REESAYER: ");
            }
            employeAModifier.nbrHeureTravail = nouveauNbrHeureT;

            Console.Write("L'EMPLOYE EST-IL ASSIDUT ? (Oui/Non) : ");
            bool nouvelleAssiduite = Console.ReadLine().Equals("Oui", StringComparison.OrdinalIgnoreCase);
            employeAModifier.assiduiteEmploye = nouvelleAssiduite;

            Console.Write("ENTRER LE NOUVEAU GRADE DE L'EMPLOYE : ");
            string nouveauGrade = Console.ReadLine();
            employeAModifier.gradeEmploye = nouveauGrade;

            Console.Write("ENTRER LE NOUVEAU SALAIRE DE BASE DE L'EMPLOYE : ");
            decimal nouveauSalaireBase;
            while (!decimal.TryParse(Console.ReadLine(), out nouveauSalaireBase))
            {
                Console.Write("NOMBRE INVALIDE, VEUILLEZ REESAYER : ");
            }
            employeAModifier.salaireBaseEmploye = nouveauSalaireBase;

            Console.WriteLine("L'EMPLOYE A ETE MODIFIE AVEC SUCCES !.");
        }


        public static void SupprimerEmploye(List<Employe> listeEmployes)
        {
            Console.Write("ENTRER L'ID DE L'EMPLOYE QUE VOUS SOUHAITE SUPPRIMER : ");
            int id = int.Parse(Console.ReadLine());

            Employe employeASupprimer = listeEmployes.FirstOrDefault(e => e.ID_Employe == id);
            if (employeASupprimer == null)
            {
                Console.WriteLine("AUCUN EMPLOYE NE CORRESPOND A CET ID.");
                return;
            }

            listeEmployes.Remove(employeASupprimer);

            Console.WriteLine($"L'EMPLOYE {employeASupprimer.nomEmploye} {employeASupprimer.prenommEmploye} A ETE SUPPRIME AVEC SUCCES !");
        }


        public static void afficheEmploye(List<Employe> listeEmployes)
        {
            Console.WriteLine("LA LISTES DE TOUS LES EMPLOYES :");
            foreach (Employe employe in listeEmployes)
            {
                Console.WriteLine($"ID : {employe.ID_Employe}, NOM : {employe.nomEmploye}, PRENOM : {employe.prenommEmploye}, DATE DE NAISSANCE : {employe.dateNaissanceEmploye.ToShortDateString()}, ADRESSE : {employe.adresseEmploye},DATE D'EMBAUCHE : {employe.dateEmbaucheEmploye.ToShortDateString()}, NOMBRES D'HEURES TRAVAILLES : {employe.nbrHeureTravail}, ASSIDUITE : {(employe.assiduiteEmploye ? "OUI" : "NON")}, GRADE : {employe.gradeEmploye}, SALAIRE DE BASE : {employe.salaireBaseEmploye}");
            }
        }

    }
}
