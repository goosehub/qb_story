using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pass_the_ball : MonoBehaviour
{
    public Rigidbody2D ball;

    void Start()
    {
        
    }

    void FixedUpdate()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Debug.Log("Pressed primary button.");
            ball.position = Camera.main.ScreenToWorldPoint(new Vector2(Input.mousePosition.x, Input.mousePosition.y));
        }

        if (Input.GetMouseButtonDown(1))
        {
            Debug.Log("Pressed secondary button.");
        }

        if (Input.GetMouseButtonDown(2))
        {
            Debug.Log("Pressed middle click.");
        }
    }
}
