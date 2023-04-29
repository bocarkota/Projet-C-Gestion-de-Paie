public class Employe
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

}

public class Fiche_paiement
{
    public int ID_fiche { get; set; }
    public Employe employe { get; set; }
    public decimal Prime { get; set; }
    public DateTime Date_paiement { get; set; }

    public void Affichage_fiche_paiement()
    {
        Console.WriteLine("ID Fiche: {0}", ID_fiche);
        Console.WriteLine("Employe ID: {0}", Employe.EmployeId);
        Console.WriteLine("Employe Name: {0}", Employe.EmployeName);
        Console.WriteLine("Salaire: {0}", Employe.Salaire);
        Console.WriteLine("Prime: {0}", Prime);
        Console.WriteLine("Date Paiement: {0}", Date_paiement.ToString("dd/MM/yyyy"));
    }

    public void Modifier_fiche_paiement(decimal nouvelle_prime)
    {
        Prime = nouvelle_prime;
        Console.WriteLine("Fiche de paiement modifiee avec succes!");
        AffichageFichePaiement();
    }
}

public class Gestion_paiement
{
    public void Affichage_paiement(Fiche_paiement fichePaiement)
    {
        fichePaiement.Affichage_fiche_paiement();
    }
}

public class Program
{
    static void Main(string[] args)
    {
        Employe employe = new Employe()
        {
            EmployeId = 1,
            EmployeName = "John Doe",
            Salaire = 5000.00m
        };

        Fiche_paiement fichePaiement = new Fiche_paiement()
        {
            ID_fiche = 1,
            Employe = employe,
            Prime = 1000.00m,
            Date_paiement = DateTime.Now
        };

        Gestion_paiement gestion_paiement = new Gestion_paiement();
        gestion_paiement.Affichage_paiement(fichePaiement);

        // Modifier la fiche de paiement
        fichePaiement.Modifier_fiche_paiement(1500.00m);
        Console.ReadKey();
    }
}
