using FishNet.Object;
using FishNet.Object.Synchronizing;
using System.Diagnostics;
using TMPro;
using UnityEngine;

public class GameManager : NetworkBehaviour
{
    [SyncVar(Channel = FishNet.Transporting.Channel.Unreliable, SendRate = 0.5f, OnChange = nameof(OnChangeWarHP))]
    private int warriorHP = 100;
    
    [SerializeField]
    public TextMeshProUGUI txtWarrHP;

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
        //Debug.WriteLine("OnChangeWarHP called");
    }

    public void DecreaseWarriorHP()
    {
        this.warriorHP--;

    }

    private void UpdateWarHPUI()
    {
        txtWarrHP.text = "Warrior HP: " + warriorHP;
    }
}
