using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityStandardAssets.Characters.FirstPerson;

public class pausaJuego : MonoBehaviour
{
    public bool pause;
    private FirstPersonController fpsScirpt;
    public GameObject panelPausa;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            pause = !pause;
        }
        if (pause)
        {
            fpsScirpt = GameObject.FindGameObjectWithTag("Player").GetComponent<FirstPersonController>();
            Time.timeScale = 0;
            fpsScirpt.enabled = false;
            Cursor.lockState = CursorLockMode.None;
            panelPausa.SetActive(true);

            Cursor.visible = true;
        }
        else if (!pause)
        {
            fpsScirpt = GameObject.FindGameObjectWithTag("Player").GetComponent<FirstPersonController>();
            Time.timeScale= 1;
            fpsScirpt.enabled = true;
            Cursor.lockState = CursorLockMode.Locked;
            panelPausa.SetActive(false);
            Cursor.visible = false;
        }
        
    }
    public void salir()
    {
        Application.Quit();
    }
}
