
class CommandGo : BaseCommand, ICommand {
  public CommandGo () {
    description = "Bruges til at bevæge dig rundt på øen. Skriv 'gå' efterfulgt af en gyldig retning.";
  }
  
  //Attempts to execute GoCommand with a given context, command and parameter otherwise returns
  public void Execute (Context context, string command, string[] parameters) {
    if (GuardEq(parameters, 1)) {
      Console.WriteLine("Jeg ved ikke, hvor det er 🤔");
      return;
    }
    context.Transition(parameters[0]);
  }
}
