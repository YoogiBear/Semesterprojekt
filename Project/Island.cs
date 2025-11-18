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

        int numberOfTrees = rng.Next(1, 6); //Generates between 1 and 5 trees
        for (int i = 0; i < numberOfTrees; i++)
        {
            trees.Add(new Tree());
        }
        //Console.WriteLine($"Generated {numberOfTrees} trees on the island.");
    }
    public void GeneratePollution(List<Resource> trash)
    {
        pollution = 0;
        foreach(Resource material in trash)
        {
            switch(material.name)
            {
                case "wood":
                pollution+= material.pollution;
                break;

                case "metal":
                pollution+= material.pollution;
                break;

                case "pap":
                pollution+= material.pollution;
                break;

                case "plast":
                pollution+= material.pollution;
                break;

                default:
                break;
            }
        }
        return;
    }

}