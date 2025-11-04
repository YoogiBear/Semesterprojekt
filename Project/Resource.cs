/* Main class for launching the game
 */

public class Resource
{
    public string name;
    public int strength;
    public int pollution;

    public Resource(string name = "defaultName", int strength = 10, int pollution = 10)
    {
        this.name = name;
        this.strength = strength;
        this.pollution = pollution;
    }
}