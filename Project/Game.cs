/* Main class for launching the game
 */

public class Game {
  static World    world    = new World();
  static Context  context  = new Context(world.GetEntry());
  static ICommand fallback = new CommandUnknown();
  static Registry registry = new Registry(context, fallback);
  static Player player = new Player();
  static Island island = new Island();
  static Ocean ocean = new Ocean("the ocean");
  public static int daycounter = 0;

  //static int trash = 10;
  private static void InitRegistry () {
    ICommand cmdExit = new CommandExit();
        registry.Register("catch", new CommandCatch(player));
        registry.Register("build", new CommandBuild(player));
        registry.Register("check", new CommandCheck(player));
        registry.Register("chop", new CommandChop(player));
        registry.Register("collect", new CommandGather(player));
        registry.Register("create", new CommandItem(player));
        registry.Register("eat", new CommandEat(player));
        registry.Register("go", new CommandGo());
        registry.Register("help", new CommandHelp(registry));
        registry.Register("quit", cmdExit);
        registry.Register("sleep", new CommandSleep(player, ocean, island));
    }
  
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
        Utility.SlowPrint("Du vågner på en øde ø midt i ingenting.",20);
        Thread.Sleep(1000);
        Utility.SlowPrint("Du ser en logbog ligge på jorden.", 20);
        Thread.Sleep(1000);
        Utility.SlowPrint("Du tager den op og bladrer til første side.", 20);
        Thread.Sleep(1000);
        Utility.SlowPrint("Der står: 'Hvis du nogensinde har brug for hjælp, spørg bare. Men dit hovedmål er at overleve og sejle væk fra øen. Der ser dog ikke ud til at være en båd, så du må lave din egen. Held og lykke med at overleve ved at samle mad og ressourcer til at bygge din båd. Alle ressourcer opdateres hver morgen.'", 20);
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
      string? line = Console.ReadLine();
      if (line!=null) registry.Dispatch(line);
    }
    Console.WriteLine("Game Over 😥");
  } 
}
