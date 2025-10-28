/* Main class for launching the game
 */

public class Island
{
    public int pollution;
    public static int trees;
    public Resource[] Resources;

    public Island()
    {
        pollution = 10;
        trees = 1;
        Resources = new Resource[10];
    }

    public void GenerateTrees()
    {
        trees += 1;
    }
    public int GeneratePollution(Resource[] trash, int pollution)
    {
        //Depending on the amount of trash (size of Resources), pollution is added to the "ocean"
        float pollutionAdd = trash.Length/10*2;
        if(pollutionAdd >= 1.0) //Runs when trash contains 5 or more pieces
        {
            return pollution += int(Math.Round(pollutionAdd, 0));
        }
        else 
        {
            return pollution;
        }
    }

}