class CommandGather : BaseCommand, ICommand
{
    private Player _player;
    public CommandGather(Player player)
    {
        _player = player;
        description = "Giver mulighed for at samle ressourcer på stranden";
    }

    // forsøger at udføre kommandoen med givet context, command og parametre, ellers returner
    public void Execute(Context context, string command, string[] parameters)
    {
        if (GuardEq(parameters, 1))
        {
            Console.WriteLine("Jeg ved ikke, hvad du skal samle 🤔");
            return;
        }
        else if (context.GetCurrent().GetName() != "the beach")
        {
            Console.WriteLine("Du skal være på stranden for at samle ressourcer");
            return;
        }
        else if (context.GetCurrent().GetName() == "the beach")
        {
            Beach beach = (Beach)context.GetCurrent();
            string wanted = parameters[0];
            Resource gathered = beach.TakeResource(wanted);
            _player.AddResource(gathered);
            Console.WriteLine("Du har samlet en ressource fra stranden");
            return;
        }
    }
}
