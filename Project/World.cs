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

    Space ocean = new Ocean("the ocean");
    

    ocean.AddEdge("land", center);
    center.AddEdge("north", north);
    center.AddEdge("south", south);
    center.AddEdge("east", east);
    center.AddEdge("west", west);
    north.AddEdge("center", center);
    south.AddEdge("center", center);
    east.AddEdge("center", center);
    west.AddEdge("center", center);

    north.AddEdge("ocean", ocean);
    south.AddEdge("ocean", ocean);
    east.AddEdge("ocean", ocean);
    west.AddEdge("ocean", ocean);


        this.entry = center;
  }
  
  public Space GetEntry () {
    return entry;
  }
}

