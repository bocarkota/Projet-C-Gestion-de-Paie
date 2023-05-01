using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Paie.Models
{
    internal class GestionEmploye
    {
        List<Employe> employees = new List<Employe>();
        public decimal salaire;




        public void AjouterEmploye()
        {
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
        }



        public void ModifierEmploye()
        {
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
        }

        public void RetirerEmploye()
        {
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
        }

        public void AfficherEmploye()
        {
            Console.WriteLine("\nLA LISTE DES EMPLOYES:");
            foreach (Employe employee in employees)
            {
                Console.WriteLine(employee);
            }
        }



        public void CalculerSalaireEmploye()
        {
            decimal prime;
            decimal taxe;
            Console.WriteLine("Entrez l'identifiant de l'employé  :");

            int id;

            if (!int.TryParse(Console.ReadLine(), out id))
            {
                Console.WriteLine("L'identifiant doit être un nombre entier.");
                return;
            }

            Employe employe = employees.Find(employe => employe.ID_Employe == id);
            if (employe != null)
            {

                decimal salaireDeBase = employe.salaireBaseEmploye * employe.nbrHeureTravail;

                // Calcul du bonus en fonction de l'assiduité de l'employé


                if (employe.assiduiteEmploye)
                {
                    prime = salaireDeBase * 0.05m;  //"m" suffixe qui indique que la valeur  est de type décimal
                }
                else
                {
                    prime = 0;
                }


                // Calcul du salaire net
                decimal salaireNet = salaireDeBase + prime;


                if (salaireNet < 200000)
                {
                    taxe = salaireNet * 0.02m;
                }
                else
                {
                    taxe = salaireNet * 0.03m;
                }

                employe.SalaireTotal = salaireNet - taxe;
                salaire = employe.SalaireTotal;

                Console.WriteLine($"LE SALAIRE NET DE {employe.prenomEmploye} {employe.nomEmploye} EST {employe.SalaireTotal}.");


            }
            else
            {
                Console.WriteLine("L'employé n'a pas été trouvé.");
            }

        }

        public void fiche_paie()
        {

            
            AfficherEmploye();
            Console.WriteLine("SALAIRE:");
            Console.WriteLine(salaire);
        }


     
    }
}

        
