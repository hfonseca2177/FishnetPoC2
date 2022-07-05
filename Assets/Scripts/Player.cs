using FishNet.Object;

/*
 * Player with all serializable attributes to be keep for a client
 */
namespace E4E
{
    public class Player : NetworkBehaviour
    {

        //TODO convert to network gettter and setter
        public int hitPoints;
        public RoleEnum role;
        public string playerName;
        public CardPool hand;
        public CardPool library;
        public CardPool discardPile;
        public CardPool Board;
        public CardPool slot;
        
    }

}
