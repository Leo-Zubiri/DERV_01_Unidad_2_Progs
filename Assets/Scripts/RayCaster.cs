using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RayCaster : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 origen = transform.position;
        Vector3 direccion = /*transform.forward*/ new Vector3 (0, -1, 0);
        RaycastHit hit; // Almacena info de la colisión

        float distancia = 10f; // Distancia del rayo

        int layerMask;

        QueryTriggerInteraction queryTrigger = QueryTriggerInteraction.Collide;

        float duracionRayo = 1;

        if(Physics.Raycast(origen, direccion, out hit, distancia))
        {
            //hit // Extrae la información del objeto con el que colisionó
            Debug.DrawRay(origen, direccion * hit.distance, Color.yellow, duracionRayo);

            /*
            string nombre = hit.collider.gameObject.name;
            GameObject temp = GameObject.Find(nombre);
            Destroy(temp);
            */

        }
        else
        {
            Debug.DrawRay(origen, direccion * distancia, Color.red, duracionRayo);
        }

    }

    private void OnDrawGizmos()
    {
        Gizmos.color = Color.black;
        Gizmos.DrawRay(transform.position, transform.forward * 10f);
    }
}
