using FishNet.Object;
using FishNet.Object.Synchronizing;
using TMPro;
using UnityEngine;
using Debug = UnityEngine.Debug;

public class GameManager : NetworkBehaviour
{
    [SyncVar(Channel = FishNet.Transporting.Channel.Unreliable, SendRate = 0.5f, OnChange = nameof(OnChangeWarHP))]
    private int warriorHP = 100;

    [SyncVar(Channel = FishNet.Transporting.Channel.Unreliable,ReadPermissions = ReadPermission.Observers, SendRate = 0.5f, OnChange = nameof(OnChangeMSG))]
    private string statusMsg;

    

    [SerializeField]
    public TextMeshProUGUI txtWarrHP;
    [SerializeField]
    public TextMeshProUGUI txtStatus;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void OnChangeWarHP(int oldValue, int nweValue, bool asServer)
    {
        UpdateWarHPUI();
    }
    private void OnChangeMSG(string oldValue, string newValue, bool asServer)
    {
        UpdateStatusUI();
    }

    public void DecreaseWarriorHP()
    {
        this.warriorHP--;

    }

    public void ChangeStatusMsg()
    {
        this.statusMsg = "STATUS: " + Time.fixedTime;
        
    }

    private void UpdateWarHPUI()
    {
        txtWarrHP.text = "Warrior HP: " + warriorHP;
    }

    private void UpdateStatusUI()
    {
        txtStatus.text = "STATUS: " + statusMsg;
    }
}
