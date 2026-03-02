using UnityEngine;

public class Platform : MonoBehaviour
{

    float jumpForce = 8f;

    void OnCollisionEnter2D(Collision2D player) {
    
        Rigidbody2D rb = player.collider.GetComponent<Rigidbody2D>();
        if(player.relativeVelocity.y <= 0f) {
        
            if (rb != null) {

            Vector2 velocity = rb.linearVelocity;
            velocity.y = jumpForce;
            rb.linearVelocity = velocity;
        }
        
        
    }
        
    }
}
