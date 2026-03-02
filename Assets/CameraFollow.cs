using UnityEngine;

public class CameraFollower : MonoBehaviour
{
    public Transform player;

    private void LateUpdate()
    {
        if (player != null)
        {
            Vector3 newPos = new Vector3(transform.position.x, player.position.y, transform.position.z);
            transform.position = newPos;
        }
    }
}