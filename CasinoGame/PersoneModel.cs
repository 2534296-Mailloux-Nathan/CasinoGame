namespace CasinoGame;

public struct PersoneModel
{
    // The Id should be a public property, optionally settable if needed later.
    // Dapper can map this back when retrieving data.
    public int? Id { get; set; } 
    
    // Convert all fields used in the INSERT statement to public properties.
    public string FirstName { get; set; }
    public string SecondName { get; set; }
    public double Balance { get; set; }

    // Constructor (still valid, but now initializes the public properties)
    public PersoneModel(string firstName, string secondName, double balance)
    {
        // For a new record, the database handles the Id, so we can leave it null.
        // If the struct is part of an object model, you may need to initialize it 
        // to a default value if not using a parameterless constructor.
        Id = null; 
        FirstName = firstName;
        SecondName = secondName;
        Balance = balance;
    }

    // You should also update your LoadPerson method to handle the Id property.
    // If you want to keep the constructor simpler:
    /* public PersoneModel(string firstName, string secondName, double balance)
        : this(null, firstName, secondName, balance) {}

    public PersoneModel(int? id, string firstName, string secondName, double balance)
    {
        Id = id;
        FirstName = firstName;
        SecondName = secondName;
        Balance = balance;
    }
    */

    override public string ToString()
    {
        return $"{Id}# :{FirstName} {SecondName} : {Balance}";
    }
}