using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovimientoFisicas : MonoBehaviour
{

    [SerializeField]
    float desplazamiento = 10;

    Rigidbody rb;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    void FixedUpdate()
    {
        if (Input.GetKey(KeyCode.W))
        {
            rb.MovePosition(rb.position + transform.forward * desplazamiento * Time.deltaTime);
        }

        if (Input.GetKey(KeyCode.A))
        {
            rb.MovePosition(rb.position + transform.right * desplazamiento * Time.deltaTime * -1f);
        }

        if (Input.GetKey(KeyCode.S))
        {
            rb.MovePosition(rb.position + transform.forward * desplazamiento * Time.deltaTime * -1f);
        }

        if (Input.GetKey(KeyCode.D))
        {
            rb.MovePosition(rb.position + transform.right * desplazamiento * Time.deltaTime);
        }
    }
}
