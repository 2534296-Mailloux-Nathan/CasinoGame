namespace CasinoGame;

// Mod�le de donn�es repr�sentant une personne dans le jeu de casino
public struct PersoneModel
{
    // Identifiant unique de la personne (peut �tre null)
    public int? Id { get; set; }

    // Pr�nom de la personne
    public string FirstName { get; set; }

    // Nom de famille de la personne
    public string SecondName { get; set; }

    // Solde du compte de la personne
    public double Balance { get; set; }

    // Constructeur pour initialiser une personne avec un pr�nom, un nom et un solde
    public PersoneModel(string firstName, string secondName, double balance)
    {
        // L'identifiant est initialis� � null par d�faut
        Id = null;
        FirstName = firstName;
        SecondName = secondName;
        Balance = balance;
    }

    // M�thode pour retourner une repr�sentation textuelle de l'objet
    override public string ToString()
    {
        return $"{Id}# :{FirstName} {SecondName} : {Balance:c2}";
    }
}
