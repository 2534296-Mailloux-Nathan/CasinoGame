namespace CasinoGame;

// Modèle de données représentant une personne dans le jeu de casino
public struct PersoneModel
{
    // Identifiant unique de la personne (peut être null)
    public int? Id { get; set; }

    // Prénom de la personne
    public string FirstName { get; set; }

    // Nom de famille de la personne
    public string SecondName { get; set; }

    // Solde du compte de la personne
    public double Balance { get; set; }

    // Constructeur pour initialiser une personne avec un prénom, un nom et un solde
    public PersoneModel(string firstName, string secondName, double balance)
    {
        // L'identifiant est initialisé à null par défaut
        Id = null;
        FirstName = firstName;
        SecondName = secondName;
        Balance = balance;
    }

    // Méthode pour retourner une représentation textuelle de l'objet
    override public string ToString()
    {
        return $"{Id}# :{FirstName} {SecondName} : {Balance:c2}";
    }
}
