using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    
    Rigidbody2D rb;
    SurfaceEffector2D surfaceEffector;

    [SerializeField] float torque = 1f;

    float normalSpeed = 15f;
    float boostSpeed = 25f;
    bool canMove = true;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        surfaceEffector = FindObjectOfType<SurfaceEffector2D>();
    }

    // Update is called once per frame
    void Update()
    {
        if (canMove)
        {
            RotatePlayer();
            BoostPlayer();
        }
        
    }

    void BoostPlayer()
    {
        if (Input.GetKey(KeyCode.UpArrow))
        {
            surfaceEffector.speed = boostSpeed;
        }
        else 
            surfaceEffector.speed = normalSpeed;
    }

    void RotatePlayer()
    {
        
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            rb.AddTorque(torque);
        }
        else if (Input.GetKey(KeyCode.RightArrow))
        {
            rb.AddTorque(-torque);
        }
    }

    public void DisableControls()
    {
        canMove = false;
    }
}
