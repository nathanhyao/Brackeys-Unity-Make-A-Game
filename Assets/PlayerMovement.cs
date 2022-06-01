using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public Rigidbody rb;

    public float forwardForce = 2000f;
    public float sidewaysForce = 500f;

    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("Hello, world!");
        // rb.useGravity = false;
        // rb.AddForce(0, 200, 500); // x y z
    }

    // Update is called once per frame
    void FixedUpdate() // FixedUpdate better than Update for physics
    {
        rb.AddForce(0, 0, forwardForce * Time.deltaTime); // x y z

        if (Input.GetKey("d"))
        {
            rb.AddForce(sidewaysForce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
        }
        if (Input.GetKey("a"))
        {
            rb.AddForce(-sidewaysForce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
        }
    }
}