using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CamaraPrimeraPersona : MonoBehaviour
{

    public Camera Camara_PrimeraPersona;

    public float horizontalSpeed;

    public float verticalSpeed;

    float h;    // Variable local donde guardamos el movimiento del raton
    float v;    // Variable local donde guardamos el movimiento del raton

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

        h = horizontalSpeed * Input.GetAxis("Horizontal");
        // v = verticalSpeed * Input.GetAxis("Mouse Y");

        transform.Rotate(0, h, 0);
        Camara_PrimeraPersona.transform.Rotate(-v, 0, 0);

        if (Input.GetKey(KeyCode.W)) {

            transform.Translate(0, 0, 0.1f);

        } else {

            if (Input.GetKey(KeyCode.S))
            {

                transform.Translate(0, 0, -0.1f);

            } 
        }
    }
}
