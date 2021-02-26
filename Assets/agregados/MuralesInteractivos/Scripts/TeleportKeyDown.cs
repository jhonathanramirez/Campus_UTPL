using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TeleportKeyDown : TeleportCharacter
{
    public GameObject panelPressF;
    bool validate;
    private void Start()
    {
        //tp = GetComponent<TeleportCharacter>();
        panelPressF.SetActive(false);

    }
    private void OnTriggerEnter(Collider other)
    {

        if(other.gameObject.tag == "Player")
        {
            panelPressF.SetActive(true);
            validate = true;
        }

    }

    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            panelPressF.SetActive(false);
            validate = false;
        }

    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.F) && validate)
        {
            LoadTeleport();
            panelPressF.SetActive(false);
        }
    }
}
