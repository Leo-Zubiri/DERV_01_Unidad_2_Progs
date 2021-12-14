using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveTowards : MonoBehaviour
{

    [SerializeField]
    GameObject objDestino;

    [SerializeField]
    float vel = 10;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 origen = transform.position;
        Vector3 destino = objDestino.transform.position;

        transform.LookAt(destino);

        destino.x -= 3.0f;
        //destino.z -= 3.0f;

        transform.position = Vector3.MoveTowards(origen, destino, vel * Time.deltaTime);

        // transform.position = Vector3.Lerp(origen, destino, vel * Time.deltaTime);

        // Vector3 currentVel = new Vector3(0f, 0f, 0f);
        // transform.position = Vector3.SmoothDamp(origen, destino, ref currentVel, vel * Time.deltaTime);

        float distancia = Vector3.Distance(origen, destino);
        Debug.Log(distancia);
    }   
}
