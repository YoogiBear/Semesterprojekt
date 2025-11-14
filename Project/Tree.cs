/* Klasse for træer på øen
 */

using System.Collections.Specialized;

public class Tree
{
    private static readonly Random rng = new Random();
    public int fruitsOnTree;

    public Tree() // Konstruktor
    {
        fruitsOnTree = rng.Next(1, 6);
    }

    public string ChopTree(Player player)
    {
        if (Island.trees.Count == 0)
        {
            return "Der er ingen træer at hugge ned";
        }
        else
        {
            Island.trees.Remove(Island.trees[0]); // Fjerner et træ fra øen
            // Giv spiller træ
            Resource choppedtree = new Resource("Wood", 5);
            player.resources.Add(choppedtree);
        
            return "Du huggede et træ ned og samlede 1 stykke træ!";
        }
    }

    public string Gather(Player player) // Saml kokosnød fra palmetræ
    {
        if (Island.trees.Count == 0)
        {
            return "Der er intet træ at samle mad fra";
        }
        if (fruitsOnTree == 0)
        {
            return "Der er ingen kokosnødder tilbage";
        }
        else // Hvis træ og frugt er tilgængelig, opret nyt Food-objekt
        {
            Food fruit = new Food("Kokosnød", 10);
            player.foods.Add(fruit);
            fruitsOnTree -= 1;

            return $"Du samlede en kokosnød! Antal tilbage på træet: {fruitsOnTree}";
        }
    }
}
