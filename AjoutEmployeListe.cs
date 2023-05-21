using System;
using System.Collections.Generic;
using static projetFinal.AjouterEmploye;

namespace projetFinal
{
    public class AjoutEmployeListe
    {
        public static void ajouterEmployeListe(List<Employe> listeEmployes)
        {
            // DEMANDER A L'UTILISATEUR LE NOMBRE D'EMPLOYE QU'IL SOUHAITE INSERER
            Console.Write("COMBIEN D'EMPLOYES VOULEZ-VOUS AJOUTER ? ");
            int nombreEmployes;
            while (!int.TryParse(Console.ReadLine(), out nombreEmployes) || nombreEmployes < 0)
            {
                Console.WriteLine("ENTRER UN NOMBRE D'EMPLOYES VALIDE !");
                Console.Write("COMBIEN D'EMPLOYES VOULEZ-VOUS AJOUTER ? ");
            }

            for (int i = 0; i < nombreEmployes; i++)
            {
                Employe nouvelEmploye = ajouterEmploye();
                listeEmployes.Add(nouvelEmploye);
                Console.WriteLine("EMPLOYE AJOUTE AVEC SUCCES !");
            }
        }
    }
}
