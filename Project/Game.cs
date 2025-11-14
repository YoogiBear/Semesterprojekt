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
        registry.Register("check", new CommandCheck(player));
        registry.Register("chop", new CommandChop(player));
        registry.Register("collect", new CommandGather(player));
        registry.Register("create", new CommandItem(player));
        registry.Register("eat", new CommandEat(player));
        registry.Register("go", new CommandGo());
        registry.Register("help", new CommandHelp(registry));
        registry.Register("quit", cmdExit);
        registry.Register("sleep", new CommandSleep(player, ocean));
    }
  
  static void Main (string[] args) {

        Console.Clear();
        Utility.SlowPrint("Welcome to", 50);
        Utility.SlowPrint("███████╗ ██████╗ ██████╗                ██████╗ ██╗   ██╗███████╗███████╗████████╗", 1);
        Utility.SlowPrint("██╔════╝██╔════╝██╔═══██╗              ██╔═══██╗██║   ██║██╔════╝██╔════╝╚══██╔══╝", 1);
        Utility.SlowPrint("█████╗  ██║     ██║   ██║    █████╗    ██║   ██║██║   ██║█████╗  ███████╗   ██║", 1);
        Utility.SlowPrint("██╔══╝  ██║     ██║   ██║    ╚════╝    ██║▄▄ ██║██║   ██║██╔══╝  ╚════██║   ██║ ", 1);
        Utility.SlowPrint("███████╗╚██████╗╚██████╔╝              ╚██████╔╝╚██████╔╝███████╗███████║   ██║ ", 1);
        Utility.SlowPrint("╚══════╝ ╚═════╝ ╚═════╝                ╚══▀▀═╝  ╚═════╝ ╚══════╝╚══════╝   ╚═╝ ", 1);
        Console.WriteLine("Press any key to continue...");
        Console.ReadKey();
        Console.Clear();
        Utility.SlowPrint("You wake up on a deserted island in the middle of nowhere.",20);
        Thread.Sleep(1000);
        Utility.SlowPrint("You spot a logbook on the ground.", 20);
        Thread.Sleep(1000);
        Utility.SlowPrint("You pick it up and flip to the first page.", 20);
        Thread.Sleep(1000);
        Utility.SlowPrint("It reads: 'If ever you are in need of help. Just ask. But your main goal is to survive, and sail away from the island. Although there seems to be no boat, so you'll have to make your own. Good luck surviving by collecting food, and gathering resources to build your boat. All resources should refresh every morning.'", 20);
        Thread.Sleep(1000);
        Utility.SlowPrint("You wonder what it means...", 20);
        Thread.Sleep(1000);
        Console.WriteLine();
        Utility.SlowPrint("Press any key to continue...", 10);
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
