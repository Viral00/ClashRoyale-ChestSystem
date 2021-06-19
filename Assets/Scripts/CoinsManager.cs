using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinsManager : MonoBehaviour
{
    [SerializeField]private ChestScriptable CommonChestObj;
    [SerializeField] private ChestScriptable RareChestObj;
    [SerializeField] private ChestScriptable EpicChestObj;
    [SerializeField] private ChestScriptable LegendaryChestObj;

    private List<ChestScriptable> ChestObj = new List<ChestScriptable>();

    private void Awake()
    {
        ChestObj.Add(CommonChestObj);
        ChestObj.Add(RareChestObj);
        ChestObj.Add(EpicChestObj);
        ChestObj.Add(LegendaryChestObj);
    }

    private void CreateChest()
    {

    }


    private void ChestOpen()
    {
        int Coins = Random.Range(CommonChestObj.CoinsMin, CommonChestObj.CoinsMax);
        int Gems = Random.Range(CommonChestObj.GemsMin, CommonChestObj.GemsMax);
    }

}
