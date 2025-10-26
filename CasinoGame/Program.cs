namespace CasinoGame;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("\x1b[38;2;0;0;200m╔═══════════════════════════════════════════════════════════════════════════════════════════════════════╗\n\x1b[38;2;0;0;188m║                                                                                                       ║\n\x1b[38;2;0;0;176m║    .d8888b.                    d8b                        .d8888b.                                    ║\n\x1b[38;2;0;0;164m║   d88P  Y88b                   Y8P                       d88P  Y88b                                   ║\n\x1b[38;2;0;0;152m║   888    888                                             888    888                                   ║\n\x1b[38;2;0;0;140m║   888         8888b.  .d8888b  888 88888b.   .d88b.      888         8888b.  88888b.d88b.   .d88b.    ║\n\x1b[38;2;0;0;128m║   888            \"88b 88K      888 888 \"88b d88\"\\\"88b    888  88888     \"88b 888 \"888 \"88b d8P  Y8b   ║\n\x1b[38;2;0;0;116m║   888    888 .d888888 \"Y8888b. 888 888  888 888  888     888    888 .d888888 888  888  888 88888888   ║\n\x1b[38;2;0;0;104m║   Y88b  d88P 888  888      X88 888 888  888 Y88..88P     Y88b  d88P 888  888 888  888  888 Y8b.       ║\n\x1b[38;2;0;0;92m║    \"Y8888P\"  \"Y888888  88888P' 888 888  888  \"Y88P\"       \"Y8888P88 \"Y888888 888  888  888  \"Y8888    ║\n\x1b[38;2;0;0;80m║                                                                                                       ║\n\x1b[38;2;0;0;60m╚═══════════════════════════════════════════════════════════════════════════════════════════════════════╝\n\x1b[0m");
        //log console
        
       
            /*Console.WriteLine("1. Ajouter une personne");
            BaseDeDonne.SavePerson(new PersoneModel(Console.ReadLine(), Console.ReadLine(), 0));
            BaseDeDonne.SavePerson(new PersoneModel("fdasfads", "fdasfads", 0)); */
            foreach (var personeModel in BaseDeDonne.LoadPerson())
            {
                Console.WriteLine(personeModel);
            }/*
            BaseDeDonne.DeletePersonne(int.Parse(Console.ReadLine()));*/
            LogscreenClass.PrintLogscreenTempleCenter();
            LogscreenClass.SaisieLogscreenTempleCenter(out string firstName, out string secondName);
        Console.Clear();
        LogscreenClass.PrintLogscreenTemplePasswordCenter();
        LogscreenClass.SaisieLogscreenTemplePasswordCenter(out string password);




        BaseDeDonne.LoadPerson();
        
        
        
        
        Console.ReadKey();
        
    }
}
