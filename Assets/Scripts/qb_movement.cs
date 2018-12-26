using UnityEngine;
using System.Collections;

public class qb_movement : MonoBehaviour
{
    public Rigidbody2D rb;
    public float forwardForce = 10f;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    void FixedUpdate()
    {
        if (Input.GetKey("w"))
        {
            //
            rb.AddForce(transform.up * forwardForce);
        }
        if (Input.GetKey("s"))
        {
            rb.AddForce(-transform.up * forwardForce);
        }
        if (Input.GetKey("d"))
        {
            rb.AddForce(transform.right * forwardForce);
        }
        if (Input.GetKey("a"))
        {
            rb.AddForce(-transform.right * forwardForce);
        }
    }
}
