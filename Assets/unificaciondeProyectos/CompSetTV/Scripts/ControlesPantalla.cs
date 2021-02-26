using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class ControlesPantalla : MonoBehaviour
{
    // Start is called before the first frame update
 // Assign in the inspector
     public GameObject objectToRotate;
    private Vector3 defaultRot;
    public Slider slider;
    public bool rot;
    public Text lblGrados;
    public Text lblDireccion;
    float centro;


    private float previousValue;
     void Update()

    {
        //check press key r for change
             if (Input.GetKeyDown("r") )
        {
            rot = !rot;
           
        }
        if (rot)
        {
            lblDireccion.text = "" + "Derecha";
        }
        else
        {
            lblDireccion.text = "" + "Izquierda";
        }    }
    void Awake ()
     {
         // Assign a callback for when this slider changes
         this.slider.onValueChanged.AddListener (this.OnSliderChanged);
 
         // And current value
         this.previousValue = this.slider.value;
     }
 
     void OnSliderChanged (float value)
     {

        // How much we've changed
        float delta = value - this.previousValue;
       
        if (rot)
        {
            this.objectToRotate.transform.Rotate(Vector3.up*delta*90);
            
            lblGrados.text = " " + this.previousValue * 90 + "°";
           

        }
        else 
        {
            this.objectToRotate.transform.Rotate(Vector3.up * delta *-90 );
           
            lblGrados.text = " " + this.previousValue * -90 + "°";
           
        }
         
 
         // Set our previous value for the next change
         this.previousValue = value;
       


    }
  
}
