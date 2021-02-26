using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class encenderLuz : MonoBehaviour
{
    public bool entro;
    public bool encender;
    public GameObject Luz;
    public GameObject boton , aro,e1,e2,e3,e4;

    
    public Material matRojo;
    public Material matVerde,emision,normal;
    private Renderer re,reAro,re1,re2,re3,re4;

    AudioSource auS;
    public AudioClip interruptor;



    // Start is called before the first frame update
    void Start()
    {
        auS = GetComponent<AudioSource>();
        re = boton.GetComponent<Renderer>();
        reAro = aro.GetComponent<Renderer>();
        re1 = e1.GetComponent<Renderer>();
        re2 = e2.GetComponent<Renderer>();
        re3 = e3.GetComponent<Renderer>();
        re4 = e4.GetComponent<Renderer>();
    }
    // Update is called once per frame
    void Update()


    {
        //comprobamos si encender esta en true para encender la luz
        if (encender)
        {
            Luz.SetActive(true);
            re.material = matVerde;
            reAro.material = emision;
            re1.material = emision;
            re2.material = emision;
            re3.material = emision;
            re4.material = emision;

        }
        else
        //en caso q este en false se apaga la luz
        {
            Luz.SetActive(false);
            re.material = matRojo;
            reAro.material = normal;
            re1.material = normal;
            re2.material = normal;
            re3.material = normal;
            re4.material = normal;

        }
        //comprobamos si esta dentro del area y presiono la tecla e
        if (Input.GetKeyDown("e") && entro)
        {
            //se le asigna el valor contrario al que tenia encender
            //Si se encuendra prendido se apaga y viceversa
            encender = !encender;

            auS.clip = interruptor;
            auS.Play();

        }
        
       
    }
    //Presentamos un pequeño mensaje para indicar que debe presionar
    private void OnGUI()
    {
        if (entro)
        {
            GUI.Label(new Rect(Screen.width / 2 - 75, Screen.height - 100, 150, 40), "Presione 'E' para encender/apagar");
        }
    }
    //Metodos triggers para ver si el jugador esta dentro del area

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
