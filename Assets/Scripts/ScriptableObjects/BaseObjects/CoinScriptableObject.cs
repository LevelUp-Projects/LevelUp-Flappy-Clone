using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "Coin ScriptableObject", menuName = "CustomObjects/Coins", order = 1)]
public class CoinScriptableObject : ScriptableObject
{
    public Sprite sprite;
    public int coins;
}
