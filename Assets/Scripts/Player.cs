using UnityEngine;

public class Player : MonoBehaviour
{
    public Animator animator;
    private Rigidbody2D rb;
    public float power;
    public float rotationPower;

    private void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    public void Init()
    {
        rb.bodyType = RigidbodyType2D.Dynamic;
    }

    private void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            animator.SetTrigger("Jump");
            rb.velocity = Vector2.zero;
            rb.AddForce(Vector2.up * power,ForceMode2D.Impulse);
        }
    }

    public void EndOfAnimation()
    {
        Debug.LogError("Animation end");
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        animator.SetTrigger("Crashed");
        animator.SetFloat("Speed", 2 );

        if(collision.gameObject.CompareTag("Column"))
        {
            //GAME OVER
        }
    }
}