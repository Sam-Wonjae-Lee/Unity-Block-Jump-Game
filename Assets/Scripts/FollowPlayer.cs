using UnityEngine;

public class FollowPlayer : MonoBehaviour
{
    public Transform player;
    public Vector3 offset;

    // Vector3 stores three different numbers
    // camera position is equal to player position
    void Update()
    {
        transform.position = player.position + offset;
    }
}
