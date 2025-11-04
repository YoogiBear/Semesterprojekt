/* Main class for launching the game
 */

public class Resource
{
    public string name;
    public int strength;
    public int pollution;




    public Resource(string Name = "defaultName", int Strength = 10, int Pollution = 10)
    {
        name = Name;
        strength = Strength;
        pollution = Pollution;
    }
}