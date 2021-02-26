using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class recogerObjetos : MonoBehaviour
{
    public float interactDistance = 3;
    public float carryDistance = 2.5f;
    public LayerMask interactLayer;
    public float rotSpeed = 20;
    private Transform carryObject;
    private bool haveObject;

    void Update()
    {
        //Raycast 
        Ray ray = new Ray(Camera.main.transform.position, Camera.main.transform.forward);
        RaycastHit hit;


        if (Physics.Raycast(ray, out hit, interactDistance, interactLayer))
        {
           
            if (Input.GetMouseButtonDown(0))
            {
                carryObject = hit.transform;
                carryObject.GetComponent<Rigidbody>().useGravity = false;
                haveObject = true;
            }
            //if (Input.GetMouseButtonDown(1))
            //{
            //    float rotY = Input.GetAxis("Mouse X") * rotSpeed * Mathf.Deg2Rad;
            //    carryObject.Rotate(new Vector3(0,rotY,0));
            //}

        }
        
      
        if (Input.GetMouseButtonUp(0))
        {
            if (haveObject)
            {
                haveObject = false;
                carryObject.GetComponent<Rigidbody>().useGravity = true;
                carryObject = null;
            }
        }

     
        if (haveObject)
        {
            carryObject.position = Vector3.Lerp(carryObject.position, Camera.main.transform.position + Camera.main.transform.forward * carryDistance, Time.deltaTime * 8);
            carryObject.GetComponent<Rigidbody>().velocity = Vector3.zero;
        }
    }
}