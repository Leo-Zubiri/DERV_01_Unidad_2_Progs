using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotacionMouse : MonoBehaviour
{
    [SerializeField]
    float velX = 20;

    [SerializeField]
    float velY = 5;

    [SerializeField]
    GameObject camara;

    float ejeRotacionObj;
    float ejeRotacionCam;

    // Start is called before the first frame update
    void Start()
    {

    }

    void FixedUpdate()
    {
        ejeRotacionObj = Input.GetAxis("Mouse X");
        ejeRotacionCam += Input.GetAxis("Mouse Y") * velX;

        this.transform.Rotate(0, ejeRotacionObj * velY, 0);

        ejeRotacionCam = Mathf.Clamp(ejeRotacionCam, -25, 25);
        camara.transform.localEulerAngles = new Vector3(-ejeRotacionCam, 0f, 0f);
    }
}
