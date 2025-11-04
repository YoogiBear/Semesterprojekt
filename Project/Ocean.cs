/**
 * Ocean class NOT finished. Base has been established
 * TODO: Implement proper properties and methods.
 * **/

public class Ocean : Space
{

    public Resource[] resourcesprefab =
        [
            new Resource(), new Resource(),
            new Resource(), new Resource(),
            new Resource(), new Resource(),
            new Resource(), new Resource(),
            new Resource(),new Resource()
        ];

    public Resource[] resources;
    public List<Food> food;
    public int pollutionLevel;
    public Ocean(string Name) : base(Name)
    {
        resources = new Resource[10];
        food = new List<Food>() { new Food(), new Food()};
        pollutionLevel = 10;
    }
    public void CreateResources()
    {
        resources = resourcesprefab;
    }

}


