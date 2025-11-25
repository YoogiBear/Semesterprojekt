/* Command for transitioning between allowed spaces
 */

class CommandCatch : BaseCommand, ICommand
{
    private Player _player;
    public CommandCatch(Player player)
    {
        _player = player;
        description = "Giver mulighed for at fange fisk. Men kun tæt på en gyldig vandkilde. Blot brug kommandoen 'fang fisk'";
    }
    // forsøger at udføre CatchCommand med givet context, command og parametre, ellers returner 
    public void Execute(Context context, string command, string[] parameters)
    {
        if (GuardEq(parameters, 1))
        {
            Console.WriteLine("Jeg ved ikke, hvad du skal fange 🤔");
            return;
        } 
        else if(context.GetCurrent().GetName() != "the ocean") 
        {
            Console.WriteLine("Du er ikke i et område, hvor du kan fange noget.");
            return;
        }

        // Tillader udførelse af kommando
        // TODO: Denne logik er dårlig, opdater venligst
        Ocean ocean = (Ocean)context.GetCurrent();
        if (ocean.food.Count<Food>()>0 && ocean.food.Exists(food => food.name == parameters[0]))
        {
            Food food = ocean.food.First<Food>();
            _player.Catch(food);
            ocean.food.Remove(food);
            Utility.SlowPrint("En fisk blev fanget!", 20);
        } 
        else
        {
            Utility.SlowPrint($"Desværre kunne {parameters[0]} ikke findes i havet.", 20);
        }
    }
}
