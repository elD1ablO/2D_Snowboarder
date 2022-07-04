using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    Rigidbody2D rb;

    [SerializeField] float torque = 1f;
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
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
}
