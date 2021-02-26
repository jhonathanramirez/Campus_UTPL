using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class interruptorLuzAmbiental : MonoBehaviour
{
    public GameObject luz;
    public bool encender;
    public bool entro;
    public GameObject foco1, foco2, foco3, foco4, foco5, foco6, foco7, foco8, foco9, foco10;
   // AudioSource auS;
    public AudioClip interruptor;

    // Start is called before the first frame update
  

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown("e") && entro)
        {
            //se le asigna el valor contrario al que tenia encender
            //Si se encuendra prendido se apaga y viceversa
            encender = !encender;


        }
        if (encender)
        {
            luz.SetActive(true);
            foco1.SetActive(true);
            foco2.SetActive(true);
            foco3.SetActive(true);
            foco4.SetActive(true);
            foco5.SetActive(true);
            foco6.SetActive(true);
            foco7.SetActive(true);
            foco8.SetActive(true);
            foco9.SetActive(true);
            foco10.SetActive(true);

        }
        else
        //en caso q este en false se apaga la luz
        {
            luz.SetActive(false);
            foco1.SetActive(false);
            foco2.SetActive(false);
            foco3.SetActive(false);
            foco4.SetActive(false);
            foco5.SetActive(false);
            foco6.SetActive(false);
            foco7.SetActive(false);
            foco8.SetActive(false);
            foco9.SetActive(false);
            foco10.SetActive(false);
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
