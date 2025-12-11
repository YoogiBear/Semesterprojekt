/* Command for Player eating Food
 */

class CommandEat : BaseCommand, ICommand
{
    private Player _player;

    public CommandEat(Player player)
    {
        _player = player;
        description = "Er din sult for høj? Prøv at spise noget... brug: \"spis (navn på mad)\"";
    }
    // forsøger at udføre EatCommand med givet context, command og parametre, ellers returner
    public void Execute(Context context, string command, string[] parameters)
    {
        if (GuardEq(parameters, 1)) {
            Console.WriteLine("Du skal angive, hvilken mad du vil spise. 🤔");
            return;
        }
        // tjekker om der overhovedet er mad at spise, hvis ikke returner og afslut
        if (_player.foods.Count == 0) {
            Console.WriteLine("Du har ingen mad.");
            return;
        }
        // predicate til at tjekke om mad IKKE findes efter navn, hvis sand returner og afslut
        if (!_player.foods.Exists(food => food.name == parameters[0].ToLower())) {
            Console.WriteLine($"{parameters[0]} blev ikke fundet i inventaret."); 
            return;
        }
        // hvis mad findes, find item og spis via saturation, fjern fra liste
        Food food = _player.foods.First(food => food.name == parameters[0]);
        _player.Eat(food.saturation);
        _player.foods.Remove(food);
        Utility.SlowPrint($"Du spiste {parameters[0]}!",10);
        Utility.SlowPrint($"Nuværende sult: {_player.hunger}",10);
    }
}
