/**
 * Player class NOT finished. Base has been established
 * TODO: Implement proper properties and methods.
 * **/

public class BoatObjective : Objective
{
    public int TrackedResources = 0;
    public BoatObjective()
    {
        title = "Byg en båd";
        description = "Du skal bygge en båd for at komme væk herfra!\nDu bliver nødt til at samle ressourcer for at bygge den.";
    }

    public void TrackPlayerResources(int amount)
    {
        TrackedResources += amount;
    }

}
