
using FishNet.Object;
using FishNet.Object.Synchronizing;

/*
 * Player with all serializable attributes to be keep for a client
 */
namespace Eyes4Eye.Player
{
    public sealed class Player : NetworkBehaviour
    {
        public static Player Instance { get; private set; }
       
        [SyncVar]
        public string playerName;
        [SyncVar]
        public Pawn pawn;
        [SyncVar] 
        public bool ready;
        
  

        public override void OnStartClient()
        {
            base.OnStartClient();
            if (!IsOwner) return;
            Instance = this;
        }
    }

}
