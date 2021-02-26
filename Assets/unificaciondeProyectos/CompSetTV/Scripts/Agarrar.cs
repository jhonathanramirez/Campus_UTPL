﻿using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Agarrar : MonoBehaviour
{
    public string _tagObjects = "Respawn";
   
    [Space(10)]
    public Sprite texturaManoCerrada;
    public Sprite textturaManoAbierta;
    bool canMove;
    bool isMoving;
    float distance;
    float rotXTemp;
    float rotYTemp;
    float tempDistance;
    RaycastHit tempHit;
    Rigidbody rbTemp;
    Vector3 rayEndPoint;
    Vector3 tempDirection;
    Vector3 tempSpeed;
    GameObject tempObject;
    Camera mainCamera;
    GameObject objClosedHand;
    GameObject objOpenHand;
    public GameObject panel;
    public Text nameObject;
    private String nombreObjeto;

    void Start()
    {
        panel.SetActive(false);
    }
    void Awake()
    {
        distance = 2;
        mainCamera = Camera.main;

        //automatic set layer in player
        GameObject refTemp = transform.root.gameObject;
        refTemp.layer = 2;
        foreach (Transform trans in refTemp.GetComponentsInChildren<Transform>(true))
        {
            trans.gameObject.layer = 2;
        }
        //
        float tempDistance = 0.3f;
        float tempfloatNear = mainCamera.nearClipPlane;
        if (tempfloatNear >= tempDistance)
        {
            tempDistance = tempfloatNear + 0.05f;
        }
        if (texturaManoCerrada)
        {
            objClosedHand = new GameObject("objHandTextureClosed");
            objClosedHand.transform.parent = this.transform;
            objClosedHand.AddComponent<SpriteRenderer>().sprite = texturaManoCerrada;
            objClosedHand.transform.localPosition = new Vector3(0.0f, 0.0f, tempDistance);
            objClosedHand.transform.localScale = new Vector3(0.05f, 0.05f, 0.05f);
            objClosedHand.transform.localRotation = Quaternion.identity;
            objClosedHand.SetActive(false);
        }
        if (textturaManoAbierta)
        {
            objOpenHand = new GameObject("objHandTextureOpen");
            objOpenHand.transform.parent = this.transform;
            objOpenHand.AddComponent<SpriteRenderer>().sprite = textturaManoAbierta;
            objOpenHand.transform.localPosition = new Vector3(0.0f, 0.0f, tempDistance);
            objOpenHand.transform.localScale = new Vector3(0.05f, 0.05f, 0.05f);
            objOpenHand.transform.localRotation = Quaternion.identity;
            objOpenHand.SetActive(false);

         
        }
    }
 void Update()
    {
        //raycast camera forward
        rayEndPoint = transform.position + transform.forward * distance;
        if (Physics.Raycast(transform.position, transform.forward, out tempHit, 7))
        {
            if (Vector3.Distance(transform.position, tempHit.point) <= 6 && tempHit.transform.CompareTag(_tagObjects))
            {
                canMove = true;
            }
            else
            {
                canMove = false;
            }
            
            if (Input.GetKeyDown(KeyCode.Mouse0) && canMove)
            {
                if (tempHit.rigidbody)
                {
                    tempHit.rigidbody.useGravity = true;
                    distance = Vector3.Distance(transform.position, tempHit.point);
                    tempObject = tempHit.transform.gameObject;
                    isMoving = true;
                }

                panel.SetActive(true);
            }
        }
        else
        {
            canMove = false;
           
        }

       
        distance = Mathf.Clamp(distance, 2.5f, 6);
        if (tempObject)
        {
            rbTemp = tempObject.GetComponent<Rigidbody>();
        }

        if (Input.GetKeyUp(KeyCode.Mouse0) && tempObject)
        {
            rbTemp.useGravity = true;
            tempObject = null;
            rbTemp = null;
            isMoving = false;
        }
       
        if (tempObject)
        {
            if (Vector3.Distance(transform.position, tempObject.transform.position) > 6)
            {
                rbTemp.useGravity = true;
                tempObject = null;
                rbTemp = null;
                isMoving = false;
            }
        }

        if (tempObject && mainCamera)
        {
            if (Input.GetKey(KeyCode.R))
            {
                rotXTemp = Input.GetAxis("Mouse X") * 5.0f;
             
                tempObject.transform.Rotate(0, rotXTemp,0);
         
            }
        }
        //sprite elements
        if (canMove && !isMoving && textturaManoAbierta)
        {
            objClosedHand.SetActive(false);
            objOpenHand.SetActive(true);
            nombreObjeto = tempHit.transform.gameObject.ToString();


            if (nombreObjeto== "Tripode 1 (UnityEngine.GameObject)" || nombreObjeto == "Tripode 2 (UnityEngine.GameObject)")
            {
              nameObject.text = "";
                
            }
            else
            {
                Debug.Log(nombreObjeto);
                nameObject.text = nombreObjeto;
            }
            
           // Debug.Log(tempHit.transform.gameObject.ToString());
            panel.SetActive(false);
        }
        else if (isMoving && texturaManoCerrada)
        {
            objClosedHand.SetActive(true);
            objOpenHand.SetActive(false);
        }
        else
        {
            objClosedHand.SetActive(false);
            objOpenHand.SetActive(false);
           nameObject.text = "";
        }
    }
    void FixedUpdate()
    {
        if (tempObject)
        {
            rbTemp = tempObject.GetComponent<Rigidbody>();
            rbTemp.angularVelocity = new Vector3(0, 0, 0);
            tempSpeed = (rayEndPoint - rbTemp.transform.position);
            tempSpeed.Normalize();
            tempDistance = Vector3.Distance(rayEndPoint, rbTemp.transform.position);
            tempDistance = Mathf.Clamp(tempDistance, 0, 1);
            rbTemp.velocity = Vector3.Lerp(rbTemp.velocity, tempSpeed * 7.5f * tempDistance, Time.deltaTime * 12);
        }
    }


}
