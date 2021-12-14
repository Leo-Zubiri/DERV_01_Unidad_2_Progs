using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovFuerzas : MonoBehaviour
{

    [SerializeField]
    float fuerzaVel = 20;

    Rigidbody rb;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    private void FixedUpdate()
    {
        if (Input.GetKey(KeyCode.W))
        {
            rb.AddForce(transform.forward * fuerzaVel, ForceMode.Acceleration);
        }

        if (Input.GetKey(KeyCode.A))
        {
            rb.AddForce(transform.right * fuerzaVel * -1f , ForceMode.Acceleration);
        }

        if (Input.GetKey(KeyCode.S))
        {
            rb.AddForce(transform.forward * fuerzaVel * -1f, ForceMode.Acceleration);
        }

        if (Input.GetKey(KeyCode.D))
        {
            rb.AddForce(transform.right * fuerzaVel, ForceMode.Acceleration);
        }
    }
}
