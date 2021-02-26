using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MixPantallas : MonoBehaviour
{
    //Los scripts para saber si esta encendiada la camra
    public EncenderCamara camera1;
    public EncenderCamara camera2;
    public EncenderCamara camera3;
    public EncenderCamara camera4;
    private bool enceder1,enceder2,enceder3,enceder4;
    private Renderer render;
    //Obtenemos la texturas de lo q estan enfoncando las camaras

    public Material pantalla1;
    public Material pantalla2;
    public Material pantalla3;
    public Material pantalla4;
    public Material noSignal;
    public GameObject pantalla;
    public GameObject panel;
    public GameObject nombre1, nombre2, nombre3, nombre4;
    private bool entro;

    // Start is called before the first frame update
    void Start()
    {
        //obtenemos el render de los objetos (pantallas)
        render = pantalla.GetComponent<Renderer>();
        panel.SetActive(false);
        nombre1.SetActive(false);
        nombre2.SetActive(false);
        nombre3.SetActive(false);
        nombre4.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        //Obtenetes su valor si esta encendido o no la camara
        enceder1 = camera1.getEncnder();
        enceder2 = camera2.getEncnder();
        enceder3 = camera3.getEncnder();
        enceder4 = camera4.getEncnder();
        //Si se presiona uno se a al pantalla se le asigna la textura de la camara 1
        if (Input.GetKeyDown(KeyCode.Alpha1)&&entro)
        {
            nombre1.SetActive(true);
            nombre2.SetActive(false);
            nombre3.SetActive(false);
            nombre4.SetActive(false);
            //Veridficamos si el estado de la camara si esta encendido o no
            if (enceder1)
            {
                render.material = pantalla1;
            }
            else
            {
                render.material = noSignal;
            }

        }
      
        //Si se presiona 2 se a al pantalla se le asigna la textura de la camara 2
        if (Input.GetKeyDown(KeyCode.Alpha2) && entro)
        {
            nombre1.SetActive(false);
            nombre2.SetActive(true);
            nombre3.SetActive(false);
            nombre4.SetActive(false);
            if (enceder2)
            {
                render.material = pantalla2;
            }
            else
            {
                render.material = noSignal;
            }
        }
      //Si se presiona 3 se a al pantalla se le asigna la textura de la camara 3
        if (Input.GetKeyDown(KeyCode.Alpha3) && entro)
        {
        
            nombre1.SetActive(false);
            nombre2.SetActive(false);
            nombre3.SetActive(true);
            nombre4.SetActive(false);
            //Veridficamos si el estado de la camara si esta encendido o no
            if (enceder3)
            {
                render.material = pantalla3;
            }
            else
            {
                render.material = noSignal;
            }
        }
       
                    
    //Si se presiona 4 se a al pantalla se le asigna la textura de la camara 4

        if (Input.GetKeyDown(KeyCode.Alpha4) && entro)
        {
            nombre1.SetActive(false);
            nombre2.SetActive(false);
            nombre3.SetActive(false);
            nombre4.SetActive(true);
        
            //Veridficamos si el estado de la camara si esta encendido o no
            if (enceder4)
            {
                render.material = pantalla4;
            }
            else
            {
                render.material = noSignal;
            }
        }
     
        if (entro)
        {
            panel.SetActive(true);
        }
        else
        {
            panel.SetActive(false);
        }
        
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            entro = true;
          
        }
    }
    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            entro = false;
        }
    }
}
