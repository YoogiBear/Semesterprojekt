class CommandChop : BaseCommand, ICommand
{
    private Player _player;

    public CommandChop(Player player)
    {
        _player = player;
        description = "Giver mulighed for at hugge træer for ressourcer. Men kun tæt på et træ. Brug 'hug træ'";
    }

    public void Execute(Context context, string command, string[] parameters)
    {
        // Hvis spilleren kun skriver "chop"
        if (GuardEq(parameters, 1))
        {
            Console.WriteLine("Jeg ved ikke, hvad du skal hugge 🤔");
            return;
        }

        // Spilleren skal være i skov-området
        if (context.GetCurrent().GetName() != "the forest area")
        {
            Console.WriteLine("Du er ikke i et område, hvor du kan hugge noget.");
            return;
        }

        if (Island.trees.Count == 0)
        {
            Console.WriteLine("Der er ingen træer tilbage at hugge.");
            return;
        }

        // Udfører den eksisterende Tree-metode (du behøver ikke ændre noget i Tree)
        Tree tree = Island.trees[0];
        string result = tree.ChopTree(_player);
        Console.WriteLine(result);
    }
}
