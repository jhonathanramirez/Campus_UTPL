using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityStandardAssets.Characters.FirstPerson;

public class lucesTramoyas : MonoBehaviour
{
    public bool entro;
    public bool encender, encender2, encender3, encender4, encender5, encender6, encender7;
    public GameObject check, check1, check2, check3, check4, check5, check6;
    public GameObject Luz;
    public GameObject Luz2;
   
    public GameObject Luz3;
    public GameObject Luz4;
    public GameObject Luz5;
    public GameObject Luz6;
    public GameObject Luz7;
   public GameObject ob1, ob2, ob3, ob4, ob5, ob6,ob7;

    public GameObject panel;
    public GameObject panel2;
    private bool res;


    // Start is called before the first frame update
    void Start()
    {
        desactivarObjetos();

    }
    // Update is called once per frame
    void Update()


    {
       //Comprobomas las teclas que presiona para encender la luz 
       // presiona 1 y esta dentro del area se activa  la primera luz
        if (Input.GetKeyDown(KeyCode.Alpha1) && entro)
        {
            //Se cambia el valor de la variable por el contrario
            encender = !encender;
            if (encender)
            {
                //Se activa la luz
                Luz.SetActive(true);
                ob1.GetComponent<MeshRenderer>().enabled = true;
                check.SetActive(true);

            }
            else
            {
                Luz.SetActive(false);
                ob1.GetComponent<MeshRenderer>().enabled = false;
                check.SetActive(false);
            }
        }    // presiona 2 y esta dentro del area se activa  la segunda luz
        if (Input.GetKeyDown(KeyCode.Alpha2) && entro)
        {
            encender2 = !encender2;
            if (encender2)
            {
                //Se activa la luz
                Luz2.SetActive(true);
                ob2.GetComponent<MeshRenderer>().enabled = true;
                check1.SetActive(true);

            }
            else
            {
                Luz2.SetActive(false);
                ob2.GetComponent<MeshRenderer>().enabled = false;
                check1.SetActive(false);

            }
        }    // presiona 3 y esta dentro del area se activa  la tercera luz
        if (Input.GetKeyDown(KeyCode.Alpha3) && entro)
        {
            encender3 = !encender3;
            if (encender3)
            {
                //Se activa la luz
                Luz3.SetActive(true);
                ob3.GetComponent<MeshRenderer>().enabled = true;
                check2.SetActive(true);


            }
            else
            {
                Luz3.SetActive(false);
                ob3.GetComponent<MeshRenderer>().enabled = false;
                check2.SetActive(false);

            }
        }    // presiona 4 y esta dentro del area se activa  la cuarta luz
        if (Input.GetKeyDown(KeyCode.Alpha4) && entro)
        {
            encender4 = !encender4;
            if (encender4)
            {
                //Se activa la luz
                Luz4.SetActive(true);
                ob4.GetComponent<MeshRenderer>().enabled = true;
                check3.SetActive(true);

            }
            else
            {
                Luz4.SetActive(false);
                ob4.GetComponent<MeshRenderer>().enabled = false;
                check3.SetActive(false);
            }
        }    // presiona 5 y esta dentro del area se activa  la quinta  luz
        if (Input.GetKeyDown(KeyCode.Alpha5) && entro)
        {
            encender5 = !encender5;
            if (encender5)
            {
                //Se activa la luz
                Luz5.SetActive(true);
                ob5.GetComponent<MeshRenderer>().enabled = true;
                check4.SetActive(true);
          

            }
            else
            {
                Luz5.SetActive(false);
                ob5.GetComponent<MeshRenderer>().enabled = false;
                check4.SetActive(false);
                
            }
        }    // presiona 6 y esta dentro del area se activa  la sexta luz
        if (Input.GetKeyDown(KeyCode.Alpha6) && entro)
        {
            encender6 = !encender6;
            if (encender6)
            {
                //Se activa la luz
                Luz6.SetActive(true);
                ob6.GetComponent<MeshRenderer>().enabled = true;
                check5.SetActive(true);


            }
            else
            {
                Luz6.SetActive(false);
                ob6.GetComponent<MeshRenderer>().enabled = false;
                check5.SetActive(false);
            }
        }    // presiona 7 y esta dentro del area se activa  la septima luz
        if (Input.GetKeyDown(KeyCode.Alpha7) && entro)
        {
            encender7 = !encender7;
            if (encender7)
            {
                //Se activa la luz
                Luz7.SetActive(true);
                ob7.GetComponent<MeshRenderer>().enabled = true;
                check6.SetActive(true);

            }
            else
            {
                Luz7.SetActive(false);
                ob7.GetComponent<MeshRenderer>().enabled = false;
                check6.SetActive(false);
            }
        }


        if (entro)
        {

            panel.SetActive(true);

            panel2.SetActive(true);
        }
        else
        {
            panel.SetActive(false);
            panel2.SetActive(false);
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
   private void desactivarObjetos()
    {
        check.SetActive(false);
        check1.SetActive(false);
        check2.SetActive(false);
        check3.SetActive(false);
        check4.SetActive(false);
        check5.SetActive(false);
        check6.SetActive(false);
        check6.SetActive(false);
        Luz.SetActive(false);
        Luz2.SetActive(false);
        Luz3.SetActive(false);
        Luz4.SetActive(false);
        Luz5.SetActive(false);
        Luz6.SetActive(false);
        Luz7.SetActive(false);
        ob1.GetComponent<MeshRenderer>().enabled = false;
        ob2.GetComponent<MeshRenderer>().enabled = false;
        ob3.GetComponent<MeshRenderer>().enabled = false;
        ob4.GetComponent<MeshRenderer>().enabled = false;
        ob5.GetComponent<MeshRenderer>().enabled = false;
        ob6.GetComponent<MeshRenderer>().enabled = false;
        ob7.GetComponent<MeshRenderer>().enabled = false;
        ////  playerScript = GameObject.FindGameObjectWithTag("Player").GetComponent<FirstPersonController>();
        panel.SetActive(false);
        panel2.SetActive(false);
    }
}
