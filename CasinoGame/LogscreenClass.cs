namespace CasinoGame;

public static class LogscreenClass
{
    // Positions des champs de saisie pour le prénom, le nom et le mot de passe
    private static (int x, int y)[] champDeSaisie = new (int, int)[3]
    {
           (11, 5),
           (11, 7),
           (31, 10)
    };

    // Modèle d'affichage pour l'écran de connexion
    private static string[] logscreenTemple = new string[10]
    {
           "╔════════════════════════════╗",
           "║ Login Screen               ║",
           "║                            ║",
           "║ Prénom :                   ║",
           "║         ------------------ ║",
           "║                            ║",
           "║ Nom :                      ║",
           "║         ------------------ ║",
           "║                            ║",
           "╚════════════════════════════╝"
    };

    // Modèle d'affichage pour l'écran de saisie du mot de passe
    private static string[] logscreenTemplePassword = new string[5]
    {
           "╔════════════════════════════╗",
           "║ Mot De Passe               ║",
           "║                            ║",
           "║         ------------------ ║",
           "╚════════════════════════════╝"
    };

    // Modèle d'affichage pour l'écran de saisie de l'ID
    private static string[] logscreenTempleID = new string[5]
    {
           "╔════════════════════════════╗",
           "║ ID Utilisateur             ║",
           "║                            ║",
           "║         ------------------ ║",
           "╚════════════════════════════╝"
    };

    // Affiche l'écran de connexion centré dans la console
    public static void PrintLogscreenTempleCenter()
    {
        // Calculer la position de départ pour centrer l'écran
        int startX = (Console.WindowWidth - 30) / 2;
        int startY = (Console.WindowHeight - 10) / 2;

        // Met à jour les positions des champs de saisie pour le prénom et le nom
        champDeSaisie[0] = (startX + 11, startY + 3);
        champDeSaisie[1] = (startX + 11, startY + 6);

        // Affiche chaque ligne du modèle d'écran
        foreach (var item in logscreenTemple)
        {
            Console.SetCursorPosition(startX, startY);
            Console.WriteLine(item);
            startY++;
        }
    }

    // Affiche l'écran de saisie du mot de passe centré dans la console
    public static void PrintLogscreenTemplePasswordCenter()
    {
        // Calculer la position de départ pour centrer l'écran
        int startX = (Console.WindowWidth - 30) / 2;
        int startY = (Console.WindowHeight - 5) / 2;

        // Met à jour la position du champ de saisie pour le mot de passe
        champDeSaisie[2] = (startX + 10, startY + 2);

        // Affiche chaque ligne du modèle d'écran pour le mot de passe
        foreach (var item in logscreenTemplePassword)
        {
            Console.SetCursorPosition(startX, startY);
            Console.WriteLine(item);
            startY++;
        }
    }

    // Affiche l'écran de saisie de l'ID centré dans la console
    public static void PrintLogscreenTempleIDCenter()
    {
        // Calculer la position de départ pour centrer l'écran
        int startX = (Console.WindowWidth - 30) / 2;
        int startY = (Console.WindowHeight - 5) / 2;

        // Met à jour la position du champ de saisie pour l'ID
        champDeSaisie[2] = (startX + 10, startY + 2);

        // Affiche chaque ligne du modèle d'écran pour l'ID
        foreach (var item in logscreenTempleID)
        {
            Console.SetCursorPosition(startX, startY);
            Console.WriteLine(item);
            startY++;
        }
    }

    // Permet la saisie du prénom et du nom dans les champs correspondants
    public static void SaisieLogscreenTempleCenter(out string firstName, out string secondName)
    {
        PrintLogscreenTempleCenter();

        // Positionne le curseur pour la saisie du prénom
        Console.SetCursorPosition(champDeSaisie[0].x, champDeSaisie[0].y);
        firstName = Console.ReadLine() ?? "";

        // Positionne le curseur pour la saisie du nom
        Console.SetCursorPosition(champDeSaisie[1].x, champDeSaisie[1].y);
        secondName = Console.ReadLine() ?? "";
    }

    // Permet la saisie du mot de passe
    public static void SaisieLogscreenTemplePasswordCenter(out string password)
    {
        PrintLogscreenTemplePasswordCenter();

        // Positionne le curseur pour la saisie du mot de passe
        Console.SetCursorPosition(champDeSaisie[2].x, champDeSaisie[2].y);
        password = Console.ReadLine() ?? "";
    }

    // Permet la saisie de l'ID utilisateur
    public static void SaisieLogscreenTempleIDCenter(out int id)
    {
        PrintLogscreenTempleIDCenter();

        // Positionne le curseur pour la saisie de l'ID
        Console.SetCursorPosition(champDeSaisie[2].x, champDeSaisie[2].y);
        int.TryParse(Console.ReadLine() ?? "0", out id);
    }

    // Gère le processus de connexion normal
    public static void NormalLogInCasino()
    {
        int idUser = 0;
        string password = "";

        // Boucle jusqu'à ce qu'un ID utilisateur valide soit saisi
        do
        {
            SaisieLogscreenTempleIDCenter(out idUser);
        } while (!BaseDeDonne.PersonneExists(idUser));

        // Boucle jusqu'à ce que le mot de passe soit correct
        do
        {
            SaisieLogscreenTemplePasswordCenter(out password);


            int maxAttempts = 3;
            int attempts = 0;

            while (!BaseDeDonne.PasswordIsCorrect(idUser, password))
            {
                attempts++;
                if (attempts >= maxAttempts)
                {
                    Console.WriteLine("Trop de tentatives échouées. Veuillez réessayer plus tard.");
                    return; // Quitte la méthode après trop de tentatives
                }

                Console.WriteLine($"Mot de passe incorrect. Tentative {attempts}/{maxAttempts}.");
                SaisieLogscreenTemplePasswordCenter(out password);
            }
        } while (false);
    }
}
