using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ChangeScene : MonoBehaviour
{
    public Animator salida;
    // Start is called before the first frame update
    void Start()
    {
        salida = GetComponent<Animator>();
    }

    public void LoadScene(string scene)
    {
        StartCoroutine(TransitionScene(scene));
    }

    IEnumerator TransitionScene(string scene)
    {
        salida.SetTrigger("Salida");
        yield return new WaitForSeconds(1);
        SceneManager.LoadScene(scene);
    }
}
