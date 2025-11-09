/* Main class for launching the game
 */

public class Island
{
    public int pollution;
    public static List<Tree> trees = new List<Tree>();
    public List<Resource> resources;
    Random rng;
    public Island()
    {
        pollution = 10;
        rng = new Random();
        GenerateTrees();
        resources = new List<Resource>();

    }

    public void GenerateTrees()
    {

        int numberOfTrees = rng.Next(1, 6); //Generates between 1 and 5 trees
        for (int i = 0; i < numberOfTrees; i++)
        {
            trees.Add(new Tree());
        }
        //Console.WriteLine($"Generated {numberOfTrees} trees on the island.");
    }
    public int GeneratePollution(Resource[] trash, int pollution)
    {
        //Depending on the amount of trash (size of Resources), pollution is added to the "ocean"
        float pollutionAdd = trash.Length/10f*2f;
        return pollutionAdd >= 1.0f ? pollution += (int)Math.Round(pollutionAdd, 0) : pollution;
        /*

        if (pollutionAdd >= 1.0f) //Runs when trash contains 5 or more pieces
        {
            return pollution += (int)Math.Round(pollutionAdd, 0);
        }
        else 
        {
            return pollution;
        }*/
    }

}