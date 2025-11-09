/* Main class for launching the game
 */

using System.Collections.Specialized;

public class Tree
{
    private static readonly Random rng = new Random();
    public int fruitsOnTree;
    public Tree() //Constructor
    {
        fruitsOnTree = rng.Next(1, 6);;
    }
    public string ChopTree(Player player)
    {
        if (Island.trees.Count == 0)
        {
            return "No trees to chop";
        }
        else
        {
            Island.trees.Remove(Island.trees[0]); //Removes a tree from the island
            //Grant wood to player
            Resource choppedtree = new Resource("Wood", 10, 5);
            player.resources.Add(choppedtree);
        
            return "You chopped down a tree and collected 1 piece of wood!";
        }
        
    }
    public string Gather(Player player) //Collect coconut from palm tree
    {
        if (Island.trees.Count == 0)
        {
            return "No tree to gather food from";
        }
        if (fruitsOnTree == 0)
        {
            return "There are no coconuts left";
        }
        else //If tree and fruit are available, create new Food object
        {
            Food fruit = new Food("Coconut", 10);
            player.foods.Add(fruit);
            fruitsOnTree -= 1;

            return $"You collected a coconut! Remaining coconuts on the tree {fruitsOnTree}";
        }
    }
}