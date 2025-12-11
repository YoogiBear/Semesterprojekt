/* World-klasse til modellering af hele spillets verden
 */

class World {
    Space entry;
    public Beach beach = new Beach("stranden");
    public Ocean ocean = new Ocean("havet");
  
    public World () {

        Space center = new Center("øens centrum");
        Space north = new North("den nordlige del af øen");
        Space south = new South("den sydlige del af øen");
        Space east = new East("den østlige del af øen");
        Space west = new West("den vestlige del af øen");

        Space ocean = this.ocean;
        Space beach = this.beach;
        Space forestArea = new Forest("skov området");

        // Tilknyt forbindelser
        ocean.AddEdge("land", beach);
        center.AddEdge("skov", forestArea);
        forestArea.AddEdge("centrum", center);

        center.AddEdge("nord", north);
        center.AddEdge("syd", south);
        center.AddEdge("øst", east);
        center.AddEdge("vest", west);
        north.AddEdge("centrum", center);
        south.AddEdge("centrum", center);
        east.AddEdge("centrum", center);
        west.AddEdge("centrum", center);

        north.AddEdge("strand", beach);
        south.AddEdge("strand", beach);
        east.AddEdge("strand", beach);
        west.AddEdge("strand", beach);
        beach.AddEdge("havet", ocean);
        beach.AddEdge("centrum", center);

        this.entry = center;
    }
  
    public Space GetEntry () {
        return entry;
    }
}
