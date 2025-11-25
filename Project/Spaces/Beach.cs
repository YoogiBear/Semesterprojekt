/* World-klasse til modellering af hele spillets verden
 */

public class Beach : Space
{
    public Ocean o = new Ocean("the ocean");
    public List<Resource> resourcePool; // list til at holde ressourcer p� stranden
    
    public Beach(string Name) : base(Name)
    {
        GetResources();
    }
    public void PrintResources()
    {
        foreach (Resource resource in resourcePool)
        {
            Console.WriteLine(resource.name);
        }
    }

    private void GetResources()
    {
        o.CreateResources();
        resourcePool = o.resources;
    }

    public Resource TakeResource(string r) // Fjerner ressource fra stranden, n�r den samles
    {
        if(resourcePool.Count == 0 || !resourcePool.Exists(resource => resource.name == r))
        {
            Console.WriteLine($"'{r}' kunne ikke findes");
            return null;
        } else {
            Resource foundItem = resourcePool.Find(resource => resource.name == r);
            resourcePool.Remove(foundItem);
            Console.WriteLine($"Du samlede {r} op fra stranden!");
            return foundItem;
        }
    }
}
