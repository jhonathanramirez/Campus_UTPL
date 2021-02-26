using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class encendidoCamera : MonoBehaviour
{
    // Start is called before the first frame update
    public EncenderCamara camara;
    private bool enceder;
    public GameObject pantalla;

    // Update is called once per frame
    void Update()
    {
        //Verificamos si las camaras estan encendias para poder presentar en las pantallas
      enceder =camara.getEncnder();
        if (enceder)
        {
            pantalla.SetActive(true);
        }
        else
        {
            pantalla.SetActive(false);
        }
    }
}
