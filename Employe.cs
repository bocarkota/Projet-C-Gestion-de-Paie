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
        public double nbrHeureTravail { get; set; }
        public bool assiduiteEmploye { get; set; }
        public string gradeEmploye { get; set; }
        public decimal salaireBaseEmploye { get; set; }

        public Employe(int id,string nom, string prenom, DateOnly dateN, string adresse, DateOnly dateE, double nbrHeureT, bool assiduite, string grade, decimal salaireBase)
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

        private static int IdEmployeSuivant = 0;
        private static int GetNextEmployeeId() => ++IdEmployeSuivant;

       

    }
}
