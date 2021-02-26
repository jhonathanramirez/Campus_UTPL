using System.Collections;
using UnityEngine;

public class TeleportCharacter : MonoBehaviour
{
    // Start is called before the first frame update
    public Transform character;
    public Transform point;
    public Transform pointReturn;

    public GameObject BtnReturn;

    public Animator salida;

    // Start is called before the first frame update
    void Start()
    {
        salida = GetComponent<Animator>();
        BtnReturn.SetActive(false);
    }

    public void LoadTeleport()
    {
        StartCoroutine(TransitionTeleport());
    }

    IEnumerator TransitionTeleport()
    {
        salida.SetTrigger("Salida");
        yield return new WaitForSeconds(1);
        character.position = point.position;
        character.rotation = point.rotation;
        BtnReturn.SetActive(true);


    }
    public void LoadTeleportReturn()
    {
        StartCoroutine(TransitionTeleportReturn());
    }

    IEnumerator TransitionTeleportReturn()
    {
        salida.SetTrigger("Salida");
        yield return new WaitForSeconds(1);
        character.position = pointReturn.position;
        character.rotation = pointReturn.rotation;
        BtnReturn.SetActive(false);
    }
}
