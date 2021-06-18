using UnityEngine;

[CreateAssetMenu(fileName = "NewChest" , menuName = "New Chest")]
public class ChestScriptable : ScriptableObject
{
    public string ChestName;
    public int CoinsMin;
    public int CoinsMax;
    public int GemsMin;
    public int GemsMax;
    public int TimeInSeconds;
}
