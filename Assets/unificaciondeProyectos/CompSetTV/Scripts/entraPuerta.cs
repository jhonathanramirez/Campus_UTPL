using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class entraPuerta : MonoBehaviour
{
    // Start is called before the first frame update
    public abrirPuerta abriPuertas;
    private AudioSource sourceAudio;
    public GameObject door;
    public AudioClip openDoor;
    public AudioClip closeDoor;
    void Start()
    {
        sourceAudio = door.GetComponent<AudioSource>();
    }
    
    //Metodos triggers para ver si el jugador esta dentro del area
    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            //Monificamos el valor de la variable enter del script abrir puertas
            abriPuertas.enter = true;
            abriPuertas.smooth = 4.0f;
            //activamos audio
            sourceAudio.clip = openDoor;
            sourceAudio.Play();

            Debug.Log("Entro");
        }
    }
    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            //Monificamos el valor de la variable enter del script abrir puertas
            abriPuertas.enter = false;
            abriPuertas.smooth = 6.0f;
            sourceAudio.clip = closeDoor;
            sourceAudio.Play();

        }
    }
}
