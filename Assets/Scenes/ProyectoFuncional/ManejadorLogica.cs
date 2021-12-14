using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class ManejadorLogica : MonoBehaviour
{
    public TextMeshProUGUI usuario;
    public int contador;
    public bool exCorut;

    private void Start()
    {
        contador = 10;

        if(exCorut)
        {
            StopAllCoroutines();
            StartCoroutine("auxiliarTest");
        }
    }

    public void iniciarJuego()
    {
        PlayerPrefs.SetString("usu", usuario.text);
        Debug.Log(usuario.text);
        SceneManager.LoadScene(1);
    }

    IEnumerator auxiliarTest()
    {
        while(true)
        {
            contador--;
            if (contador == 0)
            {
                PlayerPrefs.SetInt("score", Random.Range(10, 100));
                SceneManager.LoadScene(2);
            }
            yield return new WaitForSeconds(1.0f);
        }
    }
}
