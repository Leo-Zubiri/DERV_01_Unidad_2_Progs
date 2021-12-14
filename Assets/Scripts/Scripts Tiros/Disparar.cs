using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Disparar : MonoBehaviour
{

    [SerializeField]
    GameObject posSpawner;

    [SerializeField]
    GameObject bala;

    int i;

    // Start is called before the first frame update
    void Start()
    {
        i = 0;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.F))
        {
            GameObject proyectil = Instantiate(bala, posSpawner.transform.position, posSpawner.transform.rotation);

            proyectil.name = "Municion " + i;
            i++;

            Destroy(proyectil, 5);
        }
    }
}
