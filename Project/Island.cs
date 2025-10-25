/* Main class for launching the game
 */

public class Island
{
    public int pollution;
    public int trees;
    public Resource[] Resources;

    public Island()
    {
        pollution = 10;
        trees = 10;
        Resources = new Resource[10];
    }

    public int[] GenerateTrees()
    {
        throw new NotImplementedException();
    }
    public int GeneratePollution()
    {
        throw new NotImplementedException();
    }

}