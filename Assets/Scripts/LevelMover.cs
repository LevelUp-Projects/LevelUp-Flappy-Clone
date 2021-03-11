using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelMover : MonoBehaviour
{
    public float moveSpeed = 5;
    public CoinBehaviour coin;
    
    public void Init(Vector3 pos, CoinScriptableObject coinData)
    {
        transform.position = pos;
        CoinBehaviour coinInstance = Instantiate(coin,transform,false);
        coinInstance.Init(coinData);
    }
    void Update()
    {
        transform.Translate(Vector2.left * moveSpeed * Time.deltaTime);
    }
}
