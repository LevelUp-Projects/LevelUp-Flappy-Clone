using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Rigidbody),typeof(BoxCollider))]
public class GameManager : MonoBehaviour
{
    [Header("Programming stuff")]
    private LevelMover columnPrefab;
    public Player player;
    public WaitForSeconds wait;
    [Tooltip("Interval between columns")] public float waitTime;
    [Header("Scriptable objects")]
    private CoinScriptableObject[] coinData;
    private LevelScriptableObject level;
    [Header("Level Selection")]
    [SerializeField] private int currentLevel;

    //SEM SCORE
    private void Awake()
    {
        wait = new WaitForSeconds(waitTime);
    }
    // Start is called before the first frame update
    void Start()
    {
        level = Resources.Load<LevelScriptableObject>($"Levels/Level{currentLevel}");
        columnPrefab = Resources.Load<LevelMover>($"Columns/Column{level.columnId}");
        coinData = Resources.LoadAll<CoinScriptableObject>("Coins");
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
            column.Init(new Vector3(8, Random.Range(-2f, 2f)),coinData[Random.Range(0,coinData.Length)]);
            yield return wait;
        }
    }
    public void AddScore()
    {
        //PRIDAJ SCORE
        //UPDATNI UI
    }
}
