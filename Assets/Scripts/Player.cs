using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Player : MonoBehaviour
{
    private Rigidbody2D rb;
    public float power;
    public float rotationPower;

    public int enemyLayer = 10;
    public float spawnColumnDelay = 3;
    public GameObject columnPrefab;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();

        StartCoroutine(SpawnObstaclesCoroutine());
    }

    IEnumerator SpawnObstaclesCoroutine()
    {
        while(true)
        {
            GameObject col = Instantiate(columnPrefab);
            col.transform.position = new Vector3( 8, Random.Range(-2, 2), 0);
            col.transform.rotation = Quaternion.identity;

            yield return new WaitForSeconds(spawnColumnDelay);
        }
    }

    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            rb.velocity = Vector2.zero;
            rb.AddForce(Vector2.up * power,ForceMode2D.Impulse);
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.layer == enemyLayer)
            SceneManager.LoadScene( SceneManager.GetActiveScene().name );
    }

}

