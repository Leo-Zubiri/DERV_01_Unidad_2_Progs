using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using System;

public class DetectarColisionBala : MonoBehaviour
{
    [SerializeField]
    TextMeshProUGUI textoPuntaje;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionEnter(Collision collision)
    {
        string etiqueta = collision.gameObject.tag;

        if (etiqueta.Equals("Municion"))
        {
            int temp = Convert.ToInt32(textoPuntaje.text) + 1;
            textoPuntaje.text = temp.ToString();

            string name = collision.gameObject.name;

            GameObject bala = GameObject.Find(name);

            Destroy(bala);
        }
    }

    
}
