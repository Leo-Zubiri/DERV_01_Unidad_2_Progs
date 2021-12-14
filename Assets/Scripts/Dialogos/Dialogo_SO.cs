using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Dialogo_SO : MonoBehaviour
{
    [SerializeField]
    Dialogo dialogo;

    public int indexActual;

    public GameObject contenedorImagen;
    public Image image;

    [SerializeField]
    public GameObject contenedorDialogo;

    [SerializeField]
    public TextMeshProUGUI texto;

    [SerializeField]
    Sprite imgDefecto;

    bool keyState = true;

    private void Awake()
    {
        contenedorImagen = GameObject.Find("ContenedorUI");
        image = contenedorImagen.GetComponentInChildren<Image>();
    }

    // Start is called before the first frame update
    void Start()
    {
        indexActual = -1;
        contenedorDialogo.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        // Debug.Log(dialogo.getCantidadMensajes());

        if (Input.GetKeyDown(KeyCode.F) && keyState == true) // Atrás
        {
            contenedorDialogo.SetActive(true);

            if (indexActual > 0)
            {
                indexActual--;
                image.sprite = dialogo.getDatosPersonaje(indexActual).personaje.imagen; // La forma más correcta

                // image.sprite = dialogo.mensaje[indexActual].personaje.imagen;

                texto.text = dialogo.getDatosPersonaje(indexActual).dialogos;

                texto.richText = true;
                texto.maxVisibleCharacters = 0;
                StopAllCoroutines();
                StartCoroutine("mostrarTexto");
            }
            else
            {
                // De momento, no se hace nada.
            }
        }

        if (Input.GetKeyDown(KeyCode.G) && keyState == true) // Adelante
        {
            contenedorDialogo.SetActive(true);

            if (indexActual < dialogo.getCantidadMensajes() -1)
            {
                indexActual++;
                image.sprite = dialogo.getDatosPersonaje(indexActual).personaje.imagen;
                texto.text = dialogo.getDatosPersonaje(indexActual).dialogos;



                texto.richText = true;
                texto.maxVisibleCharacters = 0;
                StopAllCoroutines();
                StartCoroutine("mostrarTexto");

            }
            else
            {
                // De momento, no se hace nada.
            }
        }

        if (Input.GetKeyDown(KeyCode.Q) && keyState == true)
        {
            contenedorDialogo.SetActive(false);
            indexActual = -1;
            texto.text = "Sin texto";
            image.sprite = imgDefecto;
        }
    }

    IEnumerator mostrarTexto()
    {
        keyState = false;

        bool estado;

        estado = true;

        while (estado == true)
        {

            float largo = texto.text.Length;

            if (texto.maxVisibleCharacters < largo)
            {
                texto.maxVisibleCharacters += 1;
            }

            Debug.Log("Ejecución Corrutina");
            yield return new WaitForSeconds(0.25f);

            if(texto.maxVisibleCharacters == largo)
            {
                estado = false;
            }

        }

        Debug.Log("Corrutina detenida");
        StopCoroutine("mostrarTexto");
        keyState = true;
    }

    // Tarea para el 19 / 10 / 2021:
    // Detener la corrutina cuando acaba de mostrar todo el texto
    // Asegurarse de no poder ejecutar un mensaje hasta que el anterior haya sido mostrado completamente
}
