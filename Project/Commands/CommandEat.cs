/* Command for Player eating Food
 */

class CommandEat : BaseCommand, ICommand {


  public CommandEat () {
    description = "You eat Food";
  }

    //attempts to execute EatCommand with given context, command and given parameters else return
  public void Execute (Context context, string command, string[] parameters) {
    if (Player.foods.Count == 0){
      Console.WriteLine("You have no food.");
      return;
    }
    else if (GuardEq(parameters, 1)) {
      Console.WriteLine("You need to specify your food. 🤔");
      return;
    }
    else if(parameters[0] == "apple"){
      Game.player.Eat(5);
      return;
    }
    else if(parameters[0] == "fish"){
      Game.player.Eat(10);
      return;
    }
  }
}

