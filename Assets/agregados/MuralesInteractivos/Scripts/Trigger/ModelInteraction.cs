using System.Collections;
using UnityEngine;
using TMPro;


public class ModelInteraction : MonoBehaviour
{
    public GameObject panelDescription;
    public TextMeshProUGUI response;
    private void Start()
    {
        
        panelDescription.SetActive(false);
    }
    public IEnumerator GetData()
    {   
        response = GameObject.Find("Response2").GetComponent<TextMeshProUGUI>();
        response.text += "AUTOR (ES):";
        foreach (var obj in Request2.data.autores)
            {
                response.text += "\n    "+obj;
            }
        response.text += "\nUBICACIÓN: " + Request2.data.ubicacion;
        response.text += "\nTÉCNICA: " + Request2.data.tecnica;
        response.text += "\nDIMENSIONES: " + Request2.data.dimensiones;
        yield return new WaitForSeconds(0.1f);
    }

    public void OnTriggerEnter(Collider other)
    {
        if (other.tag=="Player")
        {
            panelDescription.SetActive(true);
            StartCoroutine(GetData());
        }
    }

    public void OnTriggerExit(Collider other)
    {
        if (other.tag == "Player")
        {
            panelDescription.SetActive(false);
            response.text = "";
        }
    }
}
