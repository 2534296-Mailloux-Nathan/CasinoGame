using System.Data;
using Dapper;
using System.Data.SQLite;
using System.Collections.Generic;
using System.Linq;

namespace CasinoGame;

public class BaseDeDonne
{
    // Méthode privée pour charger la chaîne de connexion à la base de données SQLite
    private static string LoadConnectionString()
    {
        return @"Data Source=databasse.db";
    }

    // Méthode pour charger toutes les personnes depuis la table "personne"
    public static List<PersoneModel> LoadPerson()
    {
        using (IDbConnection cnn = new SQLiteConnection(LoadConnectionString()))
        {
            // Exécute une requête SQL pour récupérer toutes les entrées de la table "personne"
            string sql = "select * from personne";
            var output = cnn.Query<PersoneModel>(sql);
            return output.ToList(); // Retourne les résultats sous forme de liste
        }
    }

    // Méthode pour insérer une nouvelle personne dans la table "personne"
    public static void SavePerson(PersoneModel persone)
    {
        using (IDbConnection cnn = new SQLiteConnection(LoadConnectionString()))
        {
            // Requête SQL pour insérer une nouvelle entrée dans la table "personne"
            string sql = @"
                INSERT INTO personne (SecondName, FirstName, Balance) 
                VALUES (@SecondName, @FirstName, @Balance)";

            // Exécute la requête avec les données de l'objet "persone"
            cnn.Execute(sql, persone);
        }
    }

    // Méthode pour mettre à jour le solde d'une personne spécifique dans la table "personne"
    public static void UpdatePersonneBalance(int id, double balance)
    {
        using (IDbConnection cnn = new SQLiteConnection(LoadConnectionString()))
        {
            // Requête SQL pour mettre à jour le champ "Balance" d'une personne identifiée par son Id
            string sql = @" UPDATE personne SET Balance = @Balance WHERE Id = @Id";
            cnn.Execute(sql, new { Balance = balance, Id = id }); // Exécute la requête avec les paramètres fournis
        }
    }

    // Méthode pour supprimer une personne spécifique de la table "personne"
    public static void DeletePersonne(int id)
    {
        using IDbConnection cnn = new SQLiteConnection(LoadConnectionString());
        {
            // Requête SQL pour supprimer une entrée de la table "personne" basée sur l'Id
            string sql = @" DELETE FROM personne WHERE Id = @Id";

            // Exécute la requête et vérifie si une ligne a été affectée
            if (0 == cnn.Execute(sql, new { Id = id }))
                Console.WriteLine("N'existe pas"); // Affiche un message si l'Id n'existe pas
        }
    }
}
