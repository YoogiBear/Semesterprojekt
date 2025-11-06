/* Main class for launching the game
 */

public class Game {
  static World    world    = new World();
  static Context  context  = new Context(world.GetEntry());
  static ICommand fallback = new CommandUnknown();
  static Registry registry = new Registry(context, fallback);
  public static Player player = new Player();
  public static Food apple = new Food();



  private static void InitRegistry () {
    ICommand cmdExit = new CommandExit();
    registry.Register("exit", cmdExit);
    registry.Register("quit", cmdExit);
    registry.Register("bye", cmdExit);
    registry.Register("go", new CommandGo());
    registry.Register("help", new CommandHelp(registry));
    registry.Register("eat", new CommandEat());
  }
  
  static void Main (string[] args) {
    Console.WriteLine("Welcome to the World of Zuul!");
    
    //Initialisation
    InitRegistry();
    context.GetCurrent().Welcome();
    Player.foods.Add(apple);
    
    //THIS IS THE MAIN GAME LOOP. EVERYTHING STARTS FROM HERE
    while (context.IsDone()==false) {
      Console.Write("> ");
      Console.WriteLine("You have " + player.Hunger() + " hunger");
      Console.WriteLine(Player.foods.Count);
      string? line = Console.ReadLine();
      if (line!=null) registry.Dispatch(line);
    }
    Console.WriteLine("Game Over 😥");
  }
}
