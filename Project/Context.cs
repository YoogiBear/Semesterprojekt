/* Context-klasse til at holde al kontekst relevant for en session.
 */

public class Context {
    Space current;
    bool done = false;
  
    public Context (Space node) {
        current = node;
    }
  
    public Space GetCurrent() {
        return current;
    }

    //Attempts a transition from the current space to a space with the name of direction.
    public void Transition (string direction) {
        //Searches for a direction to the next space and assigns the space to a variable
        Space next = current.FollowEdge(direction);
        // if the direction does not exists assign it as null and return a message.
        if (next == null) {
            Console.WriteLine($"Du er forvirret og går i cirkler, mens du leder efter '{direction}'. Til sidst giver du op 😩");
        } else {
            //if the direction to the space was found, leave the current space and shift into the new space.
            current.Goodbye();
            current = next;
            current.Welcome();
        }
    }
  
    //Ends the game.
    public void MakeDone () {
        done = true;
    }

    //Tells whether the game has finished.  
    public bool IsDone () {
        return done;
    }
}
