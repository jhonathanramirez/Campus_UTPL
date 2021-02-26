using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EncenderCamara : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject lente1;
    public GameObject lente2;
    public bool entro;
 
    public bool encender;
    AudioSource auS;
    public AudioClip interruptor;
    void Start()
    {
        auS = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        if (encender)
        {
            lente1.SetActive(true);
            lente2.SetActive(true);
        }
        else
        {
            lente1.SetActive(false);
            lente2.SetActive(false);
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

            GUI.Label(new Rect(Screen.width / 2 - 75, Screen.height - 100, 250, 50), "Presione 'E' para encender/apagar la camara");

        }


    }
    //Metodos set y get
    public bool getEncnder()
    {
        return encender;
    }
    public void setEncender(bool encender)
    {
        this.encender = encender;
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
