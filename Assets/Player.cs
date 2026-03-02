using UnityEngine;

public class Player : MonoBehaviour
{
    public Rigidbody2D rb;
    float movement = 0f;
    float movementSpeed = 10f;

    void Start()
    {

    }

    void Update()
    {
        movement = Input.GetAxis("Horizontal") * movementSpeed;
    }


    void FixedUpdate()
    {
        Vector2 velocity = rb.linearVelocity;
        velocity.x = movement;
        rb.linearVelocity = velocity;
    }

    void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("End"))
            Time.timeScale = 0f;
    }
}
