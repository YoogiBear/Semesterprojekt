/* Fallback for when a command is not implemented
 */

using System.Net;

class CommandUnknown : BaseCommand, ICommand {
  public void Execute(Context context, string command, string[] parameters)
  {
    if (string.IsNullOrEmpty(command))
    {
      Console.WriteLine("Skriv venligst, hvad du ønsker at gøre 😁");
    }
    else
    {
      Console.WriteLine("Jeg forstår ikke, hvad '" + command + "' betyder.😕");
    }
  }
}
