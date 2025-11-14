/* Baseklasse for alle kommandoer
 */

class BaseCommand {
    protected string description = "Ikke dokumenteret";
  
    protected bool GuardEq (string[] parameters, int bound) {
        return parameters.Length != bound;
    }
  
    public string GetDescription () {
        return description;
    }
}
