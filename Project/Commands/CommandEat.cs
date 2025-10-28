/* Command for Player eating Food
 */

class CommandEat : BaseCommand, ICommand {
  public CommandEat () {
    description = "You eat Food";
  }

    //attempts to execute EatCommand with given context, command and given parameters else return
  public void Execute (Context context, string command, string[] parameters) {
    if (Game.foodArray[0] == null){
      Console.WriteLine("You have no food.");
      return;
    }
    else if (GuardEq(parameters, 1)) {
      Console.WriteLine("You need to specify your food. 🤔");
      return;
    }
    Game.player.Eat(Game.food.saturation);
  }
}
