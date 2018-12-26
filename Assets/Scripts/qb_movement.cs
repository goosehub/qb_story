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
            if (rb.position.y < 4) {
                rb.AddForce(transform.up * forwardForce);
            }
        }
        if (Input.GetKey("s"))
        {
            if (rb.position.y > -4) {
                rb.AddForce(-transform.up * forwardForce);
            }
        }
        if (Input.GetKey("d"))
        {
            if (rb.position.x < 4) {
                rb.AddForce(transform.right * forwardForce);
            }
        }
        if (Input.GetKey("a"))
        {
            if (rb.position.x > -4) {
                rb.AddForce(-transform.right * forwardForce);
            }
        }
    }
}
