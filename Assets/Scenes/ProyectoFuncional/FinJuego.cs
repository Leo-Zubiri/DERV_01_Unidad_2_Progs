using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class FinJuego : MonoBehaviour
{
    [SerializeField]
    TextMeshProUGUI usu;

    [SerializeField]
    TextMeshProUGUI punt;

    // Start is called before the first frame update
    void Start()
    {
        string usuario = PlayerPrefs.GetString("usu");
        int puntuacion = PlayerPrefs.GetInt("score");

        usu.text = usuario;
        punt.text = puntuacion.ToString();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
