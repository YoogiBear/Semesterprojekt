/* Command for Player eating Food
 */

class CommandEat : BaseCommand, ICommand
{
    private Player _player;

    public CommandEat(Player player)
    {
        _player = player;
        description = "You eat Food";
    }
    //attempts to execute EatCommand with given context, command and given parameters else return
    public void Execute(Context context, string command, string[] parameters)
    {
        if (GuardEq(parameters, 1)) {
            Console.WriteLine("You need to specify your food. 🤔");
            return;
        }
        //checks if there is any food to eat in general, if not return and end sequence.
        if (_player.foods.Count == 0) {
            Console.WriteLine("You have no food.");
            return;
        }
        //Predicate to deterimine if item does NOT exists by name and if true return and end sequence.
        if (!_player.foods.Exists(food => food.name == parameters[0])) {
            Console.WriteLine($"{parameters[0]} was not found in the inventory."); 
            return;
        }
        //If food DOES in fact exists FIND that item and eat via saturation and remove from the list of foods.
        Food food = _player.foods.First(food => food.name == parameters[0]);
        _player.Eat(food.saturation);
        _player.foods.Remove(food);
        Utility.SlowPrint($"You ate the {parameters[0]}!",10);
        Utility.SlowPrint($"current hunger is: {_player.hunger}",10);
    }
}
