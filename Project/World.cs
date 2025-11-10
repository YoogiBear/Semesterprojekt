/* World class for modeling the entire in-game world
 */

class World {
  Space entry;
  
  public World () {

    Space center = new Center("the center of the island");
    Space north = new North("the northern part of the island");
    Space south = new South("the southern part of the island");
    Space east = new East("the eastern part of the island");
    Space west = new West("the western part of the island");
    //make forest, beach, campsite. make trash work.
    Space ocean = new Ocean("the ocean");
    Space beach = new Beach("the beach");
    Space forestArea = new Forest("the forest area");
    


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
      new Resource("plastic"),new Resource("plastic")
    ];

    public Resource[] resources; //Array to hold resources within the ocean

    public Beach(string Name) : base(Name)
    {
      resources = new Resource[10];
      CreateResources();
    }

    //Changed so CreateResources now copies the elements of resourcesprefab and not just hold the same values
    public void CreateResources()
    {
      resources = new Resource[resourcesprefab.Length];

      for (int i = 0; i < resourcesprefab.Length; i++)
      {
        resources[i] = resourcesprefab[i];
      }
    }

    public Resource TakeResource(string r) //Removes resource from beacn when called
    {
      if (string.IsNullOrWhiteSpace(r))
      {
        return null;
      }

      for(int i = 0; i < resources.Length; i++)
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
