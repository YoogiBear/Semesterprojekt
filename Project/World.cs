/* World class for modeling the entire in-game world
 */

class World {
  Space entry;
  
  public World () {

    Space center = new Space("the center of the island");
    Space north = new Space("the northern part of the island");
    Space south = new Space("the southern part of the island");
    Space east = new Space("the eastern part of the island");
    Space west = new Space("the western part of the island");
    //make forest, beach, campsite. make trash work.
    Space ocean = new Ocean("the ocean");
    Space beach = new Beach("the beach");

    ocean.AddEdge("land", beach);

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

    public Beach(string name) : base(name)
    {

    }
    
}

public class Forest : Space
{

    public Forest(string name) : base(name)
    {

    }

}

