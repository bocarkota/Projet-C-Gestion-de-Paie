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
        public DateOnly dateNaissanceEmploye { get; set; }
        public string adresseEmploye { get; set; }
        public DateOnly dateEmbaucheEmploye { get; set; }
        public int nbrHeureTravail { get; set; }
        public bool assiduiteEmploye { get; set; }
        public string gradeEmploye { get; set; }
        public decimal salaireHeureEmploye { get; set; }


        public decimal salaireFixe { get; set; }
        public decimal prime { get; set; }
        public decimal taxe { get; set; }

        public decimal salaireNet { get; set; }



        public Employe(int id,string nom, string prenom, DateOnly dateN, string adresse, DateOnly dateE, int nbrHeureT, bool assiduite, string grade, decimal salaireHeure)
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
            this.salaireHeureEmploye = salaireHeure;
            
            this.ID_Employe = GetNextEmployeeId();
        }

        public Employe(decimal salaire_fixe, decimal prime, decimal taxe, decimal salaireNet)
        {
            this.salaireFixe = salaireFixe;
            this.prime = prime;
            this.taxe = taxe;
            this.salaireNet = salaireNet;


        }

        private static int IdEmployeSuivant = 0;
        private static int GetNextEmployeeId() => ++IdEmployeSuivant;

       

    }
}
