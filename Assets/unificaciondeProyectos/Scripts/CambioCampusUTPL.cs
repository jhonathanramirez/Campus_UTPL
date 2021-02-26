using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;



public class CambioCampusUTPL : MonoBehaviour
{
    public bool entro;
    private void OnGUI()
    {
        if (entro)
        {

            GUI.Label(new Rect(Screen.width / 2 - 75, Screen.height - 100, 250, 50), "Presione 'E' para volver al Campus UTPL");

        }



    }
    private void Update()
    {


        if (Input.GetKeyDown("e") && entro)
        {


            SceneManager.LoadScene("campusUTPL");

        }
    }
private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            //  SceneManager.LoadScene("campusUTPL");
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
