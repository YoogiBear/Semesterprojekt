/* Command for transitioning between allowed spaces
 */

class CommandGo : BaseCommand, ICommand {
  public CommandGo () {
    description = "Bruges til at bevæge dig rundt på øen. Skriv 'go' efterfulgt af en gyldig retning.";
  }
  
  // forsøger at udføre GoCommand med givet context, command og parametre, ellers returner
  public void Execute (Context context, string command, string[] parameters) {
    if (GuardEq(parameters, 1)) {
      Console.WriteLine("Jeg ved ikke, hvor det er 🤔");
      return;
    }
    context.Transition(parameters[0]);
  }
}
