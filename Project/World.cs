/* World-klasse til modellering af hele spillets verden
 */

class World {
    Space entry;
    public Beach beach = new Beach("beach");
    public Ocean ocean = new Ocean("the ocean");
  
    public World () {

        Space center = new Center("øens centrum");
        Space north = new North("den nordlige del af øen");
        Space south = new South("den sydlige del af øen");
        Space east = new East("den østlige del af øen");
        Space west = new West("den vestlige del af øen");

        Space ocean = this.ocean;
        Space beach = this.beach;
        Space forestArea = new Forest("the forest area");

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
