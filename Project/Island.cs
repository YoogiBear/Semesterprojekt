/* Main class for launching the game
 */

using System.Collections;

public class Island
{
    public static int pollution;
    public static List<Tree> trees = new List<Tree>();
    public List<Resource> resources;
    Random rng;
    public Island()
    {
        pollution = 0;
        rng = new Random();
        GenerateTrees();
        resources = new List<Resource>();

    }

    public void GenerateTrees()
    {
        trees.Add(new Tree());
        //Console.WriteLine($"Generated {numberOfTrees} trees on the island.");
    }
    public void GeneratePollution(List<Resource> trash)
    {
        pollution = 0;
        for (int i = 0; i < trash.Count(); i++)
        {
         pollution += trash[i].Pollution;
        }
    }
}
