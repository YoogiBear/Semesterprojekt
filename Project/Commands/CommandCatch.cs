/* Command for transitioning between allowed spaces
 */

class CommandCatch : BaseCommand, ICommand
{
    private Player _player;
    public CommandCatch(Player player)
    {
        _player = player;

    }
    //attempts to execute GoCommand with given context, command and given parameters else return 
    public void Execute(Context context, string command, string[] parameters)
    {
        if (GuardEq(parameters, 1))
        {
            Console.WriteLine("I don't seem to know what to hunt 🤔");
            return;
        } else if(context.GetCurrent().GetName().ToLower() != "ocean") {
            Console.WriteLine("You are not within an area for which to catch anything.");
            return;
        }

        //Allows for command execution
        //TODO: This logic is bad please update it.
        Ocean ocean = (Ocean)context.GetCurrent();
        Food food = ocean.food.First<Food>();
        if (ocean.food.Contains<Food>(food))
        {
            _player.Catch(food);
            ocean.food.Remove(food);
        }
    }
}

class CommandBuild : BaseCommand, ICommand
{
    private Player _player;

    public CommandBuild(Player player)
    {
        _player = player;
    }

    public void Execute(Context context, string command, string[] parameters)
    {
        if (GuardEq(parameters, 1))
        {
            Console.WriteLine("You tried to build nothing, and you succeeded? 🤔");
            return;
        }
        //Allows for command execution

    }
}