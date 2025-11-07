/* Command for Player eating Food
 */

class CommandEat : BaseCommand, ICommand {
private Player _player;

  public CommandEat (Player player) {
    _player = player;
    description = "You eat Food";
  }
    //attempts to execute EatCommand with given context, command and given parameters else return
  public void Execute (Context context, string command, string[] parameters) {
    if (_player.foods.Count == 0){
      Console.WriteLine("You have no food.");
      return;
    }

    else if (GuardEq(parameters, 1)) {
      Console.WriteLine("You need to specify your food. 🤔");
      return;
    }

    foreach(Food food in _player.foods) {
      if (food.name == parameters[0]){
        _player.Eat(food.saturation);
        _player.foods.Remove(food);
        break;
      }
      else {
        Console.WriteLine("That's not a type of food. 🤔");
      }
      return;
    }
  }
}
