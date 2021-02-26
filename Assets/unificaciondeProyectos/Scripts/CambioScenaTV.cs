using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CambioScenaTV : MonoBehaviour
{
    public bool entro;
    
    private void OnGUI()
    {
        if (entro)
        {
            GUI.Box(new Rect(Screen.width / 2 - 75, Screen.height - 100, 250, 50), " ");
            GUI.Label(new Rect(Screen.width / 2 - 75, Screen.height - 100, 250, 50), "Presione 'E' para Ingresar al Set de Televisión ");
        }
    }
    private void Update()
    {
        if (Input.GetKeyDown("e") && entro)
        {
            //cargo la otra scena
            SceneManager.LoadScene("SampleScene");      
        }
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            //SceneManager.LoadScene("SampleScene");
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