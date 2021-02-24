using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Player : MonoBehaviour
{
    private Rigidbody2D rb;
    public float power;
    public float rotationPower;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    public void Init()
    {
        rb.bodyType = RigidbodyType2D.Dynamic;
    }

    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            rb.velocity = Vector2.zero;
            rb.AddForce(Vector2.up * power,ForceMode2D.Impulse);
        }
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.CompareTag("Column"))
        {
            //GAME OVER
        }
    }

}

