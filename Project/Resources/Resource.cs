/* Main class for launching the game
 */

public class Resource
{
    public string name;
    public int pollution;

    public Resource(string name = "defaultName", int pollution = 10)
    {
        this.name = name;
        this.pollution = pollution;
    }
}