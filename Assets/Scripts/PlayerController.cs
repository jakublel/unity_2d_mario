using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{

    private Rigidbody2D rb;
    private BoxCollider2D boxCollider2D;
    public LayerMask whatIsGround;

    public bool jump;
    public bool doublejump;
    public float jumpforce;
    public float liftingforce;
    private float timestamp;

    // Start is called before the first frame update
    void Start()
    {
        rb = gameObject.GetComponent<Rigidbody2D>();
        boxCollider2D = GetComponent<BoxCollider2D>();
    }
    void Update()
    {
        if (!GameManager.instance.inGame) return;

        if (IsGrounded() && Time.time>=timestamp)
        {
            if(jump || doublejump)
            {
                jump = false;
                doublejump = false;
            }
            timestamp = Time.time + 1f;
        }
        if (Input.GetMouseButtonDown(0))
        {
            if (!jump)
            {
                rb.velocity = (new Vector2(0f, jumpforce));
                jump = true;
                
            }
            else if (!doublejump)
            {
                rb.velocity = (new Vector2(0f, jumpforce));
                doublejump = true;
            }
        }

        if (Input.GetMouseButton(0) && rb.velocity.y<=0 )
        {
            rb.AddForce(new Vector2(0f, liftingforce * Time.deltaTime));

        }

    }

    private bool IsGrounded()
    {
        RaycastHit2D hit = Physics2D.BoxCast(boxCollider2D.bounds.center, boxCollider2D.bounds.size, 0f, Vector2.down, 0.1f, whatIsGround);
        return hit.collider != null;
    }

    

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Obstacle") && !GameManager.instance.immortality.isActive)
        {
            PlayerDeath();
        }
        else if (collision.CompareTag("Coin"))
        {
            GameManager.instance.CoinCollected();
            Destroy(collision.gameObject);
        }
        else if (collision.CompareTag("Immortality"))
        {
            GameManager.instance.ImmortalityCollected();
            Destroy(collision.gameObject);
        
        }
        else if (collision.CompareTag("Magnet"))
        {
            GameManager.instance.MagnetCollected();
            Destroy(collision.gameObject);
        }

    }
    void PlayerDeath()
    {
        rb.constraints = RigidbodyConstraints2D.FreezeAll;
        GameManager.instance.GameOver();
    }
}
