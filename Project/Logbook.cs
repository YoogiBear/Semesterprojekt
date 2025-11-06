/**
 * Player class NOT finished. Base has been established
 * TODO: Implement proper properties and methods.
 * **/

public class Logbook
{
    public List<Objective> objectives;
    private Objective currentObjective;
    private Objective entry;

    public Logbook()
    {
        entry = new Objective() { title = "Stranded", description = "It seems like you are stranded.\nYou will have to figure out how to survive." };
        currentObjective = entry;

    }

    public void DisplayCurrentObjective()
    {
        Utility.SlowPrint("You checked the logbook for your current objective.", 10);
        Console.WriteLine();
        Thread.Sleep(1000);
        currentObjective.Present();
    }
}