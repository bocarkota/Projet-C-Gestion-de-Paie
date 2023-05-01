using paie;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Paie.Models
{
    internal class Employe
    {

         private string nom;
        private string prenom;
        private DateTime dateEmbauche1;
        private string grade;
        private double salaireHoraire;
        private double assiduite;

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
        public string Nom { get; set; }
        public string Prenom { get;  set; }
        public DateTime DateEmbauche { get; set; }
        public string Grade { get; set; }
      //  public decimal SalaireHoraire { get;  set; }
        public decimal SalaireTotal = 0;
        public double Assiduite { get; internal set; }

        public Employe(int id,string nom, string prenom, DateOnly dateN, string adresse,DateOnly dateE,int nbrHeureT,bool assiduite,
            string grade,decimal salaireBase)
        {
            ID_Employe = id;
            nomEmploye = nom ;
            prenomEmploye = prenom ;
            dateNaissance = dateN ;
            adresseEmploye = adresse ;
            dateEmbauche = dateE ;
            nbrHeureTravail = nbrHeureT ;
            assiduiteEmploye = assiduite ;
            gradeEmploye = grade ;
            salaireBaseEmploye = salaireBase ;
        }



       

     
        public override string ToString()
        {
            return $"ID: {ID_Employe} \nNOM: {nomEmploye} \nPRENOM: {prenomEmploye} \nDATE DE NAISSANCE: {dateNaissance} \nADRESSE: {adresseEmploye} \nDATE D'EMBAUCHE: {dateEmbauche} \n" +
$"NOMBRE DE DE TRAVAIL: {nbrHeureTravail} HEURE(S) \nASSIDUITE: {assiduiteEmploye} \nGRADE: {gradeEmploye} \nSALAIRE DE BASE: {salaireBaseEmploye} FCFA \n";
        }
    }
    }

