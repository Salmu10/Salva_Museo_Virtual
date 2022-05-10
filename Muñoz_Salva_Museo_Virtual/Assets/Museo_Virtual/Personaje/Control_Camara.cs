using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Control_Camara : MonoBehaviour{

    public Camera FPSCamera;


    public float velocidad;

    // public float horizontalSpeed;
    // public float verticalSpeed;


    float h;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        h = velocidad * Input.GetAxis("Horizontal") * Time.deltaTime;
       //v = verticalSpeed * Input.GetAxis("Vertical");

        transform.Rotate(0, h, 0);
        FPSCamera.transform.Rotate(-0, 0, 0);

        if (Input.GetKey(KeyCode.UpArrow))
        {
            transform.Translate(0, 0, 0.07f);
        } else {

            if
                (Input.GetKey(KeyCode.DownArrow)){
                transform.Translate(0, 0, -0.07f);
            }
        }
    }
}
      
