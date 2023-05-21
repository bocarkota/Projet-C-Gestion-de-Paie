using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static projetFinal.ControleSaisie;

namespace projetFinal
{
    public class AjouterEmploye
    {

        //private static int dernierId = 0;
        public static  Employe ajouterEmploye()
        {

            int id=0;
            string nom = String.Empty;
            string prenom = String.Empty;
            string adresse = String.Empty;
            DateOnly dateN;
            DateOnly dateE;
            double nbrHeureT = Double.MaxValue;




            // ENTRER LE NOM DE L'EMPLOYE
            do
            {
                Console.Write("ENTRER LE NOM DE L'EMPLOYE : ");
                nom = Console.ReadLine();

                if (!controleSaisie(nom))
                {
                    Console.WriteLine("VEUILLEZ ENTRER UN NOM VALIDE SVP !");
                }

            } while (!controleSaisie(nom) || String.IsNullOrEmpty(nom));


            // ENTRER LE PRENOM DE L'EMPLOYE
            do
            {
                Console.Write("ENTRER LE PRENOM DE L'EMPLOYE: ");
              
                    prenom = Console.ReadLine();
                
                if(!controleSaisie(prenom))
                {
                    Console.WriteLine("VEUILLEZ ENTRER UN PRENOM VALIDE SVP !");

                }

            } while (!controleSaisie(prenom) || String.IsNullOrEmpty(prenom));

            // ENTRER LA DATE DE NAISSANCE DE L'EMPLOYE
            do
            {
                Console.Write("ENTRER LA DATE DE NAISSANCE DE L'EMPLOYE (FORMAT JJ/MM/AAAA) : ");
                Console.WriteLine("L'EMPLOYE DOIT AVOIR PLUS DE 18 ANS ");
                try
                {
                    dateN = DateOnly.Parse(Console.ReadLine());

                }
                catch
                {
                    Console.WriteLine("ENTRER UNE DATE VALIDE !");
                }
            }
            while (DateOnly.FromDateTime(DateTime.Now).Year - dateN.Year < 18);

            //ENTRER L'ADRESSE DE L'EMPLOYE
            do 
            {
                Console.Write("ENTRER L'ADRESSE DE L'EMPLOYE : ");
                try
                {
                    adresse = Console.ReadLine();

                }
                catch
                {
                    Console.WriteLine("ENTRER UNE ADRESSE VALIDE !");
                }
            }
            while (String.IsNullOrEmpty(adresse));

            //ENTRER LA DATE D'EMBAUCHE DE L'EMPLOYE

                Console.Write("ENTRER LA DATE D'EMBAUCHE DE L'EMPLOYE (FORMAT JJ/MM/AAAA) : ");
                try
                {
                    dateE = DateOnly.Parse(Console.ReadLine());

                }
                catch
                {
                    Console.WriteLine("UNE DATE VALIDE SVP !");
                }
            
           
           


            //ENTRER LE NOMBRE D'HEURE EFFECTUE PAR L'EMPLOYE
            do
            {
                Console.Write("ENTRER LE NOMBRE D'HEURE(S) EFFECTUE(S) PAR L'EMPLOYE : ");
                try
                {
                    nbrHeureT = Convert.ToDouble(Console.ReadLine());
                }
                catch
                {
                    Console.WriteLine("ENTRER UNE HEURE SUPERIEURE A {0}");
                }
            }
            while (nbrHeureT < 0);



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

            Employe nouvelEmploye = new Employe(id, nom, prenom, dateN, adresse, dateE, nbrHeureT, assiduite, grade, salaireBase);
            return nouvelEmploye;
        }

    }
}
