/* Main class for launching the game
 */

using cs.Data;

public class Game {
  static World    world    = new World();
  static Context  context  = new Context(world.GetEntry());
  static ICommand fallback = new CommandUnknown();
  static Registry registry = new Registry(context, fallback);
  static Player player = new Player();
  static Island island = new Island();
  public static int daycounter = 0;

  private static void InitRegistry () {
    ICommand cmdExit = new CommandExit();
        registry.Register("fang", new CommandCatch(player));
        registry.Register("byg", new CommandBuild(player));
        registry.Register("tjek", new CommandCheck(player));
        registry.Register("hug", new CommandChop(player));
        registry.Register("saml", new CommandGather(player));
        registry.Register("lav", new CommandItem(player));
        registry.Register("spis", new CommandEat(player));
        registry.Register("gå", new CommandGo());
        registry.Register("hjælp", new CommandHelp(registry));
        registry.Register("slut", cmdExit);
        registry.Register("sov", new CommandSleep(player, world.ocean, island, world.beach));
    }
  
    //Init
  static void Main (string[] args) {

        Console.Clear();
        Utility.SlowPrint("Velkommen til", 50);
        Utility.SlowPrint("███████╗ ██████╗ ██████╗                ██████╗ ██╗   ██╗███████╗███████╗████████╗", 1);
        Utility.SlowPrint("██╔════╝██╔════╝██╔═══██╗              ██╔═══██╗██║   ██║██╔════╝██╔════╝╚══██╔══╝", 1);
        Utility.SlowPrint("█████╗  ██║     ██║   ██║    █████╗    ██║   ██║██║   ██║█████╗  ███████╗   ██║", 1);
        Utility.SlowPrint("██╔══╝  ██║     ██║   ██║    ╚════╝    ██║▄▄ ██║██║   ██║██╔══╝  ╚════██║   ██║ ", 1);
        Utility.SlowPrint("███████╗╚██████╗╚██████╔╝              ╚██████╔╝╚██████╔╝███████╗███████║   ██║ ", 1);
        Utility.SlowPrint("╚══════╝ ╚═════╝ ╚═════╝                ╚══▀▀═╝  ╚═════╝ ╚══════╝╚══════╝   ╚═╝ ", 1);
        Console.WriteLine("Tryk på en vilkårlig tast for at fortsætte...");
        Console.ReadKey();
        Console.Clear();
        
        Console.WriteLine("Indtast BrugerID: ");
        string username = Console.ReadLine();
        GameSession.Login(username);
        Console.Clear();
        
        Utility.SlowPrint("Du vågner på en øde ø midt i ingenting.",20);
        Thread.Sleep(1000);
        Utility.SlowPrint("Du ser en logbog ligge på jorden.", 20);
        Thread.Sleep(1000);
        Utility.SlowPrint("Du tager den op og bladrer til første side.", 20);
        Thread.Sleep(1000);
        Utility.SlowPrint("Der står: 'Hvis du nogensinde har brug for hjælp, bare sig 'hjælp'. Men dit hovedmål er at overleve og sejle væk fra øen.\nDer ser dog ikke ud til at være en båd, så du må lave din egen.\nHeld og lykke med at overleve ved at samle mad og ressourcer til at bygge din båd. Alle ressourcer opdateres hver morgen.'", 20);
        Thread.Sleep(1000);
        Utility.SlowPrint("Du spekulerer på, hvad det betyder...", 20);
        Thread.Sleep(1000);
        Console.WriteLine();
        Utility.SlowPrint("Tryk på en vilkårlig tast for at fortsætte...", 10);
        Console.ReadKey();
        Console.Clear();

        //Initialisation
        InitRegistry();
        context.GetCurrent().Welcome();
    
    //THIS IS THE MAIN GAME LOOP. EVERYTHING STARTS FROM HERE
    while (context.IsDone()==false) {
      Console.Write("> ");
      string? line = Console.ReadLine()!.ToLower();
      if (line!=null) registry.Dispatch(line);
    }
    Console.WriteLine("Game Over 😥");
  } 
}
