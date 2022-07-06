using Eyes4Eye.Decks;
using Eyes4Eye.Rounds;
using FishNet.Object;
using FishNet.Object.Synchronizing;

/*
 * Board Pawn controlled by the player 
 */
namespace Eyes4Eye.Player
{
    public sealed class Pawn : NetworkBehaviour
    {
        [SyncVar] public Player controller;
        [SyncVar]
        public int hitPoints;
        [SyncVar]
        public RoleEnum role;
        [SyncVar]
        public CardPool hand;
        [SyncVar]
        public CardPool library;
        [SyncVar]
        public CardPool discardPile;
        [SyncVar]
        public CardPool Board;
        [SyncVar]
        public CardPool slot;
    }
}