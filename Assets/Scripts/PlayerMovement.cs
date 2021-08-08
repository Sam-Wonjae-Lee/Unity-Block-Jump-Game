using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public Rigidbody rb;

    // number with f indicates float - Only for Unity
    public float forwardForce = 1000f;
    public float sidewaysForce = 500f;

    // Runs when game starts
    void Start()
    {
        Debug.Log("Game has started");

    }

    // Update is called once per frame
    // FixedUpdate is smoother related to physics - not good with jumping
    void FixedUpdate()
    {

        rb.AddForce(0, 0, forwardForce * Time.deltaTime);

        if ( Input.GetKey("d") )
        {
            rb.AddForce(sidewaysForce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);

        }

        if (Input.GetKey("a"))
        {
            rb.AddForce(-sidewaysForce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);

        }

        if (rb.position.y < -3f)
        {
            FindObjectOfType<GameManager>().EndGame();
        }
    }
}
