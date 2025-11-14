class CommandGather : BaseCommand, ICommand
{
    private Player _player;
    public CommandGather(Player player)
    {
        _player = player;
        description = "Giver mulighed for at samle ressourcer i havet";
    }

    // forsøger at udføre kommandoen med givet context, command og parametre, ellers returner
    public void Execute(Context context, string command, string[] parameters)
    {
        if (GuardEq(parameters, 1))
        {
            Console.WriteLine("Jeg ved ikke, hvad du skal samle 🤔");
            return;
        }
        else if (context.GetCurrent().GetName() != "the ocean")
        {
            Console.WriteLine("Du skal være i havet for at samle ressourcer");
            return;
        } 
        else if (context.GetCurrent().GetName() == "the ocean")
        {
            Ocean ocean = (Ocean)context.GetCurrent();
            string wanted = parameters[0];
            Resource gathered = ocean.TakeResource(wanted);
            _player.AddResource(gathered);
            Console.WriteLine("Du har samlet en ressource fra havet");
            return;
        }
    }
}
