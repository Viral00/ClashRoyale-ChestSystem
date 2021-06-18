using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinsManager : MonoBehaviour
{
    public ChestScriptable ChestScriptableObj;

    private void ChestCoins()
    {
        int Coins = Random.Range(ChestScriptableObj.CoinsMin, ChestScriptableObj.CoinsMax);
    }
}
