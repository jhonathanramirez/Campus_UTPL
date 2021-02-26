using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class EventsObjects : MonoBehaviour
{
	public Material border;
	public Material nonBorder;

	public void OnMouseOver()
	{
		GetComponent<Renderer>().material = border;
	}

	public void OnMouseExit()
	{
		GetComponent<Renderer>().material = nonBorder;
	}
}

