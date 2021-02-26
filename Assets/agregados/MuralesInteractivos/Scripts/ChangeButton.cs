using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events; // this namespace makes the magic, tho

public class ChangeButton : MonoBehaviour
{

    [SerializeField] 
    public UnityEvent anEvent; 

    private void OnMouseDown()
    {
        anEvent.Invoke(); // Triggers the events you have setup in the inspector
    }

    // This is the first method the event is setup to do, the second audio part needed no script to just do a one shot effect, thanks to the event system.
    // You just set up the Event in the inspector for easy peasy, but the UnityEvent could also be coded the same way if needed.
}