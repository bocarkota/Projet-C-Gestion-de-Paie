namespace projetFinal
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Employe> listeEmployes = new List<Employe>();

            // Ajouter un nouvel employé
            Employe nouvelEmploye = Employe.AjouterEmploye();
            listeEmployes.Add(nouvelEmploye);

            // Modifier un employé
            Employe.ModifierEmploye(listeEmployes);

            // Afficher la liste des employés
            Employe.afficheEmploye(listeEmployes);

            Console.ReadLine();


            //   List<Employe> employes = new List<Employe>();
            // employes.Add(Employe.AjouterEmploye());

            //    ModifierEmploye(listeEmployes);

        }
    }
}