/**
 * Player class NOT finished. Base has been established
 * TODO: Implement proper properties and methods.
 * **/

public class Logbook
{
    public List<Objective> objectives;
    private Objective currentObjective;
    private Objective entry;
    private BoatObjective nextObjective;
    public Logbook()
    {
        entry = new Objective() { title = "Strandet", description = "Det ser ud til, at du er strandet.\nDu bliver nødt til at finde ud af, hvordan du overlever." };
        currentObjective = entry;
        nextObjective = new BoatObjective();

    }

    public void DisplayCurrentObjective()
    {
        Utility.SlowPrint("Du tjekkede logbogen for dit nuværende mål.", 10);
        Console.WriteLine();
        Thread.Sleep(1000);
        currentObjective.Present();
        if (currentObjective == entry) { currentObjective = nextObjective; }
    }

    public Objective NextObjective() { return nextObjective; }
}
