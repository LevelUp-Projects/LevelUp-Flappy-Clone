using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public LevelMover columnPrefab;
    public Player player;
    public float waitTime;
    public WaitForSeconds wait;
    private void Awake()
    {
        wait = new WaitForSeconds(waitTime);
    }
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(PrepareGame());
    }
    IEnumerator PrepareGame()
    {
        Player playerInstance = Instantiate(player);
        yield return wait;
        playerInstance.Init();
        while (true)
        {
            LevelMover column = Instantiate(columnPrefab);
            column.Init(new Vector3(8, Random.Range(-2f, 2f)));
            yield return wait;
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
