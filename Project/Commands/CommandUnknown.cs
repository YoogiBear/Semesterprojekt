/* Fallback for when a command is not implemented
 */

using System.Net;

class CommandUnknown : BaseCommand, ICommand {
  public void Execute(Context context, string command, string[] parameters)
  {
    if (string.IsNullOrEmpty(command))
    {
      return;
    }
    else
    {
      Console.WriteLine("I don't understand what '" + command + "' is.😕");
    }
  }
}
