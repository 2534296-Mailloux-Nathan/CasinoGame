using System.Data;
using Dapper;
using System.Data.SQLite;
using System.Collections.Generic;
using System.Linq;

namespace CasinoGame;

public class BaseDeDonne
{
    // La chaîne de connexion peut être déplacée dans une méthode privée pour la réutilisation
    private static string LoadConnectionString()
    {
        return "Data Source=C:\\Users\\nathan\\Desktop\\CasinoGame\\CasinoGame\\databasse.db";
    }

    public static List<PersoneModel> LoadPerson()
    {
        using (IDbConnection cnn = new SQLiteConnection(LoadConnectionString()))
        {
            var output = cnn.Query<PersoneModel>("select * from personne", new DynamicParameters());
            return output.ToList();
        }
    }

    // NOUVELLE MÉTHODE : Pour insérer une nouvelle personne
    public static void SavePerson(PersoneModel persone)
    {
        using (IDbConnection cnn = new SQLiteConnection(LoadConnectionString()))
        {
            // 1. Définir la commande INSERT SQL
            
            string sql = @"
                INSERT INTO personne (SecondName, FirstName, Balance) 
                VALUES (@SecondName, @FirstName, @Balance)";
            
            // 2. Exécuter la commande
            // Dapper mappe automatiquement les propriétés de l'objet 'persone' 
            // aux paramètres (@Nom, @Prenom, etc.) de la requête SQL.
            cnn.Execute(sql, persone);
        }
    }

    public static void UpdatePersonneBalance(int id, double balance)
    {
        using (IDbConnection cnn = new SQLiteConnection(LoadConnectionString()))
        {
            string sql = @" UPDATE personne SET Balance = @Balance WHERE Id = @Id";
            cnn.Execute(sql, new { Balance = balance, Id = id });
        }

    }

    public static void DeletePersonne(int id)
    {
        using IDbConnection cnn = new SQLiteConnection(LoadConnectionString());
        {
            string sql = @" DELETE FROM personne WHERE Id = @Id";
            if(0 == cnn.Execute(sql, new { Id = id }))
                Console.WriteLine("N'existe pas");
        }
    }
}