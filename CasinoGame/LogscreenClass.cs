using System.Globalization;

namespace CasinoGame;

public static class LogscreenClass
{
	private static (int x, int y)[] champDeSaisie = new (int, int)[3]{
        (11, 5),
        (11, 7),
        (31, 10)
    };

    private const int longueurScreen = 30;
    private const int hauteurScreen = 10;
	
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
		"╚════════════════════════════╝",
	};

	public static void PrintLogscreenTempleCenter()
	{
        // Calculer la position de départ pour centrer l'écran
        int startX = (Console.WindowWidth - longueurScreen) / 2;
        int startY = (Console.WindowHeight - hauteurScreen) / 2;
		//modifier les position de saisi préenregistrer
		champDeSaisie[0] = (startX + 11, startY + 3);
        champDeSaisie[1] = (startX + 11, startY + 6);
		champDeSaisie[2] = (startX + 30, startY + 9);

        foreach (var item in logscreenTemple)
		{
            Console.SetCursorPosition(startX, startY);
            Console.WriteLine(item);
            startY++;
        }
    }
	public static void saisieLogscreenTempleCenter(out string firstName, out string secondName)
    {
        Console.SetCursorPosition(champDeSaisie[0].x, champDeSaisie[0].y);
        firstName = Console.ReadLine() ?? "";
        Console.SetCursorPosition(champDeSaisie[1].x, champDeSaisie[1].y);
        secondName = Console.ReadLine() ?? "";
    }

}