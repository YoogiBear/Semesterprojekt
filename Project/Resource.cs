/* Main class for launching the game
 */

public class Resource
{
    public string name;
    public int strength;
    public int pollution;

    public Resource(string Name = "defaultName", int Strength = 20, int Pollution = 20)
    {
        name = Name;
        strength = Strength;
        pollution = Pollution;
    }
}