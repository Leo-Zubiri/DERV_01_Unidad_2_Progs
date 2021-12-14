using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovFuerzaBala : MonoBehaviour
{
    [SerializeField]
    float velBala = 10;

    Rigidbody rb;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        rb.AddForce(transform.forward * velBala, ForceMode.Impulse);
    }
}
