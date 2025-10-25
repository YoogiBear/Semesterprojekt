/**
 * Ocean class NOT finished. Base has been established
 * TODO: Implement proper properties and methods.
 * **/

public class Ocean
{
    public Resource[] resources;
    public int pollutionLevel;
    public string[] food;

    public Ocean()
    {
        resources = new Resource[10];
        pollutionLevel = 10;
        food = new string[10];
    }

    public void CreateFood()
    {
        throw new NotImplementedException();
    }
    public void CreateResources()
    {
        throw new NotImplementedException();
    }
}