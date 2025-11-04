/* Main class for launching the game
 */

class Game {
  static World    world    = new World();
  static Context  context  = new Context(world.GetEntry());
  static ICommand fallback = new CommandUnknown();
  static Registry registry = new Registry(context, fallback);
  static Player player = new Player();
  static Logbook logbook = new Logbook();
  static int trash = 10;
  private static void InitRegistry () {
    ICommand cmdExit = new CommandExit();
    registry.Register("quit", cmdExit);
    registry.Register("go", new CommandGo());
    registry.Register("help", new CommandHelp(registry));
    registry.Register("catch", new CommandCatch(player));
  }
  
  static void Main (string[] args) {
    Utility.SlowPrint("Welcome to Eco-Quest(WIP)", 50);
    Console.WriteLine("Press any key to continue...");
    Console.ReadKey();
    Console.Clear();
    logbook.Intro();
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

public static class Utility
{
    // This class allows text to be written out letter by letter with spaces in between, for added effect.
    public static void SlowPrint(string text, int time = 100)
    {
        text.ToCharArray();
        foreach (char ch in text)
        {
            Console.Write(ch.ToString());
            Console.Write("");
            Thread.Sleep(time);
        }
        Console.WriteLine();
    }

}


