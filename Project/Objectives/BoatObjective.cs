/**
 * Player class NOT finished. Base has been established
 * TODO: Implement proper properties and methods.
 * **/

public class BoatObjective : Objective
{
    public int TrackedResources = 0;
    public BoatObjective()
    {
        title = "Build a boat";
        description = "You have to build a boat to get out of here!\nYou'll need to collect resources to build it.";
    }

    public void TrackPlayerResources(int amount)
    {
        TrackedResources += amount;
    }

}
