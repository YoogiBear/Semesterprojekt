/* World-klasse til modellering af hele spillets verden
 */

class World {
    Space entry;
  
    public World () {

        Space center = new Center("øens centrum");
        Space north = new North("den nordlige del af øen");
        Space south = new South("den sydlige del af øen");
        Space east = new East("den østlige del af øen");
        Space west = new West("den vestlige del af øen");

        Space ocean = new Ocean("havet");
        Space beach = new Beach("stranden");
        Space forestArea = new Forest("skovområdet");

        // Tilknyt forbindelser
        ocean.AddEdge("land", beach);
        center.AddEdge("forest", forestArea);
        forestArea.AddEdge("center", center);

        center.AddEdge("north", north);
        center.AddEdge("south", south);
        center.AddEdge("east", east);
        center.AddEdge("west", west);
        north.AddEdge("center", center);
        south.AddEdge("center", center);
        east.AddEdge("center", center);
        west.AddEdge("center", center);

        north.AddEdge("beach", beach);
        south.AddEdge("beach", beach);
        east.AddEdge("beach", beach);
        west.AddEdge("beach", beach);
        beach.AddEdge("ocean", ocean);
        beach.AddEdge("center", center);

        this.entry = center;
    }
  
    public Space GetEntry () {
        return entry;
    }
}

public class Beach : Space
{
    public Resource[] resourcesprefab =
    [
        new Resource("plastic"), new Resource("plastic"),
        new Resource("metal"), new Resource("metal"),
        new Resource("plastic"), new Resource("plastic"),
        new Resource("plastic"), new Resource("plastic"),
        new Resource("plastic"), new Resource("plastic")
    ];

    public Resource[] resources; // Array til at holde ressourcer på stranden

    public Beach(string Name) : base(Name)
    {
        resources = new Resource[10];
        CreateResources();
    }

    // Kopier prefab-ressourcer til den aktuelle strand
    public void CreateResources()
    {
        resources = new Resource[resourcesprefab.Length];

        for (int i = 0; i < resourcesprefab.Length; i++)
        {
            resources[i] = resourcesprefab[i];
        }
    }

    public Resource TakeResource(string r) // Fjerner ressource fra stranden, når den samles
    {
        if (string.IsNullOrWhiteSpace(r))
        {
            return null;
        }

        for (int i = 0; i < resources.Length; i++)
        {
            Resource rs = resources[i];

            if (rs == null) { continue; }

            if (rs.name == r)
            {
                resources[i] = null;
                return rs;
            }
        }
        return null;
    }
}

/*
public class Forest : Space
{
    public Forest(string name) : base(name)
    {

    }
}
*/
