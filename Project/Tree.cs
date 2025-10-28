/* Main class for launching the game
 */

using System.Collections.Specialized;

public class Tree
{
    public int fruitsOnTree;
    public Tree() //Constructor
    {
        fruitsOnTree = 5;
    }
    public int ChopTree(Player player)
    {
        if (Island.trees == 0)
        {
            Console.WriteLine("No trees to chop");
            return 0;
        }
        else
        {
            Island.trees -= 1;
            //Grant 5 wood to player
            Resource choppedtree = new Resource("Wood", 10, 5);
            int resource_size = player.resources.Length;
            for(int i=0; i<3; i++)
            {
                player.resources[resource_size+i] = choppedtree;
            }
        
            return 0;
        }
        
    }
    public string Gather(Player player) //Collect coconut from palm tree
    {
        if (Island.trees == 0)
        {
            return "No tree to gather food from";
        }
        else if (fruitsOnTree == 0)
        {
            return "There are no coconuts left";
        }
        else //If tree and fruit are available, create new Food object
        {
            Food fruit = new Food("Coconut", 10);
            player.food[player.food.Length] = fruit; //Food-array is formatted as string?
            fruitsOnTree -= 1;

            return $"You collected a coconut! Remaining coconuts on the tree {fruitsOnTree}";
        }
    }
}