using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityStandardAssets.Characters.FirstPerson;

public class ElegirLuces : MonoBehaviour
{
    private bool entro,auxEntro;
    public pausaJuego pausa;
    public GameObject panelOpciones;
    public FirstPersonController controladorPersona;
    //Scripts de cada una de las lineas de las tramoyas
    public lucesTramoyas lucesLinea1;
    public lucesTramoyas lucesLinea2;
    public lucesTramoyas lucesLinea3;

    // Start is called before the first frame update
    void Start()
    {
        panelOpciones.SetActive(false);   
    }

    // Update is called once per frame
    void Update()
    {
     //Comprobamos si entro en el area para poder presentar las opciones
        if (entro)
        {

            panelOpciones.SetActive(true);
         
        }
        else
        {
            panelOpciones.SetActive(false);
            
        }
        //Verificamos que tecla presiona para presenta los paneles de cada luz

        if ((Input.GetKeyDown(KeyCode.Alpha1) || Input.GetKeyDown(KeyCode.Alpha2)|| Input.GetKeyDown(KeyCode.Alpha3)) && entro)
        {
            //Desactivamos el script del jugador y activamos el moouse
            
            controladorPersona.enabled = false;
            Cursor.lockState = CursorLockMode.None;
            Cursor.visible = true;
            if (entro && Input.GetKeyDown(KeyCode.Alpha1))
            {
           
                lucesLinea1.entro = true;
                auxEntro = entro;
                entro = false;
                pausa.enabled = false;
            }

            if (entro && Input.GetKeyDown(KeyCode.Alpha2))
            {
                pausa.enabled = false;
                lucesLinea2.entro = true;
                auxEntro = entro;
                entro = false;

            }
            if (entro && Input.GetKeyDown(KeyCode.Alpha3))
            {
                pausa.enabled = false;
                lucesLinea3.entro = true;
                auxEntro = entro;
                entro = false;
            }
          
        }

        //Si presiona enter y esta manipulado las luces

        if (auxEntro && Input.GetKeyDown(KeyCode.Escape))
        {
       
            lucesLinea1.entro = false;
            lucesLinea2.entro = false;
            lucesLinea3.entro = false;
            entro = true;
            auxEntro = false;
            controladorPersona.enabled = true;

            Cursor.lockState = CursorLockMode.Locked;
            Cursor.visible = false;
            pausa.enabled = true;
        }

    }
    //Metodos trigger para comprobar si el jugador entro a una area en especifico
        private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag=="Player")
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
