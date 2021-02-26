using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AnimMural1 : MonoBehaviour
{
    Animator anim;
    public AudioSource mural1;
    public GameObject muralCanvas1;
    public GameObject camMural1;
    public GameObject marco;
    public Canvas canvasMain;
    private void Start()
    {
        anim = GetComponent<Animator>();
        mural1 = GetComponent<AudioSource>();
        marco.SetActive(false);
        muralCanvas1.SetActive(false);
        camMural1.SetActive(false);

    }
    public void PlayButton()
    {
        anim.gameObject.GetComponent<Animator>().enabled = true;
        anim.SetTrigger("anim1");
        anim.SetTrigger("anim2");
        anim.SetTrigger("anim3");
        anim.SetTrigger("anim4");
        anim.SetTrigger("anim5");
        anim.SetTrigger("anim6");
        anim.SetTrigger("anim7");
        anim.SetTrigger("anim8");
        mural1.Play();
        muralCanvas1.SetActive(true);
        camMural1.SetActive(true);
        canvasMain.GetComponent<Canvas>().enabled = false;
        marco.SetActive(true);
    }

    public void StopButton()
    {
        anim.gameObject.GetComponent<Animator>().enabled = false;
        mural1.Stop();
        muralCanvas1.SetActive(false);
        camMural1.SetActive(false);
        canvasMain.GetComponent<Canvas>().enabled = true;
        marco.SetActive(false);
    }
}
