using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cuadro_4 : MonoBehaviour
{

    public GameObject Canvas_Cuadro_4;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    private void OnMouseDown()
    {
        Canvas_Cuadro_4.SetActive(true);
    }

    // Update is called once per frame
    void Update()
    {
        bool space = Input.GetKeyDown(KeyCode.Space);

        if (space)
        {
            Canvas_Cuadro_4.SetActive(false);
        }
    }
}
