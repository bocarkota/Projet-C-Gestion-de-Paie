﻿using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace APP_GESTION_SALAIRE
{
    public class SupprimerInfoPaiement
    {
        //Connexion a la base

        private static string connectionString = "Server=localhost;Database=app_gestion_paie;Uid=simon;Pwd=Simonglain7;";

        public static void supprimer_information_paiement()
        {

            int arret = 0;

            do
            {
                Console.WriteLine("VOULEZ VOUS SUPPRIMER LES INFORMATIONS DE PAIEMENT D'UN EMPLOYE?: ");
                Console.WriteLine("TAPER 1  CONTINUER, 0 POUR QUITTER : ");

                //CONTROLE DE SAISIE
                // toDO : Verifier que les saisies ne comportent pas de caractere speciaux sauf @(seulement accepte dans l'email) et -
                try
                {
                    arret = Convert.ToInt32(Console.ReadLine());
                }
                catch (FormatException ex)
                {
                    Console.WriteLine("SAISIE INCORECTE! VEUILLEZ SAISIR (0) OU (1)!");
                }
            } while (arret != 0 && arret != 1);


            while (arret == 1)
            {

                Console.Write("ENTRER L'ID DE L'EMPLOYE DONT VOUS SOUHAITEZ SUPPRIMER LES INFORMATIONS DE PAIEMENTS : ");
                int id;
                while (!int.TryParse(Console.ReadLine(), out id))
                {
                    Console.WriteLine("ENTRER UN ID D'EMPLOYE VALIDE !");
                    Console.Write("ENTRER L'ID DE L'EMPLOYE : ");
                }

                using (MySqlConnection connection = new MySqlConnection(connectionString))
                {
                    connection.Open();
                    string requete = "delete from paiement where idEmploye = @idEmploye";
                    using (MySqlCommand commande = new MySqlCommand(requete, connection))
                    {

                        commande.Parameters.AddWithValue("@idEmploye", id);


                        int LigneRecu = commande.ExecuteNonQuery();

                        if (LigneRecu > 0)
                        {
                            Console.WriteLine($"LES DONNÉES DE PAIEMENT DE L'EMPLOYÉ AVEC L'IDENTIFIANT {id} ONT ÉTÉ RETIRÉES DE LA BASE DE DONNÉES AVEC SUCCÈS.");
                        }
                        else
                        {
                            string VerifieRequette = "select count(*) from paiement where idEmploye = @idEmploye";
                            using (MySqlCommand VerifieCommande = new MySqlCommand(VerifieRequette, connection))
                            {
                                VerifieCommande.Parameters.AddWithValue("@idEmploye", id);
                                int compter = Convert.ToInt32(VerifieCommande.ExecuteScalar());

                                if (compter == 0)
                                {
                                    Console.WriteLine("LES DONNEES DE PAIEMENT DE L'EMPLOYE N'ONT PAS ETE TROUVE DANS LA BASE DE DONNEE.");
                                }
                                else
                                {
                                    Console.WriteLine("LES DONNEES DE PAIEMENT DE L'EMPLOYE N'ONT PAS PU ETRE RETIRE DE LA BASE DE DONNEE.");
                                } 
                            }
                        }
                    }
                }


                Console.WriteLine("SUPPRIMER LES INFORMATIONS DE PAIEMENT D'UN NOUVEL EMPLOYE :1  QUITTER : 0");
                arret = Convert.ToInt32(Console.ReadLine());

            }
        }
    }
}
