/* World-klasse til modellering af hele spillets verden
 */

public class Beach : Space
{
    public List<Resource> resourcePool; // list til at holde ressourcer på stranden


    public Beach(string Name) : base(Name)
    {
        resourcePool = new List<Resource>() {
            new Resource("plastic"), new Resource("plastic"),
            new Resource("metal"), new Resource("metal"),
            new Resource("plastic"), new Resource("plastic"),
            new Resource("plastic"), new Resource("plastic"),
            new Resource("plastic"), new Resource("plastic")
        };
    }

    public Resource TakeResource(string r) // Fjerner ressource fra stranden, når den samles
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
