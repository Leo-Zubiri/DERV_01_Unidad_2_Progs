using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Velocidad : MonoBehaviour
{
    Rigidbody rb;

    [SerializeField]
    float velocidad = 50;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {

    }

    private void FixedUpdate()
    {
        // rb.AddForce(new Vector3(0, 0, 0), ForceMode.Force);

        //rb.AddForce(Vector3.right * velocidad, ForceMode.VelocityChange);   // GLOBALES
        rb.AddForce(transform.right * velocidad, ForceMode.VelocityChange);   // LOCALES
    }
}
