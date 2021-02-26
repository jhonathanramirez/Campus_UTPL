using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AbrirPuertas1 : MonoBehaviour
{
    public float smooth = 2.0f;
    public float DoorOpenAngle = 75.0f;
    private bool open;
    public bool enter;
    private Vector3 defaultRot;
    private Vector3 openRot;

 
    // Start is called before the first frame update
    void Start()
    {
       //Inicializamos nuestro vector para obtener en la posisicion inicial
        defaultRot = transform.eulerAngles;
	// Obtenemos nuestro objetos en la posiscion que se encuentra  en x, y y z
        openRot = new Vector3(defaultRot.x, defaultRot.y + DoorOpenAngle, defaultRot.z);
    }

    // Update is called once per frame
    void Update()
    {
	//Comprobamos si esta dentro del trigger
        if (enter)
        {
            //Open door
		//rotamos nuestra puerta para abrirla
          
            transform.eulerAngles = Vector3.Slerp(transform.eulerAngles, openRot, Time.deltaTime * smooth);
          

        }
        else
        {
            //Close door
           //Se  vuelve el objeto a la posicion inicial
            transform.eulerAngles = Vector3.Slerp(transform.eulerAngles, defaultRot, Time.deltaTime * smooth);
          
        }

      

    }
      private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            //Monificamos el valor de la variable enter del script abrir puertas
            enter = true;
            smooth = 4.0f;
            //activamos audio
            

            Debug.Log("Entro");
        }
    }
    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            //Monificamos el valor de la variable enter del script abrir puertas
            enter = false;
            smooth = 1.0f;

        }
    }


}
