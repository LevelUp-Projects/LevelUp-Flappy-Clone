using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinBehaviour : MonoBehaviour
{
    private SpriteRenderer image;
    private int coinAmount;
    private void Awake()
    {
        image = GetComponent<SpriteRenderer>();
    }
    public void Init(CoinScriptableObject scriptableObject)
    {
        image.sprite = scriptableObject.sprite;
        coinAmount = scriptableObject.coins;
        print(coinAmount);
    }
}
