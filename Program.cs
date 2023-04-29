using System;
using System.Collections.Generic;
using System.Diagnostics.Metrics;
using System.Net;
using System.Threading.Channels;
using System.Xml.Linq;

namespace EmployeeDatabase
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Employe> employees = new List<Employe>();

            while (true)
            {
                Console.WriteLine(" ENTRER VOTRE CHOIX");
                Console.WriteLine("1. AJOUTER UN EMPLOYE");
                Console.WriteLine("2. MODIFIER UN EMPLOYE");
                Console.WriteLine("3. SUPPRIMER UN EMPLOYE");
                Console.WriteLine("4. AFFICHER TOUS LES EMPLOYES");
                Console.WriteLine("5. CALCUL DU SALAIRE DE L'EMPLOYE ");
                Console.WriteLine("6. QUITTER");

                int choix = int.Parse(Console.ReadLine());

                switch (choix)
                {
                    case 1:


                        Console.Write("ID: ");
                        int id = int.Parse(Console.ReadLine());

                        Console.Write("NOM: ");
                        string nom = Console.ReadLine();

                        /*if (!nom.All(char.IsLetter))
                        {
                            Console.WriteLine("LA VALEUR ENTRER N'EST PAS UNE CHAINE DE CARACTERE!.");
                            return;
                        }*/

                        Console.Write("PRENOM: ");
                        string prenom = Console.ReadLine();

                        /*if (!prenom.All(char.IsLetter))
                        {
                            Console.WriteLine("LA VALEUR ENTRER N'EST PAS UNE CHAINE DE CARACTERE!.");
                            return;
                        }*/

                        Console.Write("DATE DE NAISSANCE: ");
                        DateOnly dateN = DateOnly.Parse(Console.ReadLine());

                        Console.Write("ADRESSE: ");
                        string adresse = Console.ReadLine();

                        Console.Write("DATE D'EMBAUCHE: ");
                        DateOnly dateE = DateOnly.Parse(Console.ReadLine());

                        Console.Write("NOMBRE D'HEURE TRAVAILLE: ");
                        int nbrHeureT = int.Parse(Console.ReadLine());

                        Console.Write("ASSIDUITE: ");
                        bool assiduite = bool.Parse(Console.ReadLine());

                        Console.Write("GRADE: ");
                        string grade = Console.ReadLine();

                        Console.Write("SON SALAIRE DE BASE: ");
                        decimal salaireBase = decimal.Parse(Console.ReadLine());


                        employees.Add(new Employe(id, nom, prenom, dateN, adresse, dateE, nbrHeureT, assiduite, grade, salaireBase));
                        Console.WriteLine("\nEMPLOYE AJOUTER AVEC SUCCES!.");
                        break;

                    case 2:
                        Console.Write("ENTRER L'ID DE L'EMPLOYE QUE VOUS SOUHAITER MODIFIER: ");
                        int modifierId = int.Parse(Console.ReadLine());

                        Employe modifierEmployee = employees.Find(employee => employee.ID_Employe == modifierId);

                        if (modifierEmployee != null)
                        {
                            Console.Write("ENTRER LE NOUVEAU ID DE L'EMPLOYE: ");
                            int modifyId = int.Parse(Console.ReadLine());
                            modifierEmployee.ID_Employe = modifyId;

                            Console.Write("ENTRER LE NOUVEAU NOM DE L'EMPLOYE: ");
                            string modifierNom = Console.ReadLine();
                            modifierEmployee.nomEmploye = modifierNom;

                            Console.Write("ENTRER LE NOUVEAU PRENOM DE L'EMPLOYE: ");
                            string modifierPrenom = Console.ReadLine();
                            modifierEmployee.prenomEmploye = modifierPrenom;


                            Console.Write("ENTRER LA NOUVELLE DATE DE NAISSANCE DE L'EMPLOYE: ");
                            DateOnly modifierDateN = DateOnly.Parse(Console.ReadLine());
                            modifierEmployee.dateNaissance = modifierDateN;


                            Console.Write("ENTRER LA NOUVELLE ADRESSE DE L'EMPLOYE: ");
                            string modifierAdresse = Console.ReadLine();
                            modifierEmployee.adresseEmploye = modifierAdresse;


                            Console.Write("ENTRER LA NOUVELLE DATE D'EMBAUCHE DE L'EMPLOYE: ");
                            DateOnly modifierDateE = DateOnly.Parse(Console.ReadLine());
                            modifierEmployee.dateEmbauche = modifierDateE;


                            Console.Write("ENTRER LE NOUVEAU NOMBRE D'HEURE TRAVAILLE PAR L'EMPLOYE: ");
                            int modifierNbrHeureT = int.Parse(Console.ReadLine());
                            modifierEmployee.nbrHeureTravail = modifierNbrHeureT;


                            Console.Write("ENTRER UNE NOUVELLE FOIS L'ASSIDUITE DE L'EMPLOYE: ");
                            bool modifierAssiduite = bool.Parse(Console.ReadLine());
                            modifierEmployee.assiduiteEmploye = modifierAssiduite;


                            Console.Write("ENTRER LE NOUVEAU GRADE DE L'EMPLOYE: ");
                            string modifierGrade = Console.ReadLine();
                            modifierEmployee.gradeEmploye = modifierGrade;

                            Console.Write("ENTRER LE NOUVEAU SALAIRE DE BASE DE L'EMPLOYE: ");
                            decimal modifierSalaireBase = decimal.Parse(Console.ReadLine());
                            modifierEmployee.salaireBaseEmploye = modifierSalaireBase;




                            Console.WriteLine("\nEMPLOYE MODIFIE AVEC SUCCES!.");
                        }
                        else
                        {
                            Console.WriteLine("\nCET EMPLOYE N'EXISTE PAS DANS LA BASE.");
                        }
                        break;

                    case 3:
                        Console.Write("ENTRER L'ID DE L'EMPLOYE QUE VOUS SOUHAITE SUPPRIMER: ");
                        int supprimerId = int.Parse(Console.ReadLine());

                        Employe supprimerEmploye = employees.Find(employee => employee.ID_Employe == supprimerId);

                        if (supprimerEmploye != null)
                        {
                            employees.Remove(supprimerEmploye);
                            Console.WriteLine("\nEMPLOYE SUPPRIMER AVEC SUCCES!.");
                        }
                        else
                        {
                            Console.WriteLine("\nCET EMPLOYE N'EXISTE PAS DANS LA BASE.");
                        }
                        break;

                    case 4:
                        Console.WriteLine("\nLA LISTE DES EMPLOYES:");
                        foreach (Employe employee in employees)
                        {
                            Console.WriteLine(employee);
                        }
                        break;

                    case 5:
                        Console.WriteLine("SALAIRES DES EMPLOYES :");
                        foreach (Employe emp in employees)
                        {
                            decimal salaireTotal = emp.salaireBaseEmploye * emp.nbrHeureTravail;
                            Console.WriteLine($"L'EMPLOYE {emp.nomEmploye} {emp.prenomEmploye} A TRAVAILLE {emp.nbrHeureTravail} HEURE(S) ET A UN SALAIRE TOTAL DE: {salaireTotal} FCFA.");
                        }
                        break;
                    case 6:
                        Environment.Exit(0);
                        break;
                    default:
                        Console.WriteLine("CHOIX INVALIDE. VEUILLEZ REESSAYER.");
                        break;
                }
            }
        }



        class Employe
        {
            public int ID_Employe { get; set; }
            public string nomEmploye { get; set; }
            public string prenomEmploye { get; set; }
            public DateOnly dateNaissance { get; set; }
            public string adresseEmploye { get; set; }
            public DateOnly dateEmbauche { get; set; }
            public int nbrHeureTravail { get; set; }
            public bool assiduiteEmploye { get; set; }
            public string gradeEmploye { get; set; }
            public decimal salaireBaseEmploye { get; set; }

            public Employe(int id, string nom, string prenom, DateOnly dateN, string adresse, DateOnly dateE, int nbrHeureT, bool assiduite,
                string grade, decimal salaireBase)
            {
                ID_Employe = id;
                nomEmploye = nom;
                prenomEmploye = prenom;
                dateNaissance = dateN;
                adresseEmploye = adresse;
                dateEmbauche = dateE;
                nbrHeureTravail = nbrHeureT;
                assiduiteEmploye = assiduite;
                gradeEmploye = grade;
                salaireBaseEmploye = salaireBase;
            }

            public override string ToString()
            {
                return $"ID: {ID_Employe} \nNOM: {nomEmploye} \nPRENOM: {prenomEmploye} \nDATE DE NAISSANCE: {dateNaissance} \nADRESSE: {adresseEmploye} \nDATE D'EMBAUCHE: {dateEmbauche} \n" +
    $"NOMBRE DE DE TRAVAIL: {nbrHeureTravail} HEURE(S) \nASSIDUITE: {assiduiteEmploye} \nGRADE: {gradeEmploye} \nSALAIRE DE BASE: {salaireBaseEmploye} FCFA \n";
            }
        }
    }
}
