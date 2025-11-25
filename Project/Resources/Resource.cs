/* Main class for launching the game
 */

public class Resource
{
    public string name;
    public int pollution;
    public int weight;

    public Resource(string name = "defaultName", int pollution = 10, int weight = 0)
    {
        this.name = name;
        this.pollution = pollution;
        this.weight = weight;
    }
}