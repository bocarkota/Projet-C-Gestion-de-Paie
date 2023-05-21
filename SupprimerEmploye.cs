using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projetFinal
{
    public class SupprimerEmploye
    {
        public static void supprimerEmploye(List<Employe> listeEmployes)
        {
            Console.Write("ENTRER L'ID DE L'EMPLOYE QUE VOUS SOUHAITEZ SUPPRIMER : ");
            int id;
            while (!int.TryParse(Console.ReadLine(), out id))
            {
                Console.WriteLine("ENTRER UN ID D'EMPLOYE VALIDE !");
                Console.Write("ENTRER L'ID DE L'EMPLOYE QUE VOUS SOUHAITEZ SUPPRIMER : ");
            }

            Employe employeASupprimer = listeEmployes.FirstOrDefault(e => e.ID_Employe == id);
            if (employeASupprimer == null)
            {
                Console.WriteLine("AUCUN EMPLOYE NE CORRESPOND A CET ID.");
                return;
            }

            listeEmployes.Remove(employeASupprimer);

            Console.WriteLine($"L'EMPLOYE {employeASupprimer.nomEmploye} {employeASupprimer.prenommEmploye} A ETE SUPPRIME AVEC SUCCES !");
        }
    }
}
