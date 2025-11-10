/* Command for transitioning between allowed spaces
 */

class CommandCatch : BaseCommand, ICommand
{
    private Player _player;
    public CommandCatch(Player player)
    {
        _player = player;
        description = "Allows for the catching of fish. But only near a valid water source.";

    }
    //attempts to execute GoCommand with given context, command and given parameters else return 
    public void Execute(Context context, string command, string[] parameters)
    {
        if (GuardEq(parameters, 1))
        {
            Console.WriteLine("I don't seem to know what to catch 🤔");
            return;
        } else if(context.GetCurrent().GetName() != "the ocean") {
            Console.WriteLine("You are not within an area for which to catch anything.");
            return;
        }

        //Allows for command execution
        //TODO: This logic is bad please update it.
        Ocean ocean = (Ocean)context.GetCurrent();
        if (ocean.food.Count<Food>() >0)
        {
            Food food = ocean.food.First<Food>();
            _player.Catch(food);
            ocean.food.Remove(food);
            Utility.SlowPrint("A fish was caught!", 20);
        } else
        {
            Utility.SlowPrint("Sadly, there wasn't any fish to catch.", 20);
        }

    }

}
