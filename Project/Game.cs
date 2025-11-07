/* Main class for launching the game
 */

public class Game {
  static World    world    = new World();
  static Context  context  = new Context(world.GetEntry());
  static ICommand fallback = new CommandUnknown();
  static Registry registry = new Registry(context, fallback);
  static Player player = new Player();

  static Island island = new Island();

  static int trash = 10;
  private static void InitRegistry () {
        ICommand cmdExit = new CommandExit();
        registry.Register("go", new CommandGo());
        registry.Register("check", new CommandCheck(player));
        registry.Register("catch", new CommandCatch(player));
        registry.Register("create", new CommandItem(player));
        registry.Register("help", new CommandHelp(registry));
        registry.Register("collect", new CommandGather(player));
        registry.Register("quit", cmdExit);
        registry.Register("gather", new CommandGather(player));
        registry.Register("chop", new CommandChop(player));
        registry.Register("eat", new CommandEat(player));
    }
  
  static void Main (string[] args) {

        Utility.SlowPrint("Welcome to Eco-Quest(WIP)", 50);
        Console.WriteLine("Press any key to continue...");
        Console.ReadKey();
        Console.Clear();
        Utility.SlowPrint("You wake up on a deserted island in the middle of nowhere.",20);
        Thread.Sleep(1000);
        Utility.SlowPrint("You spot a logbook on the ground.", 20);
        Thread.Sleep(1000);
        Utility.SlowPrint("You pick it up and flip to the first page.", 20);
        Thread.Sleep(1000);
        Utility.SlowPrint("It reads: 'If ever you are in need of help. Just ask.'", 20);
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
